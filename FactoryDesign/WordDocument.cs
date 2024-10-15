using System;

namespace FactoryDesign
{
    public class WordDocument : IDocument
    {
        public void Open() { Console.WriteLine("Open Word"); }
    }
}
