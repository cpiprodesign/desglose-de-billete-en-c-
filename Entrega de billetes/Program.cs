using System;

namespace Entrega_de_billetes
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant, b100, b50, b20, b10, b5;
            string linea;
            b100 = 0;
            b50 = 0;
            b20 = 0;
            b10 = 0;
            b5 = 0;
            Console.WriteLine("Ingresa la cantidad");
            linea = Console.ReadLine();
            cant = int.Parse(linea);
            if (cant >= 100)
            {
                b100 = (cant / 100);
                cant = cant - (b100 * 100);
            }
            if (cant >= 50)
            {
                b50= (cant / 50);
                cant = cant - (b50 * 50);
            }
            if (cant >= 20)
            {
                b20 = (cant / 20);
                cant = cant - (b20 * 20);
            }
            if (cant >= 10)
            {
                b10 = (cant / 10);
                cant = cant - (b10 * 10);
            }
            if (cant >= 5)
            {
                b5 = (cant / 5);
                cant = cant - (b5* 10);
            }
            Console.WriteLine("Billetes de a 100 hay: "+b100);
            Console.WriteLine("Billetes de a 50 hay: " + b50);
            Console.WriteLine("Billetes de a 20 hay: " + b20);
            Console.WriteLine("Billetes de a 10 hay: " + b10);
            Console.WriteLine("Billetes de a 5 hay: " + b5);

            Console.WriteLine(cant);
            Console.ReadLine();
        }
    }
}
