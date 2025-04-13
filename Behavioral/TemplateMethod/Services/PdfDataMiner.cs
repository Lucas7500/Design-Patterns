namespace Behavioral.TemplateMethod.Services
{
    internal class PdfDataMiner : DataMiner
    {
        protected override string OpenFile(string filePath)
        {
            return "Content in Pdf format";
        }

        protected override string[] ExtractData(string fileContent)
        {
            return ["Pdf", "Data"];
        }

        protected override string[] ParseData(string[] rawData)
        {
            return ["Parsed", "Pdf", "Data"];
        }
    }
}
