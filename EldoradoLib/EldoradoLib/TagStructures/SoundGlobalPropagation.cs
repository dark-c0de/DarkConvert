using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EldoradoLib.Serialization;

namespace EldoradoLib.TagStructures
{
	[TagStructure(Class = "sgp!", Size = 0x50)]
	public class SoundGlobalPropagation
	{
		[TagElement]
		public HaloTag Unknown0 { get; set; }
		[TagElement]
		public HaloTag Unknown10 { get; set; }
		[TagElement]
		public int Unknown20 { get; set; }
		[TagElement]
		public int Unknown24 { get; set; }
		[TagElement]
		public HaloTag Unknown28 { get; set; }
		[TagElement]
		public HaloTag Unknown38 { get; set; }
		[TagElement]
		public int Unknown48 { get; set; }
		[TagElement]
		public int Unknown4C { get; set; }
	}
}
