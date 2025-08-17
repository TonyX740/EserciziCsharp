namespace ConsoleAppFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //esempio di ciclo for
            //il ciclo for è composto da iteratore (i, che viene visto solo dentro il for), condizione e incremento o decremento
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ciao, sono un ciclo for con i={i}");
            }

            //esempio foreach
            string[] nomi = ["tony", "vix", "neon", "Sashi", "Stronkler", "Elly", "basta"]; //lista di nomi (poi vediamo cos'è)

            //il ciclo foreach viene usato per scorrere gli elementi dentro liste ed array
            //in questo caso stiamo dicendo di eseguire un istruzione per ogni nome presente nella lista nomi
            foreach (string nome in nomi)
            {
                Console.WriteLine(nome);
            }

        }
    }
}