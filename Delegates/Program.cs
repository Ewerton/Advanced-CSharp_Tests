using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing TestWithoutDelegates()");
            TestWithoutDelegates();
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Executing TestWithDelegates()");
            TestWithDelegates();
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Executing TestWithAction()");
            TestWithAction();
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Executing GenericDelegate()");
            TestGenericDelegate();
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Executing TestWithFunc()");
            TestWithFunc();
            Console.WriteLine("--------------------------------");

        }

        private static void TestWithoutDelegates()
        {
            var processor = new PhotoProcessorWithoutDelegates();
            processor.Process("Image.jpg");
        }

        private static void TestWithDelegates()
        {
            var processor = new PhotoProcessorWithDelegates();
            PhotoFilters filters = new PhotoFilters();

            // Here we are saying that the filterHandler point to the ApplyBrightness() method.
            PhotoProcessorWithDelegates.PhotoFilterEventHandler filterHandlers = filters.ApplyBrightness;
            // We can set the pointer to a a lambra expression as well
            //PhotoProcessorWithDelegates.PhotoFilterEventHandler filterHandler2 = (Photo photo) => MethodA(photo);

            // The delegates are MultiCastDelegates, this mean we can assign more than one method. In this case the ApplyBrightness() and the ApplyContrast() will be applyed to te image
            // Note that in this way we dont need to change the PhotoFilters() class nor the PhotoProcessor()
            filterHandlers += filters.ApplyContrast;


            // What if i want to create my own filter? lets say... a filter to remove red eye? I can implement it and pass it to the processor, like this.
            filterHandlers += RemoveRedEye;


            // Here we pass a image and a handler (or a list of handlers). The Process() method will just apply the filter we pass here.
            processor.Process("Image.jpg", filterHandlers);

        }

        private static void TestWithAction()
        {
            var processor = new PhotoProcessorWithAction();
            PhotoFilters filters = new PhotoFilters();

            // Here we are saying that the filterHandler point to the ApplyBrightness() method.
            Action<Photo> filterHandlers = filters.ApplyBrightness;
            // We can set the pointer to a a lambra expression as well
            //Action<Photo> filterHandlers2 = (Photo photo) => Console.WriteLine("Creating an calling an inline 'filter'");

            // The delegates are MultiCastDelegates, this mean we can assign more than one method. In this case the ApplyBrightness() and the ApplyContrast() will be applyed to te image
            // Note that in this way we dont need to change the PhotoFilters() class nor the PhotoProcessor()
            filterHandlers += filters.Resize;


            // What if i want to create my own filter? lets say... a filter to remove red eye? I can implement it and pass it to the processor, like this.
            filterHandlers += RemoveRedEye;


            // Here we pass a image and a handler (or a list of handlers). The Process() method will just apply the filter we pass here.
            processor.Process("Image.jpg", filterHandlers);
        }

        private static void TestWithFunc()
        {
            var processor = new PhotoProcessorWithFunc();
            PhotoFiltersWithResults filters = new PhotoFiltersWithResults();

            // Here we are saying that the filterHandler point to the ApplyBrightness() method.
            Func<Photo, ImageProcessingResult> filterHandlers = filters.ApplyBrightness;

            // We can assign a labda to an Func
            Func<Photo, ImageProcessingResult> myInLineFilter = (Photo photo) =>
            {
                Console.WriteLine("Creating an calling an inline 'filter' from lambda function");
                return new ImageProcessingResult() { Result = true, SizeInBytesAfterProcessing = 30 };
            };

            // We can assign an anonymous method to a Func
            Func<Photo, ImageProcessingResult> myInLineFilter2 = delegate (Photo photo)
            {
                Console.WriteLine("Creating an calling an inline 'filter' from anonymous function");
                return new ImageProcessingResult() { Result = true, SizeInBytesAfterProcessing = 40 };
            };


            // Here we pass a image and a handler (or a list of handlers). The Process() method will just apply the filter we pass here.
            var result = processor.Process("Image.jpg", filterHandlers);
        }


        // If i want to develop my own filter, i can do it and pass this filter to the processor class
        private static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Removing red eyes...");
        }
        private static void TestGenericDelegate()
        {
            GenericDelegate genDel = new GenericDelegate();
            genDel.Execute();

        }

    }
}
