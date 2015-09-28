using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaloOnlineLib.Serialization;
using HaloOnlineLib.Resources;

namespace HaloOnlineLib.TagStructures
{
	[TagStructure(Class = "bink", Size = 0x14)]
	public class Bink
	{
		[TagElement]
		public int Unknown0 { get; set; }
		[TagElement]
		public ResourceReference Unknown4 { get; set; }
		[TagElement]
		public int Unknown8 { get; set; }
		[TagElement]
		public int UnknownC { get; set; }
		[TagElement]
		public int Unknown10 { get; set; }
	}
}
