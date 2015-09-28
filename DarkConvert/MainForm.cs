using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkConvert
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void txtEldoradoMapFolder_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.EldoradoMapFolder = txtEldoradoMapFolder.Text;
            Properties.Settings.Default.Save();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtEldoradoMapFolder.Text = Properties.Settings.Default.EldoradoMapFolder;
            txtHOMapsFolder.Text = Properties.Settings.Default.HOMapFolder;
        }

        private void txtHOMapsFolder_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.HOMapFolder = txtHOMapsFolder.Text;
            Properties.Settings.Default.Save();
        }

        private void btnElLoadScenarioList_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(Properties.Settings.Default.EldoradoMapFolder, "tags.dat")))
            {
                Thread loadEldoritoTags = new Thread(LoadEldoritoTags);
                loadEldoritoTags.Start();
                btnElListDeps.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid Eldorado Map Directory.", "No tags.dat");
            }
        }
        public void ConsoleLogit(string Message, params object[] args)
        {
            ConsoleLog.Invoke(new MethodInvoker(delegate
             {
                 ConsoleLog.AppendText(string.Format(Message, args) + Environment.NewLine);
                 ConsoleLog.ScrollToCaret();
             }));
            using (StreamWriter sw = File.AppendText("DarkConvert.log"))
            {
                sw.WriteLine(string.Format(Message, args));
            }
        }

        //
        // ELDORADO
        //

        EldoradoLib.TagCache EldoradoTagCache;
        EldoradoLib.StringIdCache EldoradoStringIdCache;
        List<string> EldoradolistA = new List<string>();
        List<string> EldoradolistB = new List<string>();
        EldoradoLib.HaloTag[] EldoradoTags;
        private void LoadEldoritoTags()
        {
            ConsoleLogit("-------------------------");
            ConsoleLogit("Loading Eldorito Tags");
            var fileInfo = new FileInfo(Path.Combine(Properties.Settings.Default.EldoradoMapFolder, "tags.dat"));

            using (var stream = fileInfo.Open(FileMode.Open, FileAccess.Read))
                EldoradoTagCache = new EldoradoLib.TagCache(stream);


            ConsoleLogit("{0} tags loaded.", EldoradoTagCache.Tags.Count);

            // Load stringIDs
            var stringIdPath = Path.Combine(fileInfo.DirectoryName ?? "", "string_ids.dat");
            EldoradoStringIdCache = null;
            try
            {
                using (var stream = File.OpenRead(stringIdPath))
                    EldoradoStringIdCache = new EldoradoLib.StringIdCache(stream);
            }
            catch (IOException)
            {
                ConsoleLogit("Warning: unable to open string_ids.dat!");
                ConsoleLogit("Commands which require stringID values will be unavailable.");
            }

            ConsoleLogit("{0} strings loaded.", EldoradoStringIdCache.Strings.Count);
            var reader = new StreamReader(File.OpenRead(@"TagNames\Eldorado.csv"));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                EldoradolistA.Add(values[0]);
                EldoradolistB.Add(values[1]);
            }
            ConsoleLogit("{0} tag names loaded", EldoradolistA.Count);

            EldoradoTags = EldoradoTagCache.Tags.Where(t => t != null).ToArray();

            if (EldoradoTags.Length == 0)
            {
                ConsoleLogit("No tags found.");

            }

            var scnr = EldoradoTags.Where(t => t.Class.ToString() == "scnr").ToArray();

            if (scnr.Length == 0)
            {
                ConsoleLogit("No scenario tags found.");
            }
            foreach (var tag in scnr)
            {
                listElScenarios.Invoke(new MethodInvoker(delegate
                {
                    try
                    {
                        var offset = string.Format("0x{0:X8}", tag.Index);
                        var index = EldoradolistA.IndexOf(offset);

                        if (EldoradolistB[index] != "")
                        {
                            listElScenarios.Items.Add(string.Format("{0:X} [Offset = 0x{1:X}, Size = 0x{2:X}] ({3})", tag.Index, tag.Offset, tag.Size, EldoradolistB[index]));
                        }
                    }
                    catch (Exception)
                    {
                        listElScenarios.Items.Add(string.Format("{0} {1:X} [Offset = 0x{2:X}, Size = 0x{3:X}]", tag.Class, tag.Index, tag.Offset, tag.Size));
                    }
                }));
            }
            ConsoleLogit("{0} scenario tags loaded", scnr.Count());
        }
        private void btnElListDeps_Click(object sender, EventArgs e)
        {
            if (listElScenarios.SelectedIndex != -1)
            {
                Thread listElScenarioDependencies = new Thread(ListElScenarioDependencies);
                listElScenarioDependencies.Start();
            }
            else
            {
                MessageBox.Show("Please select a scenario you'd like to list from.");
            }
        }

        private void ListElScenarioDependencies()
        {
            EldoradoLib.HaloTag scnr = null;
            listElScenarios.Invoke(new MethodInvoker(delegate
            {
                scnr = EldoradoTags.Where(t => t.Class.ToString() == "scnr").ElementAt(listElScenarios.SelectedIndex);
            }));
            if (scnr.Dependencies.Count == 0)
            {
                ConsoleLogit("Scenario {0:X8} has no dependencies.", scnr.Index);

            }
            IEnumerable<EldoradoLib.HaloTag> dependencies;

            if (chkElAllDeps.Checked)
            {
                dependencies = EldoradoTagCache.Tags.FindDependencies(scnr);
            }
            else
            {
                dependencies = scnr.Dependencies.Where(i => EldoradoTagCache.Tags.Contains(i)).Select(i => EldoradoTagCache.Tags[i]);
            }

            ConsoleLogit("Found {0} Dependencies", dependencies.Count());

            foreach (var tag in dependencies)
            {
                try
                {
                    var offset = string.Format("0x{0:X8}", tag.Index);
                    var index = EldoradolistA.IndexOf(offset);

                    if (EldoradolistB[index] != "")
                    {
                        ConsoleLogit(string.Format("{0:X} {1} [Offset = 0x{2:X}, Size = 0x{3:X}] ({4})", tag.Index, tag.Class, tag.Offset, tag.Size, EldoradolistB[index]));
                    }
                }
                catch (Exception)
                {
                    ConsoleLogit(string.Format("{0:X} {1} [Offset = 0x{2:X}, Size = 0x{3:X}]", tag.Index, tag.Class, tag.Offset, tag.Size));
                }
            }
            ConsoleLogit("Done!");
        }

        //
        // HALO ONLINE 11.1.530945
        //
        private void btnHOLoadScenarioList_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(Properties.Settings.Default.HOMapFolder, "tags.dat")))
            {
                Thread loadHaloOnlineTags = new Thread(LoadHaloOnlineTags);
                loadHaloOnlineTags.Start();
                btnHOListDeps.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid Eldorado Map Directory.", "No tags.dat");
            }
        }
        HaloOnlineLib.TagCache HaloOnlineTagCache;
        HaloOnlineLib.StringIdCache HaloOnlineStringIdCache;
        List<string> HaloOnlinelistA = new List<string>();
        List<string> HaloOnlinelistB = new List<string>();
        HaloOnlineLib.HaloTag[] HaloOnlineTags;
        private void LoadHaloOnlineTags()
        {
            ConsoleLogit("-------------------------");
            ConsoleLogit("Loading Halo Online Tags");

            var fileInfo = new FileInfo(Path.Combine(Properties.Settings.Default.HOMapFolder, "tags.dat"));

            using (var stream = fileInfo.Open(FileMode.Open, FileAccess.Read))
                HaloOnlineTagCache = new HaloOnlineLib.TagCache(stream);


            ConsoleLogit("{0} tags loaded.", HaloOnlineTagCache.Tags.Count);


            // Load stringIDs
            var stringIdPath = Path.Combine(fileInfo.DirectoryName ?? "", "string_ids.dat");
            HaloOnlineStringIdCache = null;
            try
            {
                using (var stream = File.OpenRead(stringIdPath))
                    HaloOnlineStringIdCache = new HaloOnlineLib.StringIdCache(stream);
            }
            catch (IOException)
            {
                ConsoleLogit("Warning: unable to open string_ids.dat!");
                ConsoleLogit("Commands which require stringID values will be unavailable.");
            }

            ConsoleLogit("{0} strings loaded.", HaloOnlineStringIdCache.Strings.Count);
            var reader = new StreamReader(File.OpenRead(@"TagNames\HaloOnline.csv"));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                HaloOnlinelistA.Add(values[0]);
                HaloOnlinelistB.Add(values[1]);
            }
            ConsoleLogit("{0} tag names loaded", HaloOnlinelistA.Count);

            HaloOnlineTags = HaloOnlineTagCache.Tags.Where(t => t != null).ToArray();

            if (HaloOnlineTags.Length == 0)
            {
                ConsoleLogit("No tags found.");

            }

            var scnr = HaloOnlineTags.Where(t => t.Class.ToString() == "scnr").ToArray();

            if (scnr.Length == 0)
            {
                ConsoleLogit("No scenario tags found.");
            }
            foreach (var tag in scnr)
            {
                listHOScenarios.Invoke(new MethodInvoker(delegate
                {
                    try
                    {
                        var offset = string.Format("0x{0:X8}", tag.Index);
                        var index = HaloOnlinelistA.IndexOf(offset);

                        if (HaloOnlinelistB[index] != "")
                        {
                            listHOScenarios.Items.Add(string.Format("{0:X} [Offset = 0x{1:X}, Size = 0x{2:X}] ({3})", tag.Index, tag.Offset, tag.Size, HaloOnlinelistB[index]));
                        }
                    }
                    catch (Exception)
                    {
                        listHOScenarios.Items.Add(string.Format("{0} {1:X} [Offset = 0x{2:X}, Size = 0x{3:X}]", tag.Class, tag.Index, tag.Offset, tag.Size));
                    }
                }));
            }
            ConsoleLogit("{0} scenario tags loaded", scnr.Count());
        }


        private void btnHOListDeps_Click(object sender, EventArgs e)
        {
            if (listHOScenarios.SelectedIndex != -1)
            {
                Thread listHOScenarioDependencies = new Thread(ListHOScenarioDependencies);
                listHOScenarioDependencies.Start();
            }
            else
            {
                MessageBox.Show("Please select a scenario you'd like to list from.");
            }
        }
        private void ListHOScenarioDependencies()
        {
            HaloOnlineLib.HaloTag scnr = null;
            listHOScenarios.Invoke(new MethodInvoker(delegate
            {
                scnr = HaloOnlineTags.Where(t => t.Class.ToString() == "scnr").ElementAt(listHOScenarios.SelectedIndex);
            }));
            if (scnr.Dependencies.Count == 0)
            {
                ConsoleLogit("Scenario {0:X8} has no dependencies.", scnr.Index);

            }
            IEnumerable<HaloOnlineLib.HaloTag> dependencies;


            if (chkHOAllDeps.Checked)
            {
                dependencies = HaloOnlineTagCache.Tags.FindDependencies(scnr);
            }
            else
            {
                dependencies = scnr.Dependencies.Where(i => HaloOnlineTagCache.Tags.Contains(i)).Select(i => HaloOnlineTagCache.Tags[i]);
            }

            ConsoleLogit("Found {0} Dependencies", dependencies.Count());
            foreach (var tag in dependencies)
            {
                try
                {
                    var offset = string.Format("0x{0:X8}", tag.Index);
                    var index = HaloOnlinelistA.IndexOf(offset);

                    if (HaloOnlinelistB[index] != "")
                    {
                        ConsoleLogit(string.Format("{0:X} {1} [Offset = 0x{2:X}, Size = 0x{3:X}] ({4})", tag.Index, tag.Class, tag.Offset, tag.Size, HaloOnlinelistB[index]));
                    }
                }
                catch (Exception)
                {
                    ConsoleLogit(string.Format("{0:X} {1} [Offset = 0x{2:X}, Size = 0x{3:X}]", tag.Index, tag.Class, tag.Offset, tag.Size));
                }
            }
            ConsoleLogit("Done!");
        }

        private void btnEldoradoBrowse_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = txtEldoradoMapFolder.Text;
            fbd.ShowDialog();

            if (File.Exists(Path.Combine(fbd.SelectedPath, "tags.dat")))
            {
                txtEldoradoMapFolder.Text = fbd.SelectedPath;
            }
            else
            {
                MessageBox.Show("Invalid Eldorado Map Directory.", "No tags.dat");
            }
        }

        private void btnHOBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = txtHOMapsFolder.Text;
            fbd.ShowDialog();

            if (File.Exists(Path.Combine(fbd.SelectedPath, "tags.dat")))
            {
                txtHOMapsFolder.Text = fbd.SelectedPath;
            }
            else
            {
                MessageBox.Show("Invalid Halo Online Map Directory.", "No tags.dat");
            }
        }

        private void btnElExtract_Click(object sender, EventArgs e)
        {
            Thread elExtract = new Thread(ElExtract);
            elExtract.Start();
        }
        private void ElExtract()
        {
            EldoradoLib.HaloTag scnr = null;
            listElScenarios.Invoke(new MethodInvoker(delegate
            {
                scnr = EldoradoTags.Where(t => t.Class.ToString() == "scnr").ElementAt(listElScenarios.SelectedIndex);
            }));

            // EldoradoLib.TagCache cache = new EldoradoLib.TagCache(EldoradoTagCache);
            using (var tagsStream = new FileStream(Path.Combine(Properties.Settings.Default.EldoradoMapFolder, "tags.dat"), FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var tagContext = new EldoradoLib.Serialization.TagSerializationContext(tagsStream, EldoradoTagCache, scnr);

                var scenario = EldoradoLib.Serialization.TagDeserializer.Deserialize<EldoradoLib.TagStructures.Scenario>(new EldoradoLib.Serialization.TagSerializationContext(tagsStream, EldoradoTagCache, scnr));

                if (scenario.StructureBSPs.Count() == 0)
                {
                    ConsoleLogit("The scenario has no sbsps");
                    return;
                }
                ConsoleLogit("Found {0} SBSPs", scenario.StructureBSPs.Count());
                var sbsp = EldoradoLib.Serialization.TagDeserializer.Deserialize<EldoradoLib.TagStructures.ScenarioStructureBsp>(new EldoradoLib.Serialization.TagSerializationContext(tagsStream, EldoradoTagCache, scenario.StructureBSPs[0].Bsp));
                if (sbsp.CollisionMaterials.Count() == 0)
                {
                    ConsoleLogit("The sbsp has no matterials");
                    return;
                }
                ConsoleLogit("Found {0} Collision Materials", sbsp.CollisionMaterials.Count());

                List<EldoradoLib.TagStructures.Shader> ShaderList = new List<EldoradoLib.TagStructures.Shader>();


                foreach (var mat in sbsp.CollisionMaterials)
                {
                    var CollMatShader = new EldoradoLib.Serialization.TagSerializationContext(tagsStream, EldoradoTagCache, mat.Shader);
                    ShaderList.Add(EldoradoLib.Serialization.TagDeserializer.Deserialize<EldoradoLib.TagStructures.Shader>(CollMatShader));

                }
                if (ShaderList.Count() == 0)
                {
                    ConsoleLogit("Failed to find SBSPs Collision Material shaders.");
                    return;
                }
                ConsoleLogit("Found {0} Shaders", ShaderList.Count());
                ExtractElShaders(ShaderList, tagsStream);
            }
        }
        private void ExtractElShaders(List<EldoradoLib.TagStructures.Shader> ShaderList, FileStream tagsStream)
        {
            var resourceManager = new EldoradoLib.Resources.ResourceDataManager();
            try
            {
                resourceManager.LoadCachesFromDirectory(Properties.Settings.Default.EldoradoMapFolder);
            }
            catch
            {
                ConsoleLogit("Unable to load the resource .dat files.");
                ConsoleLogit("Make sure that they all exist and are valid.");
                return;
            }
            foreach (var shader in ShaderList)
            {
                for (var i = 0; i < shader.PredictedBitmap.Count; i++)
                {
                    var BitmapType = EldoradoStringIdCache.GetString(shader.PredictedBitmap[i].Type);

                    if (shader.PredictedBitmap[i].Bitmap == null)
                    {
                        continue;
                    }
                    var outPath = Path.Combine("EldoradoOutput", "bitmaps");


                    try
                    {
                        var offset = string.Format("0x{0:X8}", shader.PredictedBitmap[i].Bitmap.Index);
                        var index = EldoradolistA.IndexOf(offset);

                        if (EldoradolistB[index] != "")
                        {
                            outPath = Path.Combine(outPath, EldoradolistB[index] + "-" + BitmapType + ".dds");

                            ConsoleLogit(EldoradolistB[index]);
                        }
                        else
                        {
                            outPath = Path.Combine(outPath, shader.PredictedBitmap[i].Bitmap.Index.ToString("X8") + "-" + BitmapType + ".dds");
                            ConsoleLogit(shader.PredictedBitmap[i].Bitmap.Index.ToString("X8") + "-" + BitmapType + ".dds");
                        }
                    }
                    catch (Exception)
                    {
                        outPath = Path.Combine(outPath, shader.PredictedBitmap[i].Bitmap.Index.ToString("X8") + "-" + BitmapType + ".dds");
                        ConsoleLogit(shader.PredictedBitmap[i].Bitmap.Index.ToString("X8") + "-" + BitmapType + ".dds");
                    }

                    Directory.CreateDirectory(Path.GetDirectoryName(outPath));

                    try
                    {
                        var extractor = new EldoradoLib.Resources.Bitmaps.BitmapDdsExtractor(resourceManager);

                        var materialBitmapContext = new EldoradoLib.Serialization.TagSerializationContext(tagsStream, EldoradoTagCache, shader.PredictedBitmap[i].Bitmap);
                        var bitmap = EldoradoLib.Serialization.TagDeserializer.Deserialize<EldoradoLib.TagStructures.Bitmap>(materialBitmapContext);

                        var ddsOutDir = outPath;
                        for (var b = 0; b < bitmap.Images.Count; b++)
                        {
                            using (var outStream = File.Open(outPath, FileMode.Create, FileAccess.Write))
                            {
                                extractor.ExtractDds(bitmap, b, outStream);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        ConsoleLogit("Error extracting texture for sbsp: " + e.Message);
                    }
                }
            }
        }

        private void btnHOExtract_Click(object sender, EventArgs e)
        {
            Thread hoExtract = new Thread(HOExtract);
            hoExtract.Start();
        }
        private void HOExtract()
        {
            HaloOnlineLib.HaloTag scnr = null;
            listHOScenarios.Invoke(new MethodInvoker(delegate
            {
                scnr = HaloOnlineTags.Where(t => t.Class.ToString() == "scnr").ElementAt(listHOScenarios.SelectedIndex);
            }));

            using (var tagsStream = new FileStream(Path.Combine(Properties.Settings.Default.HOMapFolder, "tags.dat"), FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var tagContext = new HaloOnlineLib.Serialization.TagSerializationContext(tagsStream, HaloOnlineTagCache, scnr);

                var scenario = HaloOnlineLib.Serialization.TagDeserializer.Deserialize<HaloOnlineLib.TagStructures.Scenario>(new HaloOnlineLib.Serialization.TagSerializationContext(tagsStream, HaloOnlineTagCache, scnr));

                if (scenario.StructureBSPs.Count() == 0)
                {
                    ConsoleLogit("The scenario has no sbsps");
                    return;
                }
                ConsoleLogit("Found {0} SBSPs", scenario.StructureBSPs.Count());
                
                
                //TODO: Figure out why we can't have the full SBSP structure...
                var sbsp = HaloOnlineLib.Serialization.TagDeserializer.Deserialize<HaloOnlineLib.TagStructures.ScenarioStructureBsp>(new HaloOnlineLib.Serialization.TagSerializationContext(tagsStream, HaloOnlineTagCache, scenario.StructureBSPs[0].Bsp));
               
                if (sbsp.CollisionMaterials.Count() == 0)
                {
                    ConsoleLogit("The sbsp has no matterials");
                    return;
                }
                ConsoleLogit("Found {0} Collision Materials", sbsp.CollisionMaterials.Count());

                List<HaloOnlineLib.TagStructures.Shader> ShaderList = new List<HaloOnlineLib.TagStructures.Shader>();


                foreach (var mat in sbsp.CollisionMaterials)
                {
                    var CollMatShader = new HaloOnlineLib.Serialization.TagSerializationContext(tagsStream, HaloOnlineTagCache, mat.Shader);
                    ShaderList.Add(HaloOnlineLib.Serialization.TagDeserializer.Deserialize<HaloOnlineLib.TagStructures.Shader>(CollMatShader));

                }
                if (ShaderList.Count() == 0)
                {
                    ConsoleLogit("Failed to find SBSPs Collision Material shaders.");
                    return;
                }
                ConsoleLogit("Found {0} Shaders", ShaderList.Count());
                ExtractHOShaders(ShaderList, tagsStream);
                
            }
        }
        private void ExtractHOShaders(List<HaloOnlineLib.TagStructures.Shader> ShaderList, FileStream tagsStream)
        {
            var resourceManager = new HaloOnlineLib.Resources.ResourceDataManager();
            try
            {
                resourceManager.LoadCachesFromDirectory(Properties.Settings.Default.HOMapFolder);
            }
            catch
            {
                ConsoleLogit("Unable to load the resource .dat files.");
                ConsoleLogit("Make sure that they all exist and are valid.");
                return;
            }
            foreach (var shader in ShaderList)
            {
                for (var i = 0; i < shader.PredictedBitmap.Count; i++)
                {
                    var BitmapType = HaloOnlineStringIdCache.GetString(shader.PredictedBitmap[i].Type);

                    if (shader.PredictedBitmap[i].Bitmap == null)
                    {
                        continue;
                    }
                    var outPath = Path.Combine("HaloOnlineOutput", "bitmaps");


                    try
                    {
                        var offset = string.Format("0x{0:X8}", shader.PredictedBitmap[i].Bitmap.Index);
                        var index = HaloOnlinelistA.IndexOf(offset);

                        if (HaloOnlinelistB[index] != "")
                        {
                            outPath = Path.Combine(outPath, HaloOnlinelistB[index] + "-" + BitmapType + ".dds");

                            ConsoleLogit(HaloOnlinelistB[index]);
                        }
                        else
                        {
                            outPath = Path.Combine(outPath, shader.PredictedBitmap[i].Bitmap.Index.ToString("X8") + "-" + BitmapType + ".dds");
                            ConsoleLogit(shader.PredictedBitmap[i].Bitmap.Index.ToString("X8") + "-" + BitmapType + ".dds");
                        }
                    }
                    catch (Exception)
                    {
                        outPath = Path.Combine(outPath, shader.PredictedBitmap[i].Bitmap.Index.ToString("X8") + "-" + BitmapType + ".dds");
                        ConsoleLogit(shader.PredictedBitmap[i].Bitmap.Index.ToString("X8") + "-" + BitmapType + ".dds");
                    }

                    Directory.CreateDirectory(Path.GetDirectoryName(outPath));

                    try
                    {
                        var extractor = new HaloOnlineLib.Resources.Bitmaps.BitmapDdsExtractor(resourceManager);

                        var materialBitmapContext = new HaloOnlineLib.Serialization.TagSerializationContext(tagsStream, HaloOnlineTagCache, shader.PredictedBitmap[i].Bitmap);
                        var bitmap = HaloOnlineLib.Serialization.TagDeserializer.Deserialize<HaloOnlineLib.TagStructures.Bitmap>(materialBitmapContext);

                        var ddsOutDir = outPath;
                        for (var b = 0; b < bitmap.Images.Count; b++)
                        {
                            using (var outStream = File.Open(outPath, FileMode.Create, FileAccess.Write))
                            {
                                extractor.ExtractDds(bitmap, b, outStream);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        ConsoleLogit("Error extracting texture for sbsp: " + e.Message);
                    }
                }
            }
        }
    }
}