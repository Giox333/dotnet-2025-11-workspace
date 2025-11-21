namespace prj006;

class Program
{
    static void Main(string[] args)
    {
        bool fine=true;
        long numero=0;
        while (true)
        {
            System.Console.WriteLine("Inserisci un numero");

            try
            {
                numero = int.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("Errore: carattere inserito non valido, inserisci un numero\n");
            }

            /* if(numero % 2 == 0)
            {
                System.Console.WriteLine("Il numero è pari\n");
            }
            else
            {
                System.Console.WriteLine("Il numero è dispari\n");
            } */

            //altra opzione usando operatore ternario
            /*string ris = numero % 2 == 0 ? "Numero pari" : "Numero dispari";
            System.Console.WriteLine(ris);
            */
            System.Console.WriteLine(numero % 2 == 0 ? "Numero pari" : "Numero dispari");

        }
    }
}
