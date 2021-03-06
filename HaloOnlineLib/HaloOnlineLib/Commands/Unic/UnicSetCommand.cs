﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaloOnlineLib.Serialization;
using HaloOnlineLib.TagStructures;

namespace HaloOnlineLib.Commands.Unic
{
	class UnicSetCommand : Command
	{
		private readonly FileInfo _fileInfo;
		private readonly TagCache _cache;
		private readonly HaloTag _tag;
		private readonly MultilingualUnicodeStringList _unic;
		private readonly StringIdCache _stringIds;

		public UnicSetCommand(FileInfo fileInfo, TagCache cache, HaloTag tag, MultilingualUnicodeStringList unic, StringIdCache stringIds) : base(
			CommandFlags.None,

			"set",
			"Set the value of a string",

			"set <language> <stringid> <value>",

			"Sets the string associated with a stringID in a language.\n" +
			"Remember to put the string value in quotes if it contains spaces.\n" +
			"If the string does not exist, it will be added.")
		{
			_fileInfo = fileInfo;
			_cache = cache;
			_tag = tag;
			_unic = unic;
			_stringIds = stringIds;
		}

		public override bool Execute(List<string> args)
		{
			if (args.Count != 3)
				return false;

			GameLanguage language;
			if (!ArgumentParser.ParseLanguage(args[0], out language))
				return false;

			// Look up the stringID that was passed in
			var stringIdStr = args[1];
			var stringIdIndex = _stringIds.Strings.IndexOf(stringIdStr);
			if (stringIdIndex < 0)
			{
				Console.Error.WriteLine("Unable to find stringID \"{0}\".", stringIdStr);
				return true;
			}
			var stringId = _stringIds.GetStringId(stringIdIndex);
			if (stringId == 0)
			{
				Console.Error.WriteLine("Failed to resolve the stringID.");
				return true;
			}
			var newValue = ArgumentParser.Unescape(args[2]);

			// Look up or create a localized string entry
			var localizedStr = _unic.Strings.FirstOrDefault(s => s.StringId == stringId);
			var added = false;
			if (localizedStr == null)
			{
				// Add a new string
				localizedStr = new HaloOnlineLib.TagStructures.MultilingualUnicodeStringList.LocalizedString {StringId = stringId};
				_unic.Strings.Add(localizedStr);
				added = true;
			}

			// Save the tag data
			_unic.SetString(localizedStr, language, newValue);
			using (var stream = _fileInfo.Open(FileMode.Open, FileAccess.ReadWrite))
				TagSerializer.Serialize(new TagSerializationContext(stream, _cache, _tag), _unic);

			if (added)
				Console.WriteLine("String added successfully.");
			else
				Console.WriteLine("String changed successfully.");
			return true;
		}
	}
}
