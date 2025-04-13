namespace Behavioral.TemplateMethod
{
    internal abstract class DataMiner
    {
        public void Mine(string filePath)
        {
            var fileContent = OpenFile(filePath);
            var rawData = ExtractData(fileContent);
            var data = ParseData(rawData);
            var analysisResult = AnalyzeData(data);

            SendReport(analysisResult);
        }

        protected abstract string OpenFile(string filePath);

        protected abstract string[] ExtractData(string fileContent);
        
        protected abstract string[] ParseData(string[] rawData);

        protected virtual string[] AnalyzeData(string[] data)
        {
            return ["Analyzed", "Data"];
        }

        protected virtual void SendReport(string[] analysisResult)
        {
            Console.WriteLine("Report sent");
        }
    }
}
