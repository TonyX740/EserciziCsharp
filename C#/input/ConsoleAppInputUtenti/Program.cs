using System;

namespace ConsoleAppInputUtenti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero");
            //usiamo Console.ReadLine() per prendere in input da tastiera una stringa
            //e salvarla dentro inputUtente (? indica che la variabile può essere nel
            //nostro caso o string o null, questo perché il metodo Console.ReadLine()
            //può restituire o una stringa o un null)
            string? inputUtente = Console.ReadLine();
            Console.WriteLine($"Il numero inserito è: {inputUtente}");

            //esempio di calcolatrice sbilenca, prende in input due numeri e stampa
            //la somma di questi ultimi, crasha se non diamo un input o non
            //mettiamo un numero, non è l'ideale farla così ma per il momento
            //va bene (da notare i warning)
            Console.WriteLine("Sommiamo due numeri \nInserisci il primo:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"La somma dei due numeri è: {num1 + num2}");
        }
    }
}
