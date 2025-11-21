// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

//double v;
int pari=0, dispari=0;

for(int i=0; i<50; i++)
{
    double v = Random.Shared.Next(-100,100);
    if(v%2 == 0)
    {
        pari++;
    }
    else
    {
        dispari++;
    }
}

Console.WriteLine($"I numeri pari usciti sono:{pari}\tI numeri dispari sono:{dispari}");
*/

for (int j = 0; j < 10; j++)
{
    Console.Write("*");
}

for (int ce = 0; ce < 6; ce++)
{
    Console.Write("\n*");
    for (int ci = 0; ci < 8; ci++)
    {
        Console.Write(" ");
    }
    Console.Write("*");
}

Console.Write("\n");
for (int i = 0; i < 10; i++)
{
    Console.Write("*");
}