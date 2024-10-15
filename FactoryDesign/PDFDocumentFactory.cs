namespace FactoryDesign
{
    public class PDFDocumentFactory : DocumentFactory {
        public override IDocument CreateDocument()
        {
            return new PDFDocument();
        }
    }
}
