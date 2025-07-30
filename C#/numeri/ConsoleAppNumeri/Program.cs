using System;
namespace ConsoleAppNumeri
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 2;
            int c = a + b;
            //esempio di addizzione
            // il numero stampato sarà 7
            Console.WriteLine(c);

            // + per la somma, - per la differenza, * per la moltiplicazione,
            // / per la divisione e % per il modulo (resto della divisione)

            //esempio di espressione, si usano solo parentesi tonde
            //int d = (1 + (2 + 3)) * ((7 - 2) - 4) / 5;

            //esempio di incremento, il numero viene incrementato di 1
            //il numero stampato sarà 6
            Console.WriteLine(++a); //++a equivale ad a = a + 1;

            //esempio di decremento, il numero viene decrementato di 1
            //il numero stampato sarà 4            
            Console.WriteLine(--a); //--a equivale ad a = a - 1;

            //esempio di assegnazione, il numero viene incrementato, decrementato, moltiplicato,
            //diviso o fatto il modulo con un numero a nostra scelta 
            a += 5; //equivale ad a = a + 5
            //il numero stampato sarà 10
            Console.WriteLine(a);

            //esempio metodo Math.Abs(), restituisce un numero intero 
            //assoluto in una variabile intera
            //il numero stampato sarà 40
            Console.WriteLine(Math.Abs(-40));

            //esempio metodo Math.Pow(), prende in input due numeri double, il primo
            //è il numero da elevare ed il secondo è di quanto elevare il 
            //primo numero, restituisce il numero elevato in una variabile double
            //il numero stampato sarà 8
            Console.WriteLine(Math.Pow(2, 3));

            //esempio metodo Math.Sqrt(), prende in input un numero double e fa
            //la radice quadrata di quest'ultimo, restituisce il risultato in
            //una variabile double
            //il numero stampato sarà 4
            Console.WriteLine(Math.Sqrt(16));

            //esempio metodo Math.Max(), prende in input due numeri interi e
            //restituisce quello più grande in una variabile intera
            //il numero stampato sarà 20
            Console.WriteLine(Math.Max(10, 20));

            //esempio metodo Math.Min(), prende in input due numeri interi e
            //restituisce quello più piccolo in una variabile intera
            //il numero stampato sarà 10
            Console.WriteLine(Math.Min(10, 20));
        }
    }
}