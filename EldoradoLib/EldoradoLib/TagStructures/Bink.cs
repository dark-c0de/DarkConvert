using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EldoradoLib.Resources;
using EldoradoLib.Serialization;

namespace EldoradoLib.TagStructures
{
	[TagStructure(Class = "bink", Size = 0x18)]
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
		[TagElement]
		public int Unknown14 { get; set; }
	}
}
