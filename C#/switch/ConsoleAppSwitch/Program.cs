namespace ConsoleAppSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //esempio di costrutto switch che stampa cattiverie gratuite in base all'età inserita
            int eta = 0;
            bool isValid = true;
            Console.WriteLine("Benvenuto, inserisci la tua età");
            try
            {
                eta = int.Parse(Console.ReadLine());
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException");
                isValid = false;
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
                isValid = false;
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverflowException");
                isValid = false;
            }
            if (isValid)
            {
                Console.WriteLine($"Hai {eta} anni");
                //creazione operatore switch switch che prende in considerazione eta
                switch (eta)
                {
                    case 0:
                        //se eta = 0 esegui queste istruzioni
                        Console.WriteLine("Benvenuto al mondo (chi te lo ha fatto fare?)");
                        break;  //termina lo switch e vai avanti col programma
                    case 18:
                        //se eta = 18 esegui queste istruzioni
                        Console.WriteLine("Sei diventato maggiorenne yeeeeee (mi dispiace)");
                        break;  //termina lo switch e vai avanti col programma
                    case 30:
                        //e così via, non ho voglia di scriverlo per tutti
                        Console.WriteLine("Complimenti per il traguardo (credo...)");
                        break;  //tanto si capisce
                    case 40:
                        Console.WriteLine("Passa in fretta il tempo (quanti capelli ti sono rimasti?)");
                        break;
                    case 50:
                        Console.WriteLine("Mezzo secolo che sei in vita, complimenti (hai ancora i capelli?\nSe si di che colore?)");
                        break;
                    case 60:
                        Console.WriteLine("Daje tutta, ancora in carreggiata (non investire nessuno però)");
                        break;
                    case 70:
                        Console.WriteLine("Ed eccoti qui (perché qui e non facebook?)");
                        break;
                    case 80:
                        Console.WriteLine("Bene, esisti da quasi un secolo (non dimenticare le medicine se vuoi superare il record)");
                        break;
                    case 90:
                        Console.WriteLine("Azz, stai ancora qua? (Ma complimenti, mica siamo 8 miliardi di noi, nono)");
                        break;
                    case 100:
                        Console.WriteLine("Wow ma sei ancora in vita? Complimenti");
                        break;
                }
                Console.WriteLine("Ok switch finito, vai via adesso");
            }
            else
            {
                Console.WriteLine("Età non valida");
            }
        }
    }
}