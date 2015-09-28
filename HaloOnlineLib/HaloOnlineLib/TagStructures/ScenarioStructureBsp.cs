using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaloOnlineLib.Serialization;
using HaloOnlineLib.Resources;

namespace HaloOnlineLib.TagStructures
{
    //TODO: Why can't we have the full SBSP structure here? The tag serializer doesn't like it...
	[TagStructure(Class = "sbsp", Size = 0x3B8)]
	public class ScenarioStructureBsp
	{
		[TagElement]
        public int BSPChecksum { get; set; }
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
		public int Unknown20 { get; set; }
		[TagElement]
		public int Unknown24 { get; set; }
		[TagElement]
        public List<CollisionMaterial> CollisionMaterials { get; set; }
		[TagElement]
		public List<TagBlock1> Unknown34 { get; set; }
        [TagElement]
        public float WorldBoundsXMin { get; set; }
        [TagElement]
        public float WorldBoundsXMax { get; set; }
        [TagElement]
        public float WorldBoundsYMin { get; set; }
        [TagElement]
        public float WorldBoundsYMax { get; set; }
        [TagElement]
        public float WorldBoundsZMin { get; set; }
        [TagElement]
        public float WorldBoundsZMax { get; set; }
		
        [TagStructure(Size = 0x18)]
        public class CollisionMaterial
        {
            [TagElement]
            public HaloTag Shader { get; set; }
            [TagElement]
            public short GlobalMatIndex { get; set; }
            [TagElement]
            public short Seamindex { get; set; }
        }

		[TagStructure(Size = 0x1)]
		public class TagBlock1
		{
			[TagElement]
			public sbyte Unknown0 { get; set; }
		}

	}
}
