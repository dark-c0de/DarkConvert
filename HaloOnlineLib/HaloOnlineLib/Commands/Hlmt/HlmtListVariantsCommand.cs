﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaloOnlineLib.TagStructures;

namespace HaloOnlineLib.Commands.Hlmt
{
	class HlmtListVariantsCommand : Command
	{
		private readonly Model _model;
		private readonly StringIdCache _stringIds;

		public HlmtListVariantsCommand(Model model, StringIdCache stringIds) : base(
			CommandFlags.Inherit,

			"listvariants",
			"List available variants",

			"listvariants",

			"Lists variant names which can be used with \"extractmode\".")
		{
			_model = model;
			_stringIds = stringIds;
		}

		public override bool Execute(List<string> args)
		{
			if (args.Count != 0)
				return false;
			var variantNames = _model.Variants.Select(v => _stringIds.GetString(v.Name) ?? v.Name.ToString()).OrderBy(n => n).ToList();
			if (variantNames.Count == 0)
			{
				Console.WriteLine("Model has no variants");
				return true;
			}
			foreach (var name in variantNames)
				Console.WriteLine(name);
			return true;
		}
	}
}
