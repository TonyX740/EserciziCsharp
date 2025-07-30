namespace ConsoleAppTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //esempio di calcolatrice, prende in input due numeri e stampa
            //la somma di questi ultimi, da errore se non diamo un input o non
            //mettiamo un numero, gli errori vengono gestiti dai try catch,
            //questo ci permette di gestire le varie eccezioni e di non far
            //crashare il programma e quindi terminarlo normalmente
            int num1 = 0;
            int num2 = 0;

            //dentro il try mettiamo il codice che potrebbe lanciare eccezioni
            try
            {
                Console.WriteLine("Sommiamo due numeri \nInserisci il primo:");
                //in questo caso int.Parse() può lanciare diverse eccezioni
                //che sono ArgumentNullException, FormatException e OverflowException
                num1 = int.Parse(Console.ReadLine());
            }
            //in caso di eccezione entra in gioco il catch
            //questo catch entra in gioco se non inseriamo nulla
            catch (ArgumentNullException)
            {
                Console.WriteLine("Errore: numero non inserito");
            }
            //questo catch entra in gioco se inseriamo uno o più caratteri
            //al posto di un numero
            catch (FormatException)
            {
                Console.WriteLine("Errore: carattere inserito al posto del numero");
            }
            //questo catch entra in gioco se inseriamo un numero troppo grande,
            //per esempio mettiamo un numero che non entra in una variabile intera
            catch (OverflowException)
            {
                Console.WriteLine("Errore: numero troppo grande");
            }
            //quello scritto sopra vale anche per i try catch qui sotto
            try
            {
                Console.WriteLine("Inserisci il secondo:");
                num2 = int.Parse(Console.ReadLine());
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Errore: numero non inserito");
            }
            catch (FormatException)
            {
                Console.WriteLine("Errore: carattere inserito al posto del numero");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Errore: numero troppo grande");
            }
            //il codice dentro finally viene eseguito sia in caso di successo che di eccezione
            //questo può essere utile per esempio per chiudere l'accesso ad un file o ad un DB
            finally
            {
                Console.WriteLine($"La somma dei numeri {num1} e {num2} è: {num1 + num2}");
            }

            Console.WriteLine("Ciao ciao");
        }
    }
}