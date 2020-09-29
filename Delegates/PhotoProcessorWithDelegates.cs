using System;

namespace Delegates
{
    public class PhotoProcessorWithDelegates
    {

        // Declares the degete, i mean, a pointer to any function who returns void and passes a Photo by parameter.
        public delegate void PhotoFilterEventHandler(Photo photo);
        
        // We change the signature of the Process method to receive the delegate as parameter, so the cliente code (the caller) will need to instantiate a filter and pass it here
        public void Process(string path, PhotoFilterEventHandler filterHandler)
        {
            var photo = Photo.Load(path);

            // It does mean that this Process() method does not know which filter will be applyed.
            // The cliente code (the caller) will takes this decision
            filterHandler(photo);

            photo.Save();
        }
    }
}