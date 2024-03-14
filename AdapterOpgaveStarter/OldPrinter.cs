using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterOpgaveStarter
{
    // Eksisterende klasse med uforeneligt interface
    public class OldPrinter
    {
        public void PrintDocument(string document)
        {
            Console.WriteLine("Old Printer is printing: " + document);
        }
    }
}
