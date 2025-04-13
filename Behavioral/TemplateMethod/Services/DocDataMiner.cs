namespace Behavioral.TemplateMethod.Services
{
    internal class DocDataMiner : DataMiner
    {
        protected override string OpenFile(string filePath)
        {
            return "Content in Doc format";
        }

        protected override string[] ExtractData(string fileContent)
        {
            return ["Doc", "Data"];
        }

        protected override string[] ParseData(string[] rawData)
        {
            return ["Parsed", "Doc", "Data"];
        }
    }
}
