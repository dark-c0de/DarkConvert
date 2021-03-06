﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloOnlineLib.Serialization
{
	/// <summary>
	/// Interface for a block of data being serialized.
	/// </summary>
	public interface IDataBlock
	{
		/// <summary>
		/// Gets the stream open on the data block.
		/// </summary>
		MemoryStream Stream { get; }

		/// <summary>
		/// Gets the writer open on the data block's stream.
		/// </summary>
		BinaryWriter Writer { get; }

		/// <summary>
		/// Writes a pointer to an object at the current position in the block.
		/// </summary>
		/// <param name="targetOffset">The target offset.</param>
		/// <param name="type">The type of object that the pointer will point to.</param>
		void WritePointer(uint targetOffset, Type type);

		/// <summary>
		/// Called before an object is serialized into the block.
		/// </summary>
		/// <param name="info">Information about the tag element.</param>
		/// <param name="obj">The object intended to be serialized.</param>
		/// <returns>The object which should actually be serialized.</returns>
		object PreSerialize(TagElementAttribute info, object obj);

		/// <summary>
		/// Finalizes the block, writing it out to a stream.
		/// </summary>
		/// <param name="outStream">The output stream.</param>
		/// <returns>The offset of the block within the output stream.</returns>
		uint Finalize(Stream outStream);
	}
}
