using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldoradoLib.Resources.Geometry
{
	/// <summary>
	/// Model primitive types.
	/// </summary>
	public enum PrimitiveType : int
	{
		PointList,
		LineList,
		LineStrip,
		TriangleList,
		TriangleFan,
		TriangleStrip,
	}
}
