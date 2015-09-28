using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaloOnlineLib.Serialization;
using HaloOnlineLib.Resources;

namespace HaloOnlineLib.TagStructures
{
	[TagStructure(Class = "sbsp", Size = 0x3B8)]
	public class ScenarioStructureBsp
	{
		[TagElement]
		public int Unknown0 { get; set; }
		[TagElement]
		public int Unknown4 { get; set; }
		[TagElement]
		public int Unknown8 { get; set; }
		[TagElement]
		public int UnknownC { get; set; }
		[TagElement]
		public int Unknown10 { get; set; }
		[TagElement]
		public int Unknown14 { get; set; }
		[TagElement]
		public int Unknown18 { get; set; }
		[TagElement]
		public int Unknown1C { get; set; }
		[TagElement]
		public int Unknown20 { get; set; }
		[TagElement]
		public int Unknown24 { get; set; }
		[TagElement]
		public List<TagBlock0> Unknown28 { get; set; }
		[TagElement]
		public List<TagBlock1> Unknown34 { get; set; }
		[TagElement]
		public int Unknown40 { get; set; }
		[TagElement]
		public int Unknown44 { get; set; }
		[TagElement]
		public int Unknown48 { get; set; }
		[TagElement]
		public int Unknown4C { get; set; }
		[TagElement]
		public int Unknown50 { get; set; }
		[TagElement]
		public int Unknown54 { get; set; }
		[TagElement]
		public int Unknown58 { get; set; }
		[TagElement]
		public int Unknown5C { get; set; }
		[TagElement]
		public int Unknown60 { get; set; }
		[TagElement]
		public int Unknown64 { get; set; }
		[TagElement]
		public int Unknown68 { get; set; }
		[TagElement]
		public int Unknown6C { get; set; }
		[TagElement]
		public int Unknown70 { get; set; }
		[TagElement]
		public int Unknown74 { get; set; }
		[TagElement]
		public int Unknown78 { get; set; }
		[TagElement]
		public List<TagBlock2> Unknown7C { get; set; }
		[TagElement]
		public List<TagBlock4> Unknown88 { get; set; }
		[TagElement]
		public List<TagBlock5> Unknown94 { get; set; }
		[TagElement]
		public List<TagBlock6> UnknownA0 { get; set; }
		[TagElement]
		public int UnknownAC { get; set; }
		[TagElement]
		public int UnknownB0 { get; set; }
		[TagElement]
		public int UnknownB4 { get; set; }
		[TagElement]
		public int UnknownB8 { get; set; }
		[TagElement]
		public int UnknownBC { get; set; }
		[TagElement]
		public int UnknownC0 { get; set; }
		[TagElement]
		public List<TagBlock7> UnknownC4 { get; set; }
		[TagElement]
		public List<TagBlock8> UnknownD0 { get; set; }
		[TagElement]
		public List<TagBlock14> UnknownDC { get; set; }
		[TagElement]
		public List<TagBlock16> UnknownE8 { get; set; }
		[TagElement]
		public int UnknownF4 { get; set; }
		[TagElement]
		public int UnknownF8 { get; set; }
		[TagElement]
		public int UnknownFC { get; set; }
		[TagElement]
		public int Unknown100 { get; set; }
		[TagElement]
		public int Unknown104 { get; set; }
		[TagElement]
		public int Unknown108 { get; set; }
		[TagElement]
		public int Unknown10C { get; set; }
		[TagElement]
		public int Unknown110 { get; set; }
		[TagElement]
		public int Unknown114 { get; set; }
		[TagElement]
		public int Unknown118 { get; set; }
		[TagElement]
		public int Unknown11C { get; set; }
		[TagElement]
		public int Unknown120 { get; set; }
		[TagElement]
		public List<TagBlock17> Unknown124 { get; set; }
		[TagElement]
		public int Unknown130 { get; set; }
		[TagElement]
		public int Unknown134 { get; set; }
		[TagElement]
		public int Unknown138 { get; set; }
		[TagElement]
		public int Unknown13C { get; set; }
		[TagElement]
		public int Unknown140 { get; set; }
		[TagElement]
		public int Unknown144 { get; set; }
		[TagElement]
		public int Unknown148 { get; set; }
		[TagElement]
		public int Unknown14C { get; set; }
		[TagElement]
		public int Unknown150 { get; set; }
		[TagElement]
		public int Unknown154 { get; set; }
		[TagElement]
		public int Unknown158 { get; set; }
		[TagElement]
		public List<TagBlock18> Unknown15C { get; set; }
		[TagElement]
		public int Unknown168 { get; set; }
		[TagElement]
		public int Unknown16C { get; set; }
		[TagElement]
		public int Unknown170 { get; set; }
		[TagElement]
		public List<TagBlock19> Unknown174 { get; set; }
		[TagElement]
		public List<TagBlock20> Unknown180 { get; set; }
		[TagElement]
		public List<TagBlock21> Unknown18C { get; set; }
		[TagElement]
		public List<TagBlock22> Unknown198 { get; set; }
		[TagElement]
		public int Unknown1A4 { get; set; }
		[TagElement]
		public int Unknown1A8 { get; set; }
		[TagElement]
		public int Unknown1AC { get; set; }
		[TagElement]
		public int Unknown1B0 { get; set; }
		[TagElement]
		public int Unknown1B4 { get; set; }
		[TagElement]
		public int Unknown1B8 { get; set; }
		[TagElement]
		public int Unknown1BC { get; set; }
		[TagElement]
		public int Unknown1C0 { get; set; }
		[TagElement]
		public int Unknown1C4 { get; set; }
		[TagElement]
		public int Unknown1C8 { get; set; }
		[TagElement]
		public List<TagBlock23> Unknown1CC { get; set; }
		[TagElement]
		public List<TagBlock25> Unknown1D8 { get; set; }
		[TagElement]
		public int Unknown1E4 { get; set; }
		[TagElement]
		public int Unknown1E8 { get; set; }
		[TagElement]
		public int Unknown1EC { get; set; }
		[TagElement]
		public int Unknown1F0 { get; set; }
		[TagElement]
		public int Unknown1F4 { get; set; }
		[TagElement]
		public int Unknown1F8 { get; set; }
		[TagElement]
		public int Unknown1FC { get; set; }
		[TagElement]
		public int Unknown200 { get; set; }
		[TagElement]
		public int Unknown204 { get; set; }
		[TagElement]
		public int Unknown208 { get; set; }
		[TagElement]
		public int Unknown20C { get; set; }
		[TagElement]
		public int Unknown210 { get; set; }
		[TagElement]
		public int Unknown214 { get; set; }
		[TagElement]
		public int Unknown218 { get; set; }
		[TagElement]
		public int Unknown21C { get; set; }
		[TagElement]
		public int Unknown220 { get; set; }
		[TagElement]
		public int Unknown224 { get; set; }
		[TagElement]
		public int Unknown228 { get; set; }
		[TagElement]
		public int Unknown22C { get; set; }
		[TagElement]
		public int Unknown230 { get; set; }
		[TagElement]
		public int Unknown234 { get; set; }
		[TagElement]
		public int Unknown238 { get; set; }
		[TagElement]
		public int Unknown23C { get; set; }
		[TagElement]
		public int Unknown240 { get; set; }
		[TagElement]
		public int Unknown244 { get; set; }
		[TagElement]
		public int Unknown248 { get; set; }
		[TagElement]
		public int Unknown24C { get; set; }
		[TagElement]
		public int Unknown250 { get; set; }
		[TagElement]
		public int Unknown254 { get; set; }
		[TagElement]
		public int Unknown258 { get; set; }
		[TagElement]
		public int Unknown25C { get; set; }
		[TagElement]
		public ResourceReference Unknown260 { get; set; }
		[TagElement]
		public int Unknown264 { get; set; }
		[TagElement]
		public List<TagBlock26> Unknown268 { get; set; }
		[TagElement]
		public List<TagBlock29> Unknown274 { get; set; }
		[TagElement]
		public List<TagBlock32> Unknown280 { get; set; }
		[TagElement]
		public List<TagBlock35> Unknown28C { get; set; }
		[TagElement]
		public int Unknown298 { get; set; }
		[TagElement]
		public int Unknown29C { get; set; }
		[TagElement]
		public int Unknown2A0 { get; set; }
		[TagElement]
		public List<TagBlock36> Unknown2A4 { get; set; }
		[TagElement]
		public int Unknown2B0 { get; set; }
		[TagElement]
		public int Unknown2B4 { get; set; }
		[TagElement]
		public int Unknown2B8 { get; set; }
		[TagElement]
		public int Unknown2BC { get; set; }
		[TagElement]
		public int Unknown2C0 { get; set; }
		[TagElement]
		public int Unknown2C4 { get; set; }
		[TagElement]
		public int Unknown2C8 { get; set; }
		[TagElement]
		public int Unknown2CC { get; set; }
		[TagElement]
		public int Unknown2D0 { get; set; }
		[TagElement]
		public int Unknown2D4 { get; set; }
		[TagElement]
		public int Unknown2D8 { get; set; }
		[TagElement]
		public int Unknown2DC { get; set; }
		[TagElement]
		public int Unknown2E0 { get; set; }
		[TagElement]
		public int Unknown2E4 { get; set; }
		[TagElement]
		public int Unknown2E8 { get; set; }
		[TagElement]
		public int Unknown2EC { get; set; }
		[TagElement]
		public int Unknown2F0 { get; set; }
		[TagElement]
		public int Unknown2F4 { get; set; }
		[TagElement]
		public int Unknown2F8 { get; set; }
		[TagElement]
		public int Unknown2FC { get; set; }
		[TagElement]
		public List<TagBlock38> Unknown300 { get; set; }
		[TagElement]
		public List<TagBlock44> Unknown30C { get; set; }
		[TagElement]
		public List<TagBlock45> Unknown318 { get; set; }
		[TagElement]
		public int Unknown324 { get; set; }
		[TagElement]
		public int Unknown328 { get; set; }
		[TagElement]
		public int Unknown32C { get; set; }
		[TagElement]
		public int Unknown330 { get; set; }
		[TagElement]
		public int Unknown334 { get; set; }
		[TagElement]
		public int Unknown338 { get; set; }
		[TagElement]
		public int Unknown33C { get; set; }
		[TagElement]
		public int Unknown340 { get; set; }
		[TagElement]
		public int Unknown344 { get; set; }
		[TagElement]
		public int Unknown348 { get; set; }
		[TagElement]
		public int Unknown34C { get; set; }
		[TagElement]
		public int Unknown350 { get; set; }
		[TagElement]
		public int Unknown354 { get; set; }
		[TagElement]
		public int Unknown358 { get; set; }
		[TagElement]
		public int Unknown35C { get; set; }
		[TagElement]
		public int Unknown360 { get; set; }
		[TagElement]
		public int Unknown364 { get; set; }
		[TagElement]
		public int Unknown368 { get; set; }
		[TagElement]
		public int Unknown36C { get; set; }
		[TagElement]
		public int Unknown370 { get; set; }
		[TagElement]
		public int Unknown374 { get; set; }
		[TagElement]
		public ResourceReference Unknown378 { get; set; }
		[TagElement]
		public int Unknown37C { get; set; }
		[TagElement]
		public List<TagBlock46> Unknown380 { get; set; }
		[TagElement]
		public int Unknown38C { get; set; }
		[TagElement]
		public int Unknown390 { get; set; }
		[TagElement]
		public int Unknown394 { get; set; }
		[TagElement]
		public ResourceReference Unknown398 { get; set; }
		[TagElement]
		public int Unknown39C { get; set; }
		[TagElement]
		public ResourceReference Unknown3A0 { get; set; }
		[TagElement]
		public int Unknown3A4 { get; set; }
		[TagElement]
		public int Unknown3A8 { get; set; }
		[TagElement]
		public int Unknown3AC { get; set; }
		[TagElement]
		public int Unknown3B0 { get; set; }
		[TagElement]
		public int Unknown3B4 { get; set; }

