namespace ConsoleAppBreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            //esempio di break
            //break fa finire il ciclo, indipendentemente dalla sua condizione e dal tipo di ciclo (for, while ecc)
            //in questo caso il ciclo finisce anche se i non ha raggiunto 10 e quindi rispetta la condizione
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine($"i={i}");
            }

            //esempio di continue
            //continue fa saltare una iterazione e continua con quella successiva
            //nel nostro caso saltiamo le iterazioni se i è uguale ad un numero non divisibile per 2
            for (int i = 0; i < 21; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}