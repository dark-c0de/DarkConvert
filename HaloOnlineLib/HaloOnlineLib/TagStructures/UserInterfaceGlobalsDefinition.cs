using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaloOnlineLib.Serialization;

namespace HaloOnlineLib.TagStructures
{
	[TagStructure(Class = "wgtz", Size = 0x60)]
	public class UserInterfaceGlobalsDefinition
	{
		[TagElement]
		public HaloTag Unknown0 { get; set; }
		[TagElement]
		public HaloTag Unknown10 { get; set; }
		[TagElement]
		public HaloTag Unknown20 { get; set; }
		[TagElement]
		public List<TagBlock0> Unknown30 { get; set; }
		[TagElement]
		public HaloTag Unknown3C { get; set; }
		[TagElement]
		public HaloTag Unknown4C { get; set; }
		[TagElement]
		public int Unknown5C { get; set; }

		[TagStructure(Size = 0x10)]
		public class TagBlock0
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
		}
	}
}
