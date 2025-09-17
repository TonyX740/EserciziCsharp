namespace ConsoleAppMatrix
{
  class Program
  {
    static void Main(string[] args)
    {
      //esempio di matrice, la matrice è un array con due dimensioni,
      //di base è un array di array 

      string[,] nomi = {
        {"0","1","2","3","4","5","6","7"},
        {"tony", "vix", "neon", "Sashi", "Stronkler", "Elly", "Rolling","basta"}
       };

      Console.WriteLine("Ecco che succede se scorriamo una matrice tramite foreach");
      //se la scorriamo tramite foreach mostra prima tutta la prima dimensione e
      //poi tutta la seconda (e così via in caso di terza e passa dimensione)
      foreach (string nome in nomi)
      {
        Console.WriteLine(nome);
      }

      Console.WriteLine("Invece tramite il for classico abbiamo più controllo");
      //in questo caso scorre sempre tutta la prima dimensione e poi la seconda,
      //però stampiamo a schermo anche in quali righe e colonne ci troviamo
      for (int row = 0; row < nomi.GetLength(0); row++)
      {
        for (int col = 0; col < nomi.GetLength(1); col++)
        {
          Console.WriteLine($"Riga:{row}|Colonna:{col}");
          Console.WriteLine($"Risultato :{nomi[row, col]}");
        }
      }
    }
  }
}