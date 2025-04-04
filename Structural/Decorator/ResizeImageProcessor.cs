using Structural.Decorator.Interfaces;

namespace Structural.Decorator
{
    internal class ResizeImageProcessor(IImageProcessor imageProcessor, int width, int height) : IImageProcessor
    {
        public string Process(string imagePath)
        {
            var processedImage = imageProcessor.Process(imagePath);

            // Simulate resizing the image

            return $"{processedImage} and then resizing it to {width}x{height}";
        }
    }
}
