namespace ConsoleAppWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //esempio cicli while e do while, cicli che vengono eseguiti finché 
            //le condizioni vengono rispettate
            int condizione = 5;

            Console.WriteLine("Esempio ciclo while");
            //controllo in testa, il codice dentro il ciclo while viene eseguito solo e finché la condizione viene rispettata
            //questo succede perché la condizione viene controllata subito
            while (condizione > 0)  //finché condizione maggiore di 0 il codice viene ripetuto
            {
                Console.WriteLine("ora la condizione viene rispettata e quindi mi vedi");
                if (condizione > 2)
                {
                    Console.WriteLine($"mi rivedrai altre {condizione - 1} volte");
                }
                else if (condizione > 1)
                {
                    Console.WriteLine($"mi rivedrai un'ultima volta");
                }
                else
                {
                    Console.WriteLine("questa è l'ultima volta, ciao ciao");
                }
                condizione--;
            }

            Console.WriteLine("Esempio ciclo do while");
            //controllo in coda, il codice dentro il do while viene sempre eseguito almeno una volta
            //questo succede perché la condizione viene controllata alla fine
            do
            {
                Console.WriteLine("ciao, adesso mi vedi anche se la condizione non viene rispettata");
                Console.WriteLine($"adesso condizione vale {condizione}, ma dovrebbe essere maggiore di 5");
                Console.WriteLine("ti saluto, ciao ciao");
            } while (condizione > 5);   //finché condizione maggiore di 5 il codice viene ripetuto, 
                                        //cosa che non succederà
        }
    }
}