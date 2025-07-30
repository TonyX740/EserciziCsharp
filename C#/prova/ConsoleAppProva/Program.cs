using System;

namespace ConsoleAppProva
{
    class Program
    {
        static void Main(string[] args)
        {
            String testo = "questa è una stringa";
            char lettera = 'l';

            int intero = 10;
            long lungo = 10000000000;

            double doppio = 2.5;
            float volante = 3.5f;
            decimal decimale = 7.5m;

            bool booleano = true;

            Console.WriteLine(testo);
            Console.WriteLine("lettera:" + lettera);
            Console.WriteLine("numero intero:" + intero);
            Console.WriteLine("numero lungo:" + lungo);
            Console.WriteLine("numero doppio:" + doppio);
            Console.WriteLine("numero volante:" + volante);
            Console.WriteLine("numero decimale:" + decimale);
            Console.WriteLine("booleano (vero o falso):" + booleano);
        }
    }
}
