// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
/*
Console.WriteLine("Hello, test 1!");

int x = 0;
int y = 1;
string message = "ciao ";
Console.WriteLine(message);

int a = Random.Shared.Next(0, 100);

int b = Random.Shared.Next(0, 100);
int c = Random.Shared.Next(0, 100);
int d = Random.Shared.Next(0, 100);

string msg = "I valori sono a= " + a + ";b= " + b + ";c= " + c + ";d= " + d + ";";
System.Console.WriteLine(msg);

msg = $"I valori sono a= {a}; b={b}; c={c}; d={d};";
System.Console.WriteLine(msg);

msg = $@"I valori sono 
        a={a}; 
        b={b}; 
        c={c}; 
        d={d};";

System.Console.WriteLine(msg);
*/
//

/* string es = @"
                *********
                *       *
                *               *
                *               *
                *               *
                *               *
                *               *
                *****************";

Console.WriteLine(es); */

using System;

static int Max(int[] A, int p, int r){
    if (p < r)
        return A[p];
    else
    {
        int q = ((p+r) / 2);
        int left = Max(A,p,q);
        int right = Max(A,q+1,r);
        if (left > right)
            return left;
        else
            return right;
    }
}

static void Main()
{
    int[] array = {1,2,3,47,3,7,34,3764,67,763,35,67,3756,87};

    Console.WriteLine(Max(array,1,array.Length));
}