		[TagStructure(Size = 0x18)]
		public class TagBlock0
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
		}

		[TagStructure(Size = 0x1)]
		public class TagBlock1
		{
			[TagElement]
			public byte Unknown0 { get; set; }
		}

		[TagStructure(Size = 0x28)]
		public class TagBlock2
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public List<TagBlock3> Unknown1C { get; set; }

			[TagStructure(Size = 0xC)]
			public class TagBlock3
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
			}
		}

		[TagStructure(Size = 0x78)]
		public class TagBlock4
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }
			[TagElement]
			public int Unknown48 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }
			[TagElement]
			public int Unknown50 { get; set; }
			[TagElement]
			public int Unknown54 { get; set; }
			[TagElement]
			public int Unknown58 { get; set; }
			[TagElement]
			public int Unknown5C { get; set; }
			[TagElement]
			public int Unknown60 { get; set; }
			[TagElement]
			public int Unknown64 { get; set; }
			[TagElement]
			public int Unknown68 { get; set; }
			[TagElement]
			public int Unknown6C { get; set; }
			[TagElement]
			public int Unknown70 { get; set; }
			[TagElement]
			public int Unknown74 { get; set; }
		}

		[TagStructure(Size = 0x8)]
		public class TagBlock5
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
		}

		[TagStructure(Size = 0x30)]
		public class TagBlock6
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public HaloTag Unknown4 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
		}

		[TagStructure(Size = 0x34)]
		public class TagBlock7
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
		}

		[TagStructure(Size = 0xE0)]
		public class TagBlock8
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public List<TagBlock9> Unknown40 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }
			[TagElement]
			public int Unknown50 { get; set; }
			[TagElement]
			public int Unknown54 { get; set; }
			[TagElement]
			public int Unknown58 { get; set; }
			[TagElement]
			public int Unknown5C { get; set; }
			[TagElement]
			public int Unknown60 { get; set; }
			[TagElement]
			public HaloTag Unknown64 { get; set; }
			[TagElement]
			public int Unknown74 { get; set; }
			[TagElement]
			public int Unknown78 { get; set; }
			[TagElement]
			public int Unknown7C { get; set; }
			[TagElement]
			public int Unknown80 { get; set; }
			[TagElement]
			public int Unknown84 { get; set; }
			[TagElement]
			public int Unknown88 { get; set; }
			[TagElement]
			public int Unknown8C { get; set; }
			[TagElement]
			public int Unknown90 { get; set; }
			[TagElement]
			public List<TagBlock10> Unknown94 { get; set; }
			[TagElement]
			public int UnknownA0 { get; set; }
			[TagElement]
			public int UnknownA4 { get; set; }
			[TagElement]
			public int UnknownA8 { get; set; }
			[TagElement]
			public int UnknownAC { get; set; }
			[TagElement]
			public List<TagBlock12> UnknownB0 { get; set; }
			[TagElement]
			public int UnknownBC { get; set; }
			[TagElement]
			public int UnknownC0 { get; set; }
			[TagElement]
			public int UnknownC4 { get; set; }
			[TagElement]
			public int UnknownC8 { get; set; }
			[TagElement]
			public int UnknownCC { get; set; }
			[TagElement]
			public int UnknownD0 { get; set; }
			[TagElement]
			public List<TagBlock13> UnknownD4 { get; set; }

			[TagStructure(Size = 0x2)]
			public class TagBlock9
			{
				[TagElement]
				public short Unknown0 { get; set; }
			}

			[TagStructure(Size = 0x40)]
			public class TagBlock10
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
				[TagElement]
				public int Unknown10 { get; set; }
				[TagElement]
				public int Unknown14 { get; set; }
				[TagElement]
				public int Unknown18 { get; set; }
				[TagElement]
				public int Unknown1C { get; set; }
				[TagElement]
				public int Unknown20 { get; set; }
				[TagElement]
				public int Unknown24 { get; set; }
				[TagElement]
				public int Unknown28 { get; set; }
				[TagElement]
				public int Unknown2C { get; set; }
				[TagElement]
				public List<TagBlock11> Unknown30 { get; set; }
				[TagElement]
				public int Unknown3C { get; set; }

				[TagStructure(Size = 0x1)]
				public class TagBlock11
				{
					[TagElement]
					public byte Unknown0 { get; set; }
				}
			}

			[TagStructure(Size = 0x34)]
			public class TagBlock12
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
				[TagElement]
				public int Unknown10 { get; set; }
				[TagElement]
				public int Unknown14 { get; set; }
				[TagElement]
				public int Unknown18 { get; set; }
				[TagElement]
				public int Unknown1C { get; set; }
				[TagElement]
				public int Unknown20 { get; set; }
				[TagElement]
				public int Unknown24 { get; set; }
				[TagElement]
				public int Unknown28 { get; set; }
				[TagElement]
				public int Unknown2C { get; set; }
				[TagElement]
				public int Unknown30 { get; set; }
			}

			[TagStructure(Size = 0x10)]
			public class TagBlock13
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
			}
		}

		[TagStructure(Size = 0x24)]
		public class TagBlock14
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
			[TagElement]
			public List<TagBlock15> Unknown10 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }

			[TagStructure(Size = 0xC)]
			public class TagBlock15
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
			}
		}

		[TagStructure(Size = 0x2)]
		public class TagBlock16
		{
			[TagElement]
			public short Unknown0 { get; set; }
		}

		[TagStructure(Size = 0x58)]
		public class TagBlock17
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public HaloTag Unknown4 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public HaloTag Unknown20 { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }
			[TagElement]
			public int Unknown48 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }
			[TagElement]
			public int Unknown50 { get; set; }
			[TagElement]
			public int Unknown54 { get; set; }
		}

		[TagStructure(Size = 0x3C)]
		public class TagBlock18
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
		}

		[TagStructure(Size = 0x2)]
		public class TagBlock19
		{
			[TagElement]
			public short Unknown0 { get; set; }
		}

		[TagStructure(Size = 0x24)]
		public class TagBlock20
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
		}

		[TagStructure(Size = 0x24)]
		public class TagBlock21
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
		}

		[TagStructure(Size = 0x6E)]
		public class TagBlock22
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }
			[TagElement]
			public int Unknown48 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }
			[TagElement]
			public int Unknown50 { get; set; }
			[TagElement]
			public int Unknown54 { get; set; }
			[TagElement]
			public int Unknown58 { get; set; }
			[TagElement]
			public int Unknown5C { get; set; }
			[TagElement]
			public int Unknown60 { get; set; }
			[TagElement]
			public int Unknown64 { get; set; }
			[TagElement]
			public int Unknown68 { get; set; }
			[TagElement]
			public short Unknown6C { get; set; }
		}

		[TagStructure(Size = 0x74)]
		public class TagBlock23
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }
			[TagElement]
			public int Unknown48 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }
			[TagElement]
			public int Unknown50 { get; set; }
			[TagElement]
			public int Unknown54 { get; set; }
			[TagElement]
			public int Unknown58 { get; set; }
			[TagElement]
			public int Unknown5C { get; set; }
			[TagElement]
			public List<TagBlock24> Unknown60 { get; set; }
			[TagElement]
			public int Unknown6C { get; set; }
			[TagElement]
			public int Unknown70 { get; set; }

			[TagStructure(Size = 0x80)]
			public class TagBlock24
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
				[TagElement]
				public int Unknown10 { get; set; }
				[TagElement]
				public int Unknown14 { get; set; }
				[TagElement]
				public int Unknown18 { get; set; }
				[TagElement]
				public int Unknown1C { get; set; }
				[TagElement]
				public int Unknown20 { get; set; }
				[TagElement]
				public int Unknown24 { get; set; }
				[TagElement]
				public int Unknown28 { get; set; }
				[TagElement]
				public int Unknown2C { get; set; }
				[TagElement]
				public int Unknown30 { get; set; }
				[TagElement]
				public int Unknown34 { get; set; }
				[TagElement]
				public int Unknown38 { get; set; }
				[TagElement]
				public int Unknown3C { get; set; }
				[TagElement]
				public int Unknown40 { get; set; }
				[TagElement]
				public int Unknown44 { get; set; }
				[TagElement]
				public int Unknown48 { get; set; }
				[TagElement]
				public int Unknown4C { get; set; }
				[TagElement]
				public int Unknown50 { get; set; }
				[TagElement]
				public int Unknown54 { get; set; }
				[TagElement]
				public int Unknown58 { get; set; }
				[TagElement]
				public int Unknown5C { get; set; }
				[TagElement]
				public int Unknown60 { get; set; }
				[TagElement]
				public int Unknown64 { get; set; }
				[TagElement]
				public int Unknown68 { get; set; }
				[TagElement]
				public int Unknown6C { get; set; }
				[TagElement]
				public int Unknown70 { get; set; }
				[TagElement]
				public int Unknown74 { get; set; }
				[TagElement]
				public int Unknown78 { get; set; }
				[TagElement]
				public int Unknown7C { get; set; }
			}
		}

		[TagStructure(Size = 0x10)]
		public class TagBlock25
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
		}

		[TagStructure(Size = 0x1C)]
		public class TagBlock26
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public List<TagBlock27> Unknown4 { get; set; }
			[TagElement]
			public List<TagBlock28> Unknown10 { get; set; }

			[TagStructure(Size = 0x2)]
			public class TagBlock27
			{
				[TagElement]
				public short Unknown0 { get; set; }
			}

			[TagStructure(Size = 0x2)]
			public class TagBlock28
			{
				[TagElement]
				public short Unknown0 { get; set; }
			}
		}

		[TagStructure(Size = 0x1C)]
		public class TagBlock29
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public List<TagBlock30> Unknown4 { get; set; }
			[TagElement]
			public List<TagBlock31> Unknown10 { get; set; }

			[TagStructure(Size = 0x2)]
			public class TagBlock30
			{
				[TagElement]
				public short Unknown0 { get; set; }
			}

			[TagStructure(Size = 0x2)]
			public class TagBlock31
			{
				[TagElement]
				public short Unknown0 { get; set; }
			}
		}

		[TagStructure(Size = 0x1C)]
		public class TagBlock32
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public List<TagBlock33> Unknown4 { get; set; }
			[TagElement]
			public List<TagBlock34> Unknown10 { get; set; }

			[TagStructure(Size = 0x2)]
			public class TagBlock33
			{
				[TagElement]
				public short Unknown0 { get; set; }
			}

			[TagStructure(Size = 0x2)]
			public class TagBlock34
			{
				[TagElement]
				public short Unknown0 { get; set; }
			}
		}

		[TagStructure(Size = 0x14)]
		public class TagBlock35
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
		}

		[TagStructure(Size = 0x40)]
		public class TagBlock36
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public List<TagBlock37> Unknown30 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }

			[TagStructure(Size = 0x1)]
			public class TagBlock37
			{
				[TagElement]
				public byte Unknown0 { get; set; }
			}
		}

		[TagStructure(Size = 0x4C)]
		public class TagBlock38
		{
			[TagElement]
			public List<TagBlock39> Unknown0 { get; set; }
			[TagElement]
			public List<TagBlock40> UnknownC { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public List<TagBlock41> Unknown34 { get; set; }
			[TagElement]
			public List<TagBlock43> Unknown40 { get; set; }

			[TagStructure(Size = 0x10)]
			public class TagBlock39
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
			}

			[TagStructure(Size = 0x8)]
			public class TagBlock40
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
			}

			[TagStructure(Size = 0x10)]
			public class TagBlock41
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public List<TagBlock42> Unknown4 { get; set; }

				[TagStructure(Size = 0x2)]
				public class TagBlock42
				{
					[TagElement]
					public short Unknown0 { get; set; }
				}
			}

			[TagStructure(Size = 0x4)]
			public class TagBlock43
			{
				[TagElement]
				public int Unknown0 { get; set; }
			}
		}

		[TagStructure(Size = 0x2C)]
		public class TagBlock44
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
		}

		[TagStructure(Size = 0x30)]
		public class TagBlock45
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public int Unknown4 { get; set; }
			[TagElement]
			public int Unknown8 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
			[TagElement]
			public int Unknown20 { get; set; }
			[TagElement]
			public int Unknown24 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
		}

		[TagStructure(Size = 0x20)]
		public class TagBlock46
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public HaloTag Unknown4 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
			[TagElement]
			public int Unknown1C { get; set; }
		}
	}
}
