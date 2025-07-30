using System.ComponentModel;

namespace ConsoleAppIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int anno = 0;
            bool isCorrect = true;
            Console.WriteLine("Ciao, questo programma calcola se un anno è bisestile o no");
            Console.WriteLine("Dammi un numero");
            try
            {
                anno = int.Parse(Console.ReadLine());
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("L'input non può essere vuoto");
                isCorrect = false;
            }
            catch (FormatException)
            {
                Console.WriteLine("L'input deve essere un numero intero");
                isCorrect = false;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Il numero è troppo grande");
                isCorrect = false;
            }
            if (isCorrect)
            {
                if (anno > 1581)
                {
                    if (anno % 4 == 0)
                    {
                        if (anno % 100 != 0)
                        {
                            Console.WriteLine($"{anno} è un anno bisestile");
                        }
                        else if (anno % 100 == 0 && anno % 400 == 0)
                        {
                            Console.WriteLine($"{anno} è un anno bisestile");
                        }
                        else
                        {
                            Console.WriteLine($"{anno} non è un anno bisestile");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{anno} non è un anno bisestile");
                    }
                }
                else if (anno > 3 && anno <= 1581)
                {
                    if (anno % 4 == 0)
                    {
                        Console.WriteLine($"{anno} è un anno bisestile");
                    }
                    else
                    {
                        Console.WriteLine($"{anno} non è un anno bisestile");
                    }
                }
                else if (anno > 0 && anno <= 3)
                {
                    Console.WriteLine($"{anno} non è un anno bisestile");
                }
                else if (anno <= 0)
                {
                    Console.WriteLine("Anno non valido");
                }
            }
            else
            {
                Console.WriteLine("Input non valido");
            }
        }
    }
}