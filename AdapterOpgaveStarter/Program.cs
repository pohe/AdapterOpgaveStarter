// See https://aka.ms/new-console-template for more information
using AdapterOpgaveStarter;

Console.WriteLine("Hello, Adapter pattern!");


OldPrinter oldPrinter = new OldPrinter();
//INewPrinter newPrinter = new PrinterAdapter(oldPrinter);
//newPrinter.SendToPrinter("New document");