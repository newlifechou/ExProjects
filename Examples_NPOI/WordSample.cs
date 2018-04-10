using NPOI.XWPF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_NPOI
{
    class WordSample
    {
        public void WriteNew()
        {
            XWPFDocument doc = new XWPFDocument();

            XWPFParagraph p = doc.CreateParagraph();
            p.Alignment = ParagraphAlignment.CENTER;
            XWPFRun run = p.CreateRun();
            run.SetText("the brown fox");
            FileStream sw = File.Create("fuck.docx");
            doc.Write(sw);
            sw.Close();

            System.Diagnostics.Process.Start("fuck.docx");
        }
    }
}
