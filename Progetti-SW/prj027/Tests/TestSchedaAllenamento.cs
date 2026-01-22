using NUnit.Framework;


public class TestSchedaAllenamento
{

    [Test]
    public void TestScheda()
    {
        System.Console.WriteLine("TEST SCHEDA ALLENAMENTO: ");
        SchedaAllenamento scheda1 = new SchedaAllenamento();
        scheda1.AggiungiEsercizio(new Esercizio());
        scheda1.AggiungiEsercizio(new Esercizio());

        Esercizio es1 = new Esercizio(1, "Spinte con manubri", "Spingere in alto e riportali alla posizione",
        10, 3, 60, "Spinte", Livello.Principiante);
        scheda1.AggiungiEsercizio(es1);

        System.Console.WriteLine(scheda1.ToString());
        Assert.That(scheda1.ToString(), Is.Not.EqualTo(null));

        scheda1.RimuoviEsercizio(es1);
        System.Console.WriteLine("\nEs rimosso: \n");
        System.Console.WriteLine(scheda1.ToString());
        Assert.That(scheda1.ToString(), Is.Not.EqualTo(null));

        var tot = scheda1.CalcolaDurataTotale();
        System.Console.WriteLine("Durata totale: " + tot);

        Assert.That(scheda1.GeneraReport(), Is.Not.EqualTo(null));
    }

}

