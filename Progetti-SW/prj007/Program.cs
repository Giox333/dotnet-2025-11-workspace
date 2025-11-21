namespace prj007;

class Program
{
    static void Main(string[] args)
    {
        bool fine = true;
        double numero=0;
        while (fine)
        {
            System.Console.WriteLine("Inserisci un numero per la tabellina");
            try
            {
                numero = int.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("Carattere inserito non valido");
                break;
            }

            for(int i=0; i<11; i++)
            {
                System.Console.WriteLine($"{numero} * {i} = {numero*i}");
            }
        }
    }
}
