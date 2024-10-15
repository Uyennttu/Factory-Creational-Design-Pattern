using System;

namespace FactoryDesign
{
    public class PDFDocument: IDocument
    {
        public void Open() { Console.WriteLine("Open PDF"); }
    }
}
