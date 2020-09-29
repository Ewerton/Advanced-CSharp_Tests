using System;

namespace Delegates
{
    public class PhotoProcessorWithoutDelegates
    {
        public void Process(string path)
        {
            // Nothing new, simply calling method from another class, bat what if we want to provide some "extensibility" to the PhotoProcessor?
            // What if a user does not want to resize?
            // What if the user wants to implement, lets say: RedEyeCorrection()?
            // How this is possible without needing to recompile and redeploy this class?
            // look at the PhotoProcessorWithDelegates class!
            var photo = Photo.Load(path);
            var filters = new PhotoFilters();
            filters.ApplyBrightness(photo);
            filters.ApplyContrast(photo);
            filters.Resize(photo);

            photo.Save();
        }
    }
}