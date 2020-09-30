using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait_DidaticExample
{
    public class ArtSeller
    {
        public void TellThePainterToPaintSomething(string drawingSpecification)
        {
            Painter painter = new Painter();

            // In a syncronous scenário the Art Seller tell the Painter to draw something. 
            // The painter will stay freezed, doing absolutly nothing! until the Painter finishes his job.
            // Maybe the painting takes days, weeks or even months to be finished, it doest matter, the seller will wait!.
            PaintingResult result = painter.Paint(drawingSpecification);

            // The lines below will be executed only when the previous one finishes his work.
            TryToSellThePaintingToLocalArtGallery(drawingSpecification);
            TryToSellThePaintingAtAmazon(drawingSpecification);
            TryToSellThePaintingAteBay(drawingSpecification);
        }


        public void TellThePainterToPaintSomethingAsync(string drawingSpecification)
        {
            Painter painter = new Painter();

            // At this point you dont have the painting finished yet, you have just a "promisse" that it will be done.
            Task<PaintingResult> slowTask = painter.PaintAsync(drawingSpecification);

            // After asks the Painter to paint something calling the painter.PaintAsync() method the control flow returns to HERE!
            // Now, the Art Seller can immediately tries to sell the artwork while it will be produced.
            TryToSellThePaintingToLocalArtGallery(drawingSpecification);
            TryToSellThePaintingAtAmazon(drawingSpecification);
            TryToSellThePaintingAteBay(drawingSpecification);

            var result = slowTask.Result;
        }

        private void TryToSellThePaintingAteBay(string drawingSpecification)
        {
            Console.WriteLine(String.Format("Art Seller: Trying to sell '{0}' at eBay.", drawingSpecification));
        }

        private void TryToSellThePaintingAtAmazon(string drawingSpecification)
        {
            Console.WriteLine(String.Format("Art Seller: Trying to sell '{0}' at Amazon.", drawingSpecification));
        }

        private void TryToSellThePaintingToLocalArtGallery(string drawingSpecification)
        {
            Console.WriteLine(String.Format("Art Seller: Trying to sell '{0}' to a local Art Gallery.", drawingSpecification));
        }
    }
}
