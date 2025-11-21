namespace _prj004;

class Program
{
    int x=0;
    static int sx=0;
    
    public static int Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        /* Environment.Exit(123);
        Console.WriteLine("tese");*/

        Program p = new Program();
        sx = 245;
        p.funzione();

        return 45;
    }

    private void funzione()
    {
        x = 123;

        sx = -77;

        Console.WriteLine("Test 2");
    }
}
