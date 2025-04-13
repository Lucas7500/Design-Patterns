
namespace Behavioral.TemplateMethod.Services
{
    internal class CsvDataMiner : DataMiner
    {
        protected override string OpenFile(string filePath)
        {
            return "Content in Csv format";
        }

        protected override string[] ExtractData(string fileContent)
        {
            return ["Csv", "Data"];
        }

        protected override string[] ParseData(string[] rawData)
        {
            return ["Parsed", "Csv", "Data"];
        }
    }
}
