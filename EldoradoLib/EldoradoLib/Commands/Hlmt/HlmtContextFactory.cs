﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EldoradoLib.TagStructures;

namespace EldoradoLib.Commands.Hlmt
{
	static class HlmtContextFactory
	{
		public static CommandContext Create(CommandContext parent, FileInfo fileInfo, TagCache cache, StringIdCache stringIds, HaloTag tag, Model model)
		{
			var context = new CommandContext(parent, string.Format("{0:X8}.hlmt", tag.Index));
			context.AddCommand(new HlmtListVariantsCommand(model, stringIds));
			context.AddCommand(new HlmtExtractModeCommand(cache, fileInfo, model, stringIds));
			return context;
		}
	}
}
