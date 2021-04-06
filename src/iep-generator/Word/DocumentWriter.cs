using System;
using Novacode;

namespace IEP.Generator.Core.Word
{
    internal class DocumentWriter : IDisposable
    {
        private readonly DocX _document;


        public DocumentWriter(string path)
            : this(DocX.Create(path))
        {

        }

        public DocumentWriter(DocX document)
        {
            _document = document;
        }

        public void WriteTitle(string title)
        {
            var para = _document.InsertParagraph(title, false, DocumentFactory.TitleFormatting);
            para.Alignment = Alignment.left;
            para.Heading(HeadingType.Heading1);
        }

        public void WriteSubtitle(string subtitle)
        {
            _document.InsertParagraph(subtitle, false, DocumentFactory.SubtitleFormatting)
                        .Alignment = Alignment.left;
        }

        public void WriteSection(string name)
        {
            var para = _document.InsertParagraph(name, false, DocumentFactory.SectionFormatting);
            para.Alignment = Alignment.left;
            para.Heading(HeadingType.Heading2);
        }

        public void Save()
        {
            _document.Save();
        }

        public void Dispose()
        {
            ((IDisposable)_document).Dispose();
        }
    }
}
