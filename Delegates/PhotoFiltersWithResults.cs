using System;

namespace Delegates
{
    // Imagine that this class is a buch of filter delivered by some photo processing framework and you want to choose wich filter you want to apply to a photo
    public class PhotoFiltersWithResults
    {
        public ImageProcessingResult ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness");

            return new ImageProcessingResult()
            {
                Result = true,
                SizeInBytesAfterProcessing = 10
            };
        }

        public ImageProcessingResult ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast");

            return new ImageProcessingResult()
            {
                Result = true,
                SizeInBytesAfterProcessing = 20
            };
        }


        public ImageProcessingResult Resize(Photo photo)
        {
            Console.WriteLine("Resize photo");

            return new ImageProcessingResult()
            {
                Result = true,
                SizeInBytesAfterProcessing = 20
            };
        }
    }
}