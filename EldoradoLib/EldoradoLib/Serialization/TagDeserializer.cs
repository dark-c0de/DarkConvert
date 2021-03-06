﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using EldoradoLib.Common;
using EldoradoLib.Resources;

namespace EldoradoLib.Serialization
{
	/// <summary>
	/// Deserializes tag data into objects by using reflection.
	/// </summary>
	public static class TagDeserializer
	{
		/// <summary>
		/// Deserializes tag data into an object.
		/// </summary>
		/// <typeparam name="T">The type of object to deserialize the tag data as.</typeparam>
		/// <param name="context">The serialization context to use.</param>
		/// <returns>The object that was read.</returns>
		public static T Deserialize<T>(ISerializationContext context)
		{
			// TODO: Add support for tag inheritance
			var reader = context.BeginDeserialize();
			var result = (T)DeserializeStruct(reader, context, typeof(T));
			context.EndDeserialize(result);
			return result;
		}

		/// <summary>
		/// Deserializes a structure.
		/// </summary>
		/// <param name="reader">The reader.</param>
		/// <param name="context">The serialization context to use.</param>
		/// <param name="structType">The type of the structure to deserialize.</param>
		/// <returns>The deserialized structure.</returns>
		/// <exception cref="System.InvalidOperationException">Target type must have TagStructureAttribute</exception>
		private static object DeserializeStruct(BinaryReader reader, ISerializationContext context, Type structType)
		{
			// Get the TagStructureAttribute associated with the target type
			var structAttrib = structType.GetCustomAttributes(typeof(TagStructureAttribute), false).FirstOrDefault() as TagStructureAttribute;
		    if (structAttrib == null)
		        throw new InvalidOperationException("Target type must have TagStructureAttribute");

			// Deserialize each property in the structure
			var baseOffset = reader.BaseStream.Position;
			var properties = structType.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			var instance = Activator.CreateInstance(structType);
			foreach (var property in properties)
				DeserializeProperty(reader, context, instance, structAttrib, property, baseOffset);
			if (structAttrib.Size > 0)
				reader.BaseStream.Position = baseOffset + structAttrib.Size;

			return instance;
		}

		/// <summary>
		/// Deserializes a property of a structure.
		/// </summary>
		/// <param name="reader">The reader.</param>
		/// <param name="context">The serialization context to use.</param>
		/// <param name="instance">The instance to store the property to.</param>
		/// <param name="structInfo">The structure information.</param>
		/// <param name="property">The property.</param>
		/// <param name="baseOffset">The offset of the start of the structure.</param>
		/// <exception cref="System.InvalidOperationException">Offset for property is outside of its structure</exception>
		private static void DeserializeProperty(BinaryReader reader, ISerializationContext context, object instance, TagStructureAttribute structInfo, PropertyInfo property, long baseOffset)
		{
			// Get the property's TagValueAttribute
			var valueInfo = property.GetCustomAttributes(typeof(TagElementAttribute), false).FirstOrDefault() as TagElementAttribute;
			if (valueInfo == null)
				return; // Ignore the property
			if (valueInfo.Offset >= structInfo.Size)
				throw new InvalidOperationException("Offset for property \"" + property.Name + "\" is outside of its structure");

			// Seek to the value if it has an offset specified and then read it
			if (valueInfo.Offset >= 0)
				reader.BaseStream.Position = baseOffset + valueInfo.Offset;
			var startOffset = reader.BaseStream.Position;
			property.SetValue(instance, DeserializeValue(reader, context, valueInfo, property.PropertyType));
			if (valueInfo.Size > 0)
				reader.BaseStream.Position = startOffset + valueInfo.Size; // Honor the value's size if it has one set
		}

		/// <summary>
		/// Deserializes a value.
		/// </summary>
		/// <param name="reader">The reader.</param>
		/// <param name="context">The serialization context to use.</param>
		/// <param name="valueInfo">The value information. Can be <c>null</c>.</param>
		/// <param name="valueType">The type of the value to deserialize.</param>
		/// <returns>The deserialized value.</returns>
		private static object DeserializeValue(BinaryReader reader, ISerializationContext context, TagElementAttribute valueInfo, Type valueType)
		{
			if (valueType.IsPrimitive)
				return DeserializePrimitiveValue(reader, valueType);
			return DeserializeComplexValue(reader, context, valueInfo, valueType);
		}

