using NUnit.Framework;
using System;

public class NUnitTestItem1
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestUtente()
    {
        Utente user1 = new Utente();
        try
        {
            user1.AddPrenotazione(new Prenotazione("11111", DateTime.Today, new DateTime(2026, 1, 1), Prenotazione.StatoPrenotazione.attiva));
            user1.AddPrenotazione(new Prenotazione("22222", new DateTime(2010, 1, 2), DateTime.Today, Prenotazione.StatoPrenotazione.completata));
            user1.AddPrenotazione(new Prenotazione("3333", DateTime.Today, new DateTime(2026, 1, 1), Prenotazione.StatoPrenotazione.attiva));
        }
        catch (Exception e)
        {
            System.Console.WriteLine("Eccezzione trovata = " + e.Message);
        }

        string ris = user1.ToString();
        System.Console.WriteLine(ris);
        Assert.That(ris, Is.Not.EqualTo(null));
    }
    /* [Test]
    public void TestPrenotazione()
    {
        Prenotazione prenotazione1 = new Prenotazione();
        var ris = prenotazione1.ToString();
        Assert.That(ris, Is.Not.EqualTo(null));
    }
    [Test]
    public void TestLibro()
    {
        Libro libro1 = new Libro();
        var ris = libro1.ToString();
        System.Console.WriteLine(ris);
        Assert.That(ris, Is.Not.EqualTo(null));
    } */
    /* [Test]
    public void TestLibroApi()
    {
        string ricerca = Console.ReadLine();

        RetrieverManager manager = new RetrieverManager("cf49b87064mshbd15f06691e0c69p177397jsn3b686c354843");
        List<Root>? libro1 = manager.Search(ricerca);
        //System.Console.WriteLine(libro[0].ToString());

        Libro book1 = new Libro(libro1[0], Libro.Stato.disponibile, new Prenotazione());
        System.Console.WriteLine(book1.ToString());
    } */
}
