﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markdown
{
    public enum TokenType
    {
        defaultToken = 0,
        bold = 1,
        italic = 2,

    }

    internal class MarkdownParser
    {
        public static string[] GetArrayWithMdTags(string stringWithTags)
        {
            var mdTags = new HashSet<string>() { "# ", "__", "_", "\\" };
            var charString = stringWithTags.ToArray();
            for (var i = 0; i < stringWithTags.Length; i++)
            {


            }



            return new[] { "e" };
        }



         


    }
}
