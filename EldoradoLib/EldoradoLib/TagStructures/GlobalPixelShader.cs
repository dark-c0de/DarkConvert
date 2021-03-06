using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EldoradoLib.Serialization;

namespace EldoradoLib.TagStructures
{
	[TagStructure(Class = "glps", Size = 0x1C)]
	public class GlobalPixelShader
	{
		[TagElement]
		public List<TagBlock0> Unknown0 { get; set; }
		[TagElement]
		public int UnknownC { get; set; }
		[TagElement]
		public List<TagBlock3> Unknown10 { get; set; }

		[TagStructure(Size = 0x10)]
		public class TagBlock0
		{
			[TagElement]
			public List<TagBlock1> Unknown0 { get; set; }
			[TagElement]
			public int UnknownC { get; set; }

			[TagStructure(Size = 0x10)]
			public class TagBlock1
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public List<TagBlock2> Unknown4 { get; set; }

				[TagStructure(Size = 0x4)]
				public class TagBlock2
				{
					[TagElement]
					public int Unknown0 { get; set; }
				}
			}
		}

		[TagStructure(Size = 0x50)]
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
			public byte[] Unknown14 { get; set; }
			[TagElement]
			public int Unknown28 { get; set; }
			[TagElement]
			public int Unknown2C { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public List<TagBlock4> Unknown38 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }
			[TagElement]
			public int Unknown48 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }

			[TagStructure(Size = 0x8)]
			public class TagBlock4
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
			}
		}
	}
}
