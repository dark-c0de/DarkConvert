using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaloOnlineLib.Serialization;

namespace HaloOnlineLib.TagStructures
{
	[TagStructure(Class = "cfgt", Size = 0x10)]
	public class TagDatabase
	{
		[TagElement]
		public List<TagBlock0> Unknown0 { get; set; }
		[TagElement]
		public int UnknownC { get; set; }

		[TagStructure(Size = 0x10)]
		public class TagBlock0
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
		}
	}
}
