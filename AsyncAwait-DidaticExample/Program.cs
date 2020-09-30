using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait_DidaticExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- Synchronous Examples ----------");
            SynchronousExample();
            Console.WriteLine();

            Console.WriteLine("---------- Asynchronous Examples ----------");
            AsyncronousExample();
            Console.WriteLine();

            Console.WriteLine("Want to exit? [Y]Yes [N]No ");
            while (true)
            {
                var keyPress = Console.ReadKey();
                if (keyPress.Key == ConsoleKey.Y)
                    Environment.Exit(0);
            }
        }

        private static void SynchronousExample()
        {
            ArtSeller artseller = new ArtSeller();

            artseller.TellThePainterToPaintSomething("A Beautiful Landscape");
            artseller.TellThePainterToPaintSomething("Mona Lisa");
            artseller.TellThePainterToPaintSomething("Some Abstract Art");
            artseller.TellThePainterToPaintSomething("A Caricature of someone famous.");
            artseller.TellThePainterToPaintSomething("A Anime Character");
        }

        private static void AsyncronousExample()
        {
            ArtSeller artseller = new ArtSeller();

            artseller.TellThePainterToPaintSomethingAsync("A Beautiful Landscape");
            artseller.TellThePainterToPaintSomethingAsync("Mona Lisa");
            artseller.TellThePainterToPaintSomethingAsync("Some Abstract Art");
            artseller.TellThePainterToPaintSomethingAsync("A Caricature of someone famous.");
            artseller.TellThePainterToPaintSomethingAsync("A Anime Character");


        }


    }
}
