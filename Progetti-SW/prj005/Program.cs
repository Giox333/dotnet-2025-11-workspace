namespace prj005;

class Program
{
    static void Main(string[] args)
    {
        bool fine = true;
        while (fine)
        {
            Console.WriteLine(@"Scegli che esercizio stampare inserendo un numero da 1 a 4:
        1: Sommare i primi 100 numeri pari;
        2: Generare 100 numeri casuali e sommare i dispari;
        3: Generare 100 numeri casuali e se pari moltiplicare per 2, se dispari sottrare 10, calcolare la somma risultante;
        4: Generare 100 numeri casuali e sommare i dispari usando un ciclo che decrementa;
        5: Esci dal programma.");

            try{
            int scelta = Convert.ToInt32(Console.ReadLine());    
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Errore, carattere messo non valido, inserisci un numero");
            }
            Program p = new Program();
            switch (scelta)
            {
                case 1:
                    p.NumeriPari(); 
                    break;
                case 2:
                    p.SommaDispari();
                    break;
                case 3:
                    p.MoltiplicaPariSottraiDispari();
                    break;
                case 4:
                    p.SommaDispariDecrementato();
                    break;
                case 5:
                    Environment.Exit(123);
                    break;
                default:
                    Console.WriteLine("Numero inserito non valido, inserirne un altro");
                    break;
            }
        }
    }

    void NumeriPari()
    {
        int somma = 0;
        for (int i = 0; i < 100; i++)
        {
            if (i % 2 == 0)
            {
                somma = Sommare(somma,i);
            }
        }
        Console.WriteLine($"I primi 100 numeri pari sommati sono: {somma}\n");
    }

    void SommaDispari()
    {
        int somma = 0;
        for (int i = 0; i < 100; i++)
        {
            int numero = Random.Shared.Next(0, 20);
            if (numero % 2 != 0)
            {
                somma = Sommare(somma,numero);
            }
        }
        Console.WriteLine($"La somma di 100 numeri dispari generati casualmente è: {somma}\n");
    }

    void MoltiplicaPariSottraiDispari()
    {
        int somma = 1;
        for (int i = 0; i < 100; i++)
        {
            int numero = Random.Shared.Next(0, 20);
            if (numero % 2 == 0)
            {
                somma =  Sommare(somma,numero) * 2;
            }
            else
            {
                somma = Sommare(somma,-10);
            }
        }
        Console.WriteLine($"Il risultato finale è: {somma}\n");
    }

    void SommaDispariDecrementato()
    {
        int somma = 0;
        for (int i = 99; i >= 0; i--)
        {
            int numero = Random.Shared.Next(0, 20);
            if (numero % 2 != 0)
            {
                somma = Sommare(somma,numero);
            }
        }
        Console.WriteLine($"La somma di 100 numeri dispari generati casualmente, con ciclo decrementato, è: {somma}\n");
    }

    static int Sommare(int somma, int valore)
    {
        return somma + valore;
    }

}
