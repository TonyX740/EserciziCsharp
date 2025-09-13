namespace ConsoleAppArray
{
  class Program
  {
    static void Main(string[] args)
    {
      //esempio di array, un array è una variabile che contiene altre variabili
      string[] nomi = ["tony", "vix", "neon", "Sashi", "Stronkler", "Elly", "basta"];

      //il ciclo foreach viene usato per scorrere gli elementi dentro l'array nomi
      //in questo caso stiamo dicendo di eseguire un istruzione per ogni nome presente nell'array nomi
      foreach (string nome in nomi)
      {
        Console.WriteLine(nome);
      }

      //altro esempio di array, questo array è stato dichiarato ma non inizializzato
      int[] numeri = new int[5];
      bool isValid = true;
      Console.WriteLine($"Sommiamo {numeri.Length} numeri");
      for (int i = 0; i < numeri.Length; i++)
      {
        try
        {
          Console.WriteLine($"Inserisci il numero {i + 1} di {numeri.Length}:");
          numeri[i] = int.Parse(Console.ReadLine());
        }
        catch (ArgumentNullException)
        {
          Console.WriteLine("Errore: numero non inserito");
          isValid = false;
          break;
        }
        catch (FormatException)
        {
          Console.WriteLine("Errore: carattere inserito al posto del numero");
          isValid = false;
          break;
        }
        catch (OverflowException)
        {
          Console.WriteLine("Errore: numero troppo grande");
          isValid = false;
          break;
        }
      }
      if (isValid)
      {
        int totale = 0;
        foreach (int numero in numeri)
        {
          totale += numero;
        }
        Console.WriteLine($"Risultato finale:{totale}");
      }
      else
      {
        Console.WriteLine("Impossibile proseguire");
      }
    }
  }
}