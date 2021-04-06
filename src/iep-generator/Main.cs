using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using IEP.Generator.Core.Word;
using Novacode;

namespace IEP.Generator.Core
{
    public static class Program
    {
        private const string Word = @"C:\Program Files (x86)\Microsoft Office\root\Office16\winword.exe";

        private const string FileName = @"V:\repos\iep-generator\res\2021_iep_karl_yeoman.xml";

        public static void Main(string[] args)
        {



            using (var doc = new DocumentWriter("output.docx"))
            {
                doc.WriteTitle("Karl Yeoman");
                doc.WriteSubtitle("Individualized Education Plan");

                doc.WriteSection("Accommodations List");
                doc.WriteSection("Present Levels of Academic Achievement and Functional Performance (PLAAFP)");
                doc.WriteSection("Measurable Annual Goals");

                doc.Save();
               
            }

            Process.Start(Word, "output.docx");
        }
    }
}
