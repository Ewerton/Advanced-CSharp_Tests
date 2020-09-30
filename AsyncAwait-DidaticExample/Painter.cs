using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait_DidaticExample
{
    public class Painter
    {
        public PaintingResult Paint(string artworkSpecification)
        {
            Console.WriteLine("Painter: I'am painting '{0}'", artworkSpecification);
            Bitmap drawing = Utils.GetRandomBitmap();

            // Simulating a variable time do finish the painting
            var seconds = Utils.RandomSecondsToWait;
            Thread.Sleep(TimeSpan.FromSeconds(seconds));

            PaintingResult result = new PaintingResult();
            result.TheImage = drawing;
            result.TimeSpentToFinish = TimeSpan.FromSeconds(seconds);

            Console.WriteLine(String.Format("Painter: Finished to paint '{0}'. It took {1} seconds. The image size is {2} x {3} pixels",
                                          artworkSpecification,
                                          result.TimeSpentToFinish,
                                          result.TheImage.Width,
                                          result.TheImage.Height));

            return result;
        }

        public async Task<PaintingResult> PaintAsync(string paintingSpecification)
        {
            Console.WriteLine("PainterAsync: I'am painting '{0}'", paintingSpecification);

            Bitmap drawing = Utils.GetRandomBitmap();

            // Simulating a variable time do finish the painting
            var seconds = Utils.RandomSecondsToWait;
            await Task.Delay(TimeSpan.FromSeconds(seconds));

            PaintingResult result = new PaintingResult();
            result.TheImage = drawing;
            result.TimeSpentToFinish = TimeSpan.FromSeconds(seconds);

            Console.WriteLine(String.Format("PainterAsync: Finished to paint '{0}'. It took {1} seconds. The image size is {2} x {3} pixels",
                                            paintingSpecification,
                                            result.TimeSpentToFinish,
                                            result.TheImage.Width,
                                            result.TheImage.Height));

            return result;
        }
    }
}
