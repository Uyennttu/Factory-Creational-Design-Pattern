using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    public class DocumentService
    {
        private readonly DocumentFactory _factory;
        public DocumentService(DocumentFactory factory)
        {
            _factory = factory;
        }

        public void OpenDocument()
        {
            IDocument document = _factory.CreateDocument();
            document.Open();
        }
    }
    
}