		/// <summary>
		/// Deserializes a primitive value.
		/// </summary>
		/// <param name="reader">The reader.</param>
		/// <param name="valueType">The type of the value to deserialize.</param>
		/// <returns>The deserialized value.</returns>
		/// <exception cref="System.ArgumentException">Unsupported type</exception>
		private static object DeserializePrimitiveValue(BinaryReader reader, Type valueType)
		{
			switch (Type.GetTypeCode(valueType))
			{
				case TypeCode.Boolean:
					return reader.ReadBoolean();
				case TypeCode.Byte:
					return reader.ReadByte();
				case TypeCode.Double:
					return reader.ReadDouble();
				case TypeCode.Int16:
					return reader.ReadInt16();
				case TypeCode.Int32:
					return reader.ReadInt32();
				case TypeCode.Int64:
					return reader.ReadInt64();
				case TypeCode.SByte:
					return reader.ReadSByte();
				case TypeCode.Single:
					return reader.ReadSingle();
				case TypeCode.UInt16:
					return reader.ReadUInt16();
				case TypeCode.UInt32:
					return reader.ReadUInt32();
				case TypeCode.UInt64:
					return reader.ReadUInt64();
				default:
					throw new ArgumentException("Unsupported type " + valueType.Name);
			}
		}

		/// <summary>
		/// Deserializes a complex value.
		/// </summary>
		/// <param name="reader">The reader.</param>
		/// <param name="context">The serialization context to use.</param>
		/// <param name="valueInfo">The value information. Can be <c>null</c>.</param>
		/// <param name="valueType">The type of the value to deserialize.</param>
		/// <returns>The deserialized value.</returns>
		private static object DeserializeComplexValue(BinaryReader reader, ISerializationContext context, TagElementAttribute valueInfo, Type valueType)
		{
			// Indirect objects
			// TODO: Remove ResourceReference hax, the Indirect flag wasn't available when I generated the tag structures
			if (valueInfo != null && ((valueInfo.Flags & TagElementFlags.Indirect) != 0 || valueType == typeof(ResourceReference)))
				return DeserializeIndirectValue(reader, context, valueType);

			// enum = Enum type
			if (valueType.IsEnum)
				return DeserializePrimitiveValue(reader, valueType.GetEnumUnderlyingType());

			// string = ASCII string
			if (valueType == typeof(string))
				return DeserializeString(reader);

			// HaloTag = Tag reference
			if (valueType == typeof(HaloTag))
				return DeserializeTagReference(reader, context);

			// ResourceAddress = Resource address
			if (valueType == typeof(ResourceAddress))
				return new ResourceAddress(reader.ReadUInt32());

			// Byte array = Data reference
			// TODO: Allow other types to be in data references, since sometimes they can point to a structure
			if (valueType == typeof(byte[]))
				return DeserializeDataReference(reader, context);
			
			// Vector types
			if (valueType == typeof(Vector2))
				return new Vector2(reader.ReadSingle(), reader.ReadSingle());
			if (valueType == typeof(Vector3))
				return new Vector3(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
			if (valueType == typeof(Vector4))
				return new Vector4(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());

			// Non-byte array = Inline array
			// TODO: Define more clearly in general what constitutes a data reference and what doesn't
			if (valueType.IsArray)
				return DeserializeInlineArray(reader, context, valueInfo, valueType);

			// List = Tag block
			if (valueType.IsGenericType && valueType.GetGenericTypeDefinition() == typeof(List<>))
				return DeserializeTagBlock(reader, context, valueType);

			// Assume the value is a structure
			return DeserializeStruct(reader, context, valueType);
		}

		/// <summary>
		/// Deserializes a tag block (list of values).
		/// </summary>
		/// <param name="reader">The reader.</param>
		/// <param name="context">The serialization context to use.</param>
		/// <param name="valueType">The type of the value to deserialize.</param>
		/// <returns>The deserialized tag block.</returns>
		private static object DeserializeTagBlock(BinaryReader reader, ISerializationContext context, Type valueType)
		{
			var elementType = valueType.GenericTypeArguments[0];
			var result = Activator.CreateInstance(valueType);
			
			// Read count and offset
			var startOffset = reader.BaseStream.Position;
			var count = reader.ReadInt32();
			var pointer = reader.ReadUInt32();
			if (count == 0 || pointer == 0)
			{
				// Null tag block
				reader.BaseStream.Position = startOffset + 0xC;
				return result;
			}

