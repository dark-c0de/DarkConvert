using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaloOnlineLib.Serialization;

namespace HaloOnlineLib.TagStructures
{
	[TagStructure(Class = "swel", Size = 0x1C)]
	public class SwearFilter
	{
		[TagElement]
		public byte[] Unknown0 { get; set; }
		[TagElement]
		public int Unknown14 { get; set; }
		[TagElement]
		public int Unknown18 { get; set; }
	}
}
