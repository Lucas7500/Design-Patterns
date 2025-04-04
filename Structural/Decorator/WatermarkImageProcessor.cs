using Structural.Decorator.Interfaces;

namespace Structural.Decorator
{
    internal class WatermarkImageProcessor(IImageProcessor imageProcessor, string watermark) : IImageProcessor
    {
        public string Process(string imagePath)
        {
            var processedImage = imageProcessor.Process(imagePath);

            // Simulate adding a watermark to the processed image

            return $"{processedImage} and then adding a watermark with text {watermark}";
        }
    }
}
