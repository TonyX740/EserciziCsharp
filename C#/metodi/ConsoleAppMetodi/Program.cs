namespace ConsoleAppMetodi
{
  class Program
  {
    static void Main(string[] args)
    {
      //esempio di metodi
      int num1 = 0;
      int num2 = 0;
      bool isValid = true;
      //metodo Saluta richiede una stringa in ingresso
      Saluta("Tony");
      try
      {
        Console.WriteLine("Dammi il primo numero");
        num1 = int.Parse(Console.ReadLine());
      }
      catch (ArgumentNullException)
      {
        Console.WriteLine("Il valore non può essere vuoto");
        isValid = false;
      }
      catch (FormatException)
      {
        Console.WriteLine("Il valore non può essere un carattere o una stringa");
        isValid = false;
      }
      catch (OverflowException)
      {
        Console.WriteLine("Il valore è troppo grande");
        isValid = false;
      }
      if (isValid)
      {
        try
        {
          Console.WriteLine("Dammi il secondo numero");
          num2 = int.Parse(Console.ReadLine());
        }
        catch (ArgumentNullException)
        {
          Console.WriteLine("Il valore non può essere vuoto");
          isValid = false;
        }
        catch (FormatException)
        {
          Console.WriteLine("Il valore non può essere un carattere o una stringa");
          isValid = false;
        }
        catch (OverflowException)
        {
          Console.WriteLine("Il valore è troppo grande");
          isValid = false;
        }
        if (isValid)
        {
          //il metodo Somma richiede due interi in ingresso e restituisce un intero
          Console.WriteLine($"La somma di {num1} e {num2} è {Somma(num1, num2)}");
        }
      }
    }

    //il metodo Saluta prende in input una stringa e stampa a schermo un saluto in base al nome e all'ora
    static void Saluta(string nome)
    {
      DateTime date = DateTime.Now;
      int hour = date.Hour;
      if (hour <= 3)
      {
        Console.WriteLine($"Buona sera {nome}");
      }
      if (hour >= 4 && hour <= 12)
      {
        Console.WriteLine($"Buongiorno {nome}");
      }
      if (hour >= 13 && hour <= 17)
      {
        Console.WriteLine($"Buon pomeriggio {nome}");
      }
      if (hour >= 18)
      {
        Console.WriteLine($"Buona sera {nome}");
      }
    }

    //il metodo Somma prende in input due variabili intere e restituisce la somma dei numeri
    static int Somma(int n1, int n2)
    {
      return n1 + n2;
    }

    //esempio di method overloading, con l'overloading abbiamo metodi che hanno lo stesso nome ma signature
    //diversa (numero e/o tipo di parametri in ingresso)
    static int Somma(int n1, int n2, int n3)
    {
      return n1 + n2 + n3;
    }
  }
}