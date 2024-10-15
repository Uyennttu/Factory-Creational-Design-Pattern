using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FactoryDesign;

namespace FactoryDesign
{
    public class Program
    {
        static void Main(string[] args) 
        {
            DocumentFactory pdfFactory = new PDFDocumentFactory();
            DocumentFactory wordFactory = new WordDocumentFactory();

            DocumentService documentService = new DocumentService(wordFactory);
            DocumentService documentService1 = new DocumentService(pdfFactory);
            documentService.OpenDocument();
            documentService1.OpenDocument();    
        }
    }
}
