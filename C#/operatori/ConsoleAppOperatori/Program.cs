namespace ConsoleAppOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            //esempi di operatori di comparazione
            Console.WriteLine("esempi di operatori di comparazione");

            //maggiore >
            //verrà stampato true perché 2 è maggiore di 1
            Console.WriteLine($"2>1:{2 > 1}");

            //minore <
            //verrà stampato true perché 3 è minore di 5
            Console.WriteLine($"3<5:{3 < 5}");

            //uguale == (da non confondere con = che si usa per l'assegnazione)
            //verrà stampato false perché 10 non è uguale a 20
            Console.WriteLine($"10==20:{10 == 20}");

            //maggiore o uguale >=
            //verrà stampato true perchè 30 è maggiore o uguale di 26
            Console.WriteLine($"30>=25:{30 >= 26}");

            //minore o uguale <=
            //verrà stampato false perchè 26 non è minore o uguale di 20
            Console.WriteLine($"26<=20:{26 <= 20}");

            //diverso !=
            //verrà stampato true perché 10 è diverso da 11
            Console.WriteLine($"10!=30:{10 != 11}");

            //esempio di operatori logici
            string colore = "rosso";
            int taglia = 43;

            Console.WriteLine($"esempi di operatori logici\ncolore:{colore} taglia:{taglia}");

            //and && (restituisce true se tutte le condizioni sono rispettate)
            //verrà stampato true perché entrambe le condizioni vengono rispettate
            Console.WriteLine($"disponibile colore rosso e taglia 43:{colore == "rosso" && taglia == 43}");
            //verrà stampato false perché la taglia è quella sbagliata
            Console.WriteLine($"disponibile colore rosso e taglia 40:{colore == "rosso" && taglia == 40}");

            //or || (restituisce true se almeno una condizione viene rispettata)
            //verrà stampato true perché almeno una condizione viene rispettata
            Console.WriteLine($"disponibile colore rosso o blu:{colore == "rosso" || colore == "blu"}");
            //verrà stampato false perché nessuna condizione viene rispettata
            Console.WriteLine($"disponibile taglia 42 o 45:{taglia == 42 || taglia == 45}");

            //not ! (la condizione viene negata)
            //verrà stampato false perché entrambe le condizioni vengono rispettate ma il risultato viene negato 
            Console.WriteLine($"non disponibile colore rosso e taglia 43:{!(colore == "rosso" && taglia == 43)}");
            //verrà stampato true perché nessuna condizione viene rispettata ma il risultato viene negato 
            Console.WriteLine($"non disponibile taglia 42 o 45:{!(taglia == 42 || taglia == 45)}");
        }
    }
}