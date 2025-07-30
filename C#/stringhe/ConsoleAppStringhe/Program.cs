using System;

namespace ConsoleAppStringhe
{
    class Program
    {
        static void Main(string[] args)
        {
            //creazione stringa
            string stringa = "prova";

            //stampo il contenuto della stringa
            Console.WriteLine(stringa);

            //esempio di escape, \n per andare da capo e \" per far stampare il carattere speciale "
            string citazione = "citazione: \n\"Si vive una volta sola\"";

            /*
            la stringa che verrà stampata è
            citazione: 
            "Si vive una volta sola"
            */
            Console.WriteLine(citazione);

            string nome = "Antonio";
            string cognome = "Ciccarelli";

            //esempio di concatenazione, si usa il + per concatenare più stringhe
            string presentazione = "ciao sono " + nome + " " + cognome;

            //la stringa che verrà stampata sarà: ciao sono Antonio Ciccarelli
            Console.WriteLine(presentazione);

            //esempio di formattazione, usiamo {n} per stampare le variabili
            //senza chiudere la stringa
            //la stringa che verrà stampata sarà: salve sono Antonio Ciccarelli
            Console.WriteLine("salve sono {0} {1}", nome, cognome);

            //è inoltre possibile usare la formattazione su una stringa tramite string.Format
            string presentazione2 = string.Format("salve sono {0} {1}", nome, cognome);

            //esempio di interpolazione, scriviamo $ prima della stringa e dentro la stringa
            //mettiamo tra parentesi graffe i nomi delle variabili da stampare
            //la stringa che verrà stampata sarà: salve sono Antonio Ciccarelli
            Console.WriteLine($"buongiorno sono {nome} {cognome}");

            //esempio metodo toUpper(),tutti i caratteri di una stringa diventano maiuscoli
            //la stringa che verrà stampata sarà: SALVE SONO ANTONIO CICCARELLI
            Console.WriteLine(presentazione2.ToUpper());

            //esempio metodo toLower(),tutti i caratteri di una stringa diventano minuscoli
            //la stringa che verrà stampata sarà: salve sono antonio ciccarelli
            Console.WriteLine(presentazione2.ToLower());

            //esempio metodo Lenght, restituisce un numero intero che equivale
            //alla lunghezza della stringa
            //il numero stampato sarà 29
            Console.WriteLine(presentazione2.Length);

            //esempio di indexing, restituisce la lettera presente nella posizione indicata
            //il carattere restituito sarà s
            Console.WriteLine(presentazione2[0]);

            //esempio metodo IndexOf(), restituisce un numero intero che equivale a
            //la posizione del carattere indicato, in caso di più caratteri uguali 
            //restituisce la posizione del primo carattere trovato, se il carattere
            //non viene trovato restituisce -1
            //il numero stampato sarà 1
            Console.WriteLine(presentazione2.IndexOf('a'));

            //esempio metodo Substring(), restituisce una stringa partendo dalla
            //posizione indicata(si consiglia fortemente di guardare la documentazione)
            //la stringa che verrà stampata sarà: Antonio Ciccarelli
            Console.WriteLine(presentazione2.Substring(11));
        }
    }
}