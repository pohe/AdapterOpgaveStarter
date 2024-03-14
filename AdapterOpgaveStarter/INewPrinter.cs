using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterOpgaveStarter
{
    // Interface, som det nye system forventer
    public interface INewPrinter
    {
        void SendToPrinter(string document);
    }
}
