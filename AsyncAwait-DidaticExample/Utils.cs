using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait_DidaticExample
{
    public class Utils
    {
        //Just a Maximum number of seconds can be spent to draw something
        public static int TimeLimitToSimulateSlowTask = 10;

        public static  int RandomSecondsToWait
        {
            get
            {
                Random rand = new Random();
                var seconds = 0;

                while (seconds == 0)
                    seconds = rand.Next(Utils.TimeLimitToSimulateSlowTask);

                return seconds;
            }
        }

        public static Bitmap GetRandomBitmap()
        {
            Random rand = new Random();
            var width = rand.Next(1000);
            var height = rand.Next(1000);

            Bitmap myBitmap = new Bitmap(width, height);
            Graphics flagGraphics = Graphics.FromImage(myBitmap);
            int red = 0;
            int white = 11;
            while (white <= 100)
            {
                flagGraphics.FillRectangle(Brushes.Red, 0, red, width, 10);
                flagGraphics.FillRectangle(Brushes.White, 0, white, width, 10);
                red += 20;
                white += 20;
            }

            return myBitmap;

        }
    }
}
