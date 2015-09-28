using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EldoradoLib.Serialization;

namespace EldoradoLib.TagStructures
{
	[TagStructure(Class = "cprl", Size = 0x10)]
	public class ChudWidgetParallaxData
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
