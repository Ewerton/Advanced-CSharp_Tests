using System;

namespace Delegates
{
    public class PhotoProcessorWithFunc
    {
        // Func are kind of "generic delegates" that returns a value. They can be used for everything where a delegate is needed.
        // I mean, we dont need to create our custom delegate like we do in the PhotoProcessorWithDelegates() class, 
        //we just need to receive a Func<>() in the Process() Method and let the client code (the caller) pass in what he need to be executed

        public ImageProcessingResult Process(string path, Func<Photo, ImageProcessingResult> filterHandler)
        {
            var photo = Photo.Load(path);
            ImageProcessingResult result = filterHandler(photo);

            photo.Save();

            return result;
        }
    }
}