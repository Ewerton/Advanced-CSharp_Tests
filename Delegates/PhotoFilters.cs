using System;

namespace Delegates
{
    // Imagine that this class is a buch of filter delivered by some photo processing framework and you want to choose wich filter you want to apply to a photo
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize photo");
        }
    }
}