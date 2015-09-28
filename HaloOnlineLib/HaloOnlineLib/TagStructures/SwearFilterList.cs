using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaloOnlineLib.Serialization;

namespace HaloOnlineLib.TagStructures
{
	[TagStructure(Class = "hf2p", Size = 0x10)]
	public class SwearFilterList
	{
		[TagElement]
		public List<TagBlock0> Unknown0 { get; set; }
		[TagElement]
		public int UnknownC { get; set; }

		[TagStructure(Size = 0xC)]
		public class TagBlock0
		{
			[TagElement]
			public List<TagBlock1> Unknown0 { get; set; }

			[TagStructure(Size = 0xC)]
			public class TagBlock1
			{
				[TagElement]
				public List<TagBlock2> Unknown0 { get; set; }

				[TagStructure(Size = 0x34)]
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
					public int Unknown1C { get; set; }
					[TagElement]
					public HaloTag Unknown20 { get; set; }
					[TagElement]
					public int Unknown30 { get; set; }
				}
			}
		}
	}
}