			// Read each value
			var addMethod = valueType.GetMethod("Add");
			reader.BaseStream.Position = context.AddressToOffset((uint)startOffset + 4, pointer);
			for (var i = 0; i < count; i++)
			{
				var element = DeserializeValue(reader, context, null, elementType);
				addMethod.Invoke(result, new[] { element });
			}
			reader.BaseStream.Position = startOffset + 0xC;
			return result;
		}

		/// <summary>
		/// Deserializes a value which is pointed to by an address.
		/// </summary>
		/// <param name="reader">The reader.</param>
		/// <param name="context">The serialization context to use.</param>
		/// <param name="valueType">The type of the value to deserialize.</param>
		/// <returns>The deserialized value.</returns>
		private static object DeserializeIndirectValue(BinaryReader reader, ISerializationContext context, Type valueType)
		{
			// Read the pointer
			var pointer = reader.ReadUInt32();
			if (pointer == 0)
				return null; // Null object

			// Seek to it and read the object
			var nextOffset = reader.BaseStream.Position;
			reader.BaseStream.Position = context.AddressToOffset((uint)nextOffset - 4, pointer);
			var result = DeserializeValue(reader, context, null, valueType);
			reader.BaseStream.Position = nextOffset;
			return result;
		}

		/// <summary>
		/// Deserializes a tag reference.
		/// </summary>
		/// <param name="reader">The reader.</param>
		/// <param name="context">The serialization context to use.</param>
		/// <returns>The deserialized tag reference.</returns>
		private static HaloTag DeserializeTagReference(BinaryReader reader, ISerializationContext context)
		{
			reader.BaseStream.Position += 0xC; // Skip the class name and zero bytes, it's not important
			var index = reader.ReadInt32();
			return context.GetTagByIndex(index);
		}

		/// <summary>
		/// Deserializes a data reference.
		/// </summary>
		/// <param name="reader">The reader.</param>
		/// <param name="context">The serialization context to use.</param>
		/// <returns>The deserialized data reference.</returns>
		private static byte[] DeserializeDataReference(BinaryReader reader, ISerializationContext context)
		{
			// Read size and pointer
			var startOffset = reader.BaseStream.Position;
			var size = reader.ReadInt32();
			reader.BaseStream.Position = startOffset + 0xC;
			var pointer = reader.ReadUInt32();
			if (pointer == 0)
			{
				// Null data reference
				reader.BaseStream.Position = startOffset + 0x14;
				return new byte[0];
			}

			// Read the data
			var result = new byte[size];
			reader.BaseStream.Position = context.AddressToOffset((uint)startOffset + 0xC, pointer);
			reader.Read(result, 0, size);
			reader.BaseStream.Position = startOffset + 0x14;
			return result;
		}

		/// <summary>
		/// Deserializes an inline array.
		/// </summary>
		/// <param name="reader">The reader.</param>
		/// <param name="context">The serialization context to use.</param>
		/// <param name="valueInfo">The value information. Can be <c>null</c>.</param>
		/// <param name="valueType">The type of the value to deserialize.</param>
		/// <returns>The deserialized array.</returns>
		private static Array DeserializeInlineArray(BinaryReader reader, ISerializationContext context, TagElementAttribute valueInfo, Type valueType)
		{
			if (valueInfo == null || valueInfo.Count == 0)
				throw new ArgumentException("Cannot deserialize an inline array with no count set");

			// Create the array and read the elements in order
			var elementCount = valueInfo.Count;
			var elementType = valueType.GetElementType();
			var result = Array.CreateInstance(elementType, elementCount);
			for (var i = 0; i < elementCount; i++)
				result.SetValue(DeserializeValue(reader, context, null, elementType), i);
			return result;
		}

		/// <summary>
		/// Deserializes a null-terminated ASCII string.
		/// </summary>
		/// <param name="reader">The reader.</param>
		/// <returns>The deserialized string.</returns>
		private static string DeserializeString(BinaryReader reader)
		{
			// Keep reading until a null terminator is found
			// TODO: Fix this for UTF-8 strings
			var result = new StringBuilder();
			while (true)
			{
				var ch = reader.ReadByte();
				if (ch == 0)
					break;
				result.Append((char)ch);
			}
			return result.ToString();
		}
	}
}
