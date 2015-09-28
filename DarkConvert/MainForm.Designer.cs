namespace DarkConvert
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnElLoadScenarioList = new System.Windows.Forms.Button();
            this.listElScenarios = new System.Windows.Forms.ListBox();
            this.btnEldoradoBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEldoradoMapFolder = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHOBrowse = new System.Windows.Forms.Button();
            this.txtHOMapsFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ConsoleLog = new System.Windows.Forms.RichTextBox();
            this.btnHOLoadScenarioList = new System.Windows.Forms.Button();
            this.listHOScenarios = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnElLoadScenarioList);
            this.groupBox1.Controls.Add(this.listElScenarios);
            this.groupBox1.Controls.Add(this.btnEldoradoBrowse);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEldoradoMapFolder);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eldorado";
            // 
            // btnElLoadScenarioList
            // 
            this.btnElLoadScenarioList.Location = new System.Drawing.Point(344, 177);
            this.btnElLoadScenarioList.Name = "btnElLoadScenarioList";
            this.btnElLoadScenarioList.Size = new System.Drawing.Size(109, 23);
            this.btnElLoadScenarioList.TabIndex = 4;
            this.btnElLoadScenarioList.Text = "Load Scenario List";
            this.btnElLoadScenarioList.UseVisualStyleBackColor = true;
            this.btnElLoadScenarioList.Click += new System.EventHandler(this.btnElLoadScenarioList_Click);
            // 
            // listElScenarios
            // 
            this.listElScenarios.FormattingEnabled = true;
            this.listElScenarios.Location = new System.Drawing.Point(15, 63);
            this.listElScenarios.Name = "listElScenarios";
            this.listElScenarios.Size = new System.Drawing.Size(438, 108);
            this.listElScenarios.TabIndex = 3;
            // 
            // btnEldoradoBrowse
            // 
            this.btnEldoradoBrowse.Location = new System.Drawing.Point(378, 37);
            this.btnEldoradoBrowse.Name = "btnEldoradoBrowse";
            this.btnEldoradoBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnEldoradoBrowse.TabIndex = 2;
            this.btnEldoradoBrowse.Text = "Browse";
            this.btnEldoradoBrowse.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Map Folder";
            // 
            // txtEldoradoMapFolder
            // 
            this.txtEldoradoMapFolder.Location = new System.Drawing.Point(15, 37);
            this.txtEldoradoMapFolder.Name = "txtEldoradoMapFolder";
            this.txtEldoradoMapFolder.Size = new System.Drawing.Size(356, 22);
            this.txtEldoradoMapFolder.TabIndex = 0;
            this.txtEldoradoMapFolder.TextChanged += new System.EventHandler(this.txtEldoradoMapFolder_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHOLoadScenarioList);
            this.groupBox2.Controls.Add(this.btnHOBrowse);
            this.groupBox2.Controls.Add(this.listHOScenarios);
            this.groupBox2.Controls.Add(this.txtHOMapsFolder);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 216);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Halo Online 11.1.530945";
            // 
            // btnHOBrowse
            // 
            this.btnHOBrowse.Location = new System.Drawing.Point(378, 35);
            this.btnHOBrowse.Name = "btnHOBrowse";
            this.btnHOBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnHOBrowse.TabIndex = 5;
            this.btnHOBrowse.Text = "Browse";
            this.btnHOBrowse.UseVisualStyleBackColor = true;
            // 
            // txtHOMapsFolder
            // 
            this.txtHOMapsFolder.Location = new System.Drawing.Point(15, 37);
            this.txtHOMapsFolder.Name = "txtHOMapsFolder";
            this.txtHOMapsFolder.Size = new System.Drawing.Size(356, 22);
            this.txtHOMapsFolder.TabIndex = 3;
            this.txtHOMapsFolder.TextChanged += new System.EventHandler(this.txtHOMapsFolder_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Map Folder";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Convert SBSP";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Suck a fat dick";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ConsoleLog
            // 
            this.ConsoleLog.BackColor = System.Drawing.SystemColors.Control;
            this.ConsoleLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsoleLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsoleLog.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleLog.Location = new System.Drawing.Point(3, 18);
            this.ConsoleLog.Name = "ConsoleLog";
            this.ConsoleLog.Size = new System.Drawing.Size(374, 417);
            this.ConsoleLog.TabIndex = 4;
            this.ConsoleLog.Text = "";
            // 
            // btnHOLoadScenarioList
            // 
            this.btnHOLoadScenarioList.Location = new System.Drawing.Point(344, 179);
            this.btnHOLoadScenarioList.Name = "btnHOLoadScenarioList";
            this.btnHOLoadScenarioList.Size = new System.Drawing.Size(109, 23);
            this.btnHOLoadScenarioList.TabIndex = 6;
            this.btnHOLoadScenarioList.Text = "Load Scenario List";
            this.btnHOLoadScenarioList.UseVisualStyleBackColor = true;
            this.btnHOLoadScenarioList.Click += new System.EventHandler(this.btnHOLoadScenarioList_Click);
            // 
            // listHOScenarios
            // 
            this.listHOScenarios.FormattingEnabled = true;
            this.listHOScenarios.Location = new System.Drawing.Point(15, 65);
            this.listHOScenarios.Name = "listHOScenarios";
            this.listHOScenarios.Size = new System.Drawing.Size(438, 108);
            this.listHOScenarios.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ConsoleLog);
            this.groupBox3.Location = new System.Drawing.Point(482, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 438);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Console Log";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Location = new System.Drawing.Point(868, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(128, 82);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Toolbox";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(868, 100);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(128, 69);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Credits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "DARKC0DE\r\nShockfire\r\nihatecompvir";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 459);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.Text = "DarkConverter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEldoradoBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEldoradoMapFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnHOBrowse;
        private System.Windows.Forms.TextBox txtHOMapsFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnElLoadScenarioList;
        private System.Windows.Forms.ListBox listElScenarios;
        private System.Windows.Forms.RichTextBox ConsoleLog;
        private System.Windows.Forms.Button btnHOLoadScenarioList;
        private System.Windows.Forms.ListBox listHOScenarios;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
    }
}

