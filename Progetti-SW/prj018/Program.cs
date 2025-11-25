namespace prj018;

class Program
{
    static void Main(string[] args)
    {
        /* int[] vet1 = {1,2,3,4,5,6,7};

        var vet2 = from numero in vet1
                    where numero %2 == 0
                    select numero; */
        string[] vet1 = { "aa", "bb", "asdasd", "aaaaaaa", "test" };
        var vet2 = from parole in vet1
                   where parole.Length > 5
                   select parole;
        foreach (var n in vet2)
        {
            System.Console.WriteLine(n);
        }
    }
}
