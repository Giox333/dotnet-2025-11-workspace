using System;
using static Persona;
using static Dog;
using static Phone;

class Program
{
    static void Main(string[] args)
    {
        /* Persona per = new Persona();
        per.mostraInformazioni();
        Persona pers2 = new Persona("Giovanni","Bronte",23);
        pers2.mostraInformazioni(); */

        /* Dog cane = new Dog();
        cane.Bark();
        Dog cane2 = new Dog("Gianni",2,"Labrador");
        cane2.Bark(); */

        Phone tel1 = new Phone();
        Phone tel2 = new Phone("Apple","11",100,true);
        /* System.Console.WriteLine(tel1.toString());

        //tel1.Prezzo > tel2.Prezzo ? tel1.Stampa() : tel2.Stampa;
        if(tel1.Prezzo > tel2.Prezzo)
        {
            tel2.Stampa();
        }
        else
        {
            tel1.Stampa();
        } */

        Store negozio = new Store();
        negozio.AddPhone(new Phone());
        negozio.AddPhone(tel1);
        negozio.AddPhone(tel2);

        

    }
}
