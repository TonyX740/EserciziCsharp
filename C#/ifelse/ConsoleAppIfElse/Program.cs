using System.ComponentModel;

namespace ConsoleAppIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            //esempio if else
            //programma che usa le condizioni if else per calcolare l'anno bisestile
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
            if (isCorrect)  //equivale a scrivere if (isCorrect == true)
            {
                //se ifcorrect è uguale a true questa parte di codice viene eseguita
                if (anno > 1581)
                {
                    //se l'anno è maggiore di 1581 questa parte di codice viene eseguita
                    if (anno % 4 == 0)
                    {
                        //se l'anno diviso 4 da resto 0 questa parte di codice viene eseguita
                        if (anno % 100 != 0)
                        {
                            //se l'anno diviso 100 non da resto 0 questa parte di codice viene eseguita
                            Console.WriteLine($"{anno} è un anno bisestile");
                        }
                        else if (anno % 100 == 0 && anno % 400 == 0)
                        {
                            // altrimenti se l'anno diviso 100 da resto 0 e anche 
                            // diviso 400 da resto 0 questa parte di codice viene eseguita
                            Console.WriteLine($"{anno} è un anno bisestile");
                        }
                        else
                        {
                            //se nessuna delle condizioni sopra viene rispettata
                            //questa parte di codice viene eseguita
                            Console.WriteLine($"{anno} non è un anno bisestile");
                        }
                    }
                    else
                    {
                        //se l'anno diviso 4 non da resto 0 questa parte di codice viene eseguita
                        Console.WriteLine($"{anno} non è un anno bisestile");
                    }
                }
                else if (anno > 3 && anno <= 1581)
                {
                    // altrimenti se l'anno è maggiore di 3 e anche 
                    // minore o uguale a 1581 questa parte di codice viene eseguita
                    if (anno % 4 == 0)
                    {
                        //se l'anno diviso 4 da resto 0 questa parte di codice viene eseguita
                        Console.WriteLine($"{anno} è un anno bisestile");
                    }
                    else
                    {   //altrimenti viene eseguita quest'altra
                        Console.WriteLine($"{anno} non è un anno bisestile");
                    }
                }
                else if (anno > 0 && anno <= 3)
                {
                    // altrimenti se l'anno è maggiore di 0 e anche 
                    // minore o uguale a 3 questa parte di codice viene eseguita
                    Console.WriteLine($"{anno} non è un anno bisestile");
                }
                else if (anno <= 0)
                {
                    // altrimenti se l'anno è 
                    // minore o uguale a 0 questa parte di codice viene eseguita
                    Console.WriteLine("Anno non valido");
                }
            }
            else
            {
                //se ifcorrect è uguale a false questa parte di codice viene eseguita
                Console.WriteLine("Input non valido");
            }
        }
    }
}