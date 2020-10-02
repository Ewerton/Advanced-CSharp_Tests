using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    // A class derived from EventArgs to represent the arguments of the delegate
    public class ProcessingArgs : EventArgs
    {
        public bool Success { get; set; }

        public DateTime FinishDate { get; set; }
    }
}
