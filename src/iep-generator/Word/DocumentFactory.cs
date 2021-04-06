using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Novacode;

namespace IEP.Generator.Core.Word
{
    internal static class DocumentFactory
    {

       


        public static Font PrimaryFont = new("Arial");


        public static readonly Formatting TitleFormatting = new()
        {
            Bold = false,
            Size = 36,
            FontFamily = PrimaryFont,
            FontColor = System.Drawing.Color.Black,
        };

        public static readonly Formatting SubtitleFormatting = new()
        {
            Bold = false,
            Size = 24,
            FontFamily = PrimaryFont,
            FontColor = System.Drawing.Color.Gray,
        };

        public static readonly Formatting SectionFormatting = new()
        {
            Bold = true,
            Size = 18,
            Spacing = 1.5,
            FontFamily = PrimaryFont,
            FontColor = System.Drawing.Color.Black,
            UnderlineStyle = UnderlineStyle.thick
        };
    }
}
