using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    public class Processor
    {
        // Declares the degete, i mean, a pointer to any function who returns void and passes a Photo by parameter.
        public event EventHandler Saved;

        public void Save()
        {
            //...

            OnSaved(EventArgs.Empty); //No event data
        }


        protected virtual void OnSaved(EventArgs e)
        {
            Saved?.Invoke(this, e);
        }

    }
}
