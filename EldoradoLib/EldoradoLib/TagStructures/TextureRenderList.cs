using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EldoradoLib.Serialization;

namespace EldoradoLib.TagStructures
{
	[TagStructure(Class = "trdf", Size = 0x44)]
	public class TextureRenderList
	{
		[TagElement]
		public List<TagBlock0> Unknown0 { get; set; }
		[TagElement]
		public List<TagBlock1> UnknownC { get; set; }
		[TagElement]
		public List<TagBlock3> Unknown18 { get; set; }
		[TagElement]
		public List<TagBlock4> Unknown24 { get; set; }
		[TagElement]
		public List<TagBlock5> Unknown30 { get; set; }
		[TagElement]
		public int Unknown3C { get; set; }
		[TagElement]
		public int Unknown40 { get; set; }

		[TagStructure(Size = 0x110)]
		public class TagBlock0
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
			public int Unknown94 { get; set; }
			[TagElement]
			public int Unknown98 { get; set; }
			[TagElement]
			public int Unknown9C { get; set; }
			[TagElement]
			public int UnknownA0 { get; set; }
			[TagElement]
			public int UnknownA4 { get; set; }
			[TagElement]
			public int UnknownA8 { get; set; }
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
			public int UnknownC4 { get; set; }
			[TagElement]
			public int UnknownC8 { get; set; }
			[TagElement]
			public int UnknownCC { get; set; }
			[TagElement]
			public int UnknownD0 { get; set; }
			[TagElement]
			public int UnknownD4 { get; set; }
			[TagElement]
			public int UnknownD8 { get; set; }
			[TagElement]
			public int UnknownDC { get; set; }
			[TagElement]
			public int UnknownE0 { get; set; }
			[TagElement]
			public int UnknownE4 { get; set; }
			[TagElement]
			public int UnknownE8 { get; set; }
			[TagElement]
			public int UnknownEC { get; set; }
			[TagElement]
			public int UnknownF0 { get; set; }
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
		}

		[TagStructure(Size = 0x1C)]
		public class TagBlock1
		{
			[TagElement]
			public List<TagBlock2> Unknown0 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }
			[TagElement]
			public int Unknown10 { get; set; }
			[TagElement]
			public int Unknown14 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }

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
				public HaloTag Unknown18 { get; set; }
			}
		}

		[TagStructure(Size = 0x30)]
		public class TagBlock3
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
			public HaloTag Unknown20 { get; set; }
		}

		// NOTE: In 8.1.373869, this size is 0x5C
		[TagStructure(Size = 0x4C)]
		public class TagBlock4
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
		}

		// NOTE: In 8.1.373869, this size is 0x84
		[TagStructure(Size = 0x64)]
		public class TagBlock5
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
			[TagElement]
			public int Unknown58 { get; set; }
			[TagElement]
			public int Unknown5C { get; set; }
			[TagElement]
			public int Unknown60 { get; set; }
		}
	}
}