namespace prj008;

class Program
{
    static void Main(string[] args)
    {
        //es 1
        /* int somma = 0;
        System.Console.WriteLine("Inserisci i numeri con cui vuoi sommare");
        int numero = int.Parse(Console.ReadLine());
        while (numero!=0)
        {
            somma += numero;
            System.Console.WriteLine($"Somma: {somma}\n");
            numero = int.Parse(Console.ReadLine());
        }
        System.Console.WriteLine($"Somma finale: {somma}"); */

        //es 2
        /* int[] vet = {3,10,518,3,9,41,2,74,5,1,10};
        int min=100000, max=0, somma=0, conta=0;
        foreach(int elemento in vet)
        {
            if(min> elemento)
            {
                min = elemento;
            }else if(max< elemento){
                max = elemento;
            }
            somma += elemento;
            conta++;
        }
        System.Console.WriteLine($"Min: {min}, Max: {max}, Media{somma/conta}"); */

        //es 3
        /* bool[] vet = {false, true, true, true, true};
        bool flag=true;
        foreach(bool elemento in vet)
        {
            if(!elemento)
            {
                flag = false;
                break;
            }
        }
        System.Console.WriteLine(!flag ? "No" : "Si"); */


        //es4

        /* bool[] vet = {false, false, false, false, true};;
        for(int i=0; i < vet.Length; i++)
        {
            if (vet[i])
            {
                vet[i] = false;
                System.Console.WriteLine($"La prima posizione libera è:{i+1}");
                break;
            }
        } */

        //es 5
        /* int[] vet = {0,2,3,4,5};
        int max=0;
        bool flag = true;
        foreach(var elemento in vet)
        {
            if(elemento < max)
            {
                flag = false;
                break;
            }
            else
            {
                max = elemento;
            }
        }
        System.Console.WriteLine(!flag ? "No" : "Crescente"); */

        //es 6 
        /* System.Console.WriteLine("Inserisci il numero di numeri da inserire");
        int numero = int.Parse(Console.ReadLine());
        while(numero <= 0)
        {
            System.Console.WriteLine("Inserisci il numero di numeri da inserire");
            numero = int.Parse(Console.ReadLine());
        }
        int[]vet =new int[numero];
        for(int i=0; i< numero; i++)
        {
            System.Console.WriteLine($"Inserisci il valore {i}");
            vet[i] = int.Parse(Console.ReadLine());
        }
        foreach(var elemento in vet)
        {
            System.Console.Write($"{elemento}, ");
        } */

        //es7
        /* int[] vet = {10,2,44,6,30,46,67,5434,45};
        int somma=0;
        for(int i=0; i < vet.Length; i += 2)
        {
            if(vet[i]%2 == 0)
            {
                somma += vet[i];
            }
        }
        System.Console.WriteLine($"La somma è: {somma}"); */

        //es8
        int[] vet = { 1, 1, 1, 4, 23, 1, 45, 32, 1 };
        System.Console.WriteLine("Inserisci il numero da trovare");
        int numero = int.Parse(Console.ReadLine());
        int conta = 0;
        bool[] contaVet = new bool[vet.Length];
        for (int i = 0; i < vet.Length; i++)
        {
            if (vet[i] == numero)
            {
                contaVet[i] = true;
                conta++;
            }
        }
        System.Console.WriteLine($"Il numero è stato trovato {conta} volte\nÈ stato trovato nelle posizioni:");
        for(int j=0; j < contaVet.Length; j++)
        {
            if (contaVet[j])
            {
                System.Console.Write($"{j}, ");
            }
        }

    }
}