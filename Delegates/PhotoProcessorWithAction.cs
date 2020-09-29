using System;

namespace Delegates
{
    public class PhotoProcessorWithAction
    {
        // Actions are kind of "generic delegates" they can be used for everything where a delegate is needed.
        // I mean, we dont need to create our custom delegate like we do in the PhotoProcessorWithDelegates() class, 
        // we just need to receive a Action<>() in the Process() Method and let the client code (the caller) pass in what he need to be executed

        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);

            photo.Save();
        }
    }
}