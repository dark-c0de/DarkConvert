using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaloOnlineLib.Serialization;

namespace HaloOnlineLib.TagStructures
{
	[TagStructure(Class = "dctr", Size = 0x80)]
	public class DecoratorSet
	{
		[TagElement]
		public HaloTag Unknown0 { get; set; }
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
	}
}
