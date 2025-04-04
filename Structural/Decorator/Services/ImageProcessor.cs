using Structural.Decorator.Interfaces;

namespace Structural.Decorator.Services
{
    internal class ImageProcessor : IImageProcessor
    {
        public string Process(string imagePath)
        {
            if (string.IsNullOrWhiteSpace(imagePath))
            {
                throw new ArgumentException("Image path cannot be null or empty!", nameof(imagePath));
            }

            // Simulate image processing logic

            return $"Processing image at {imagePath}";
        }
    }
}
