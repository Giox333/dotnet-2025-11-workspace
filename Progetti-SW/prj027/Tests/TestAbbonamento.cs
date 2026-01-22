using NUnit.Framework;


public class TestAbbonamento
{

    [Test]
    public void TestAbbona()
    {
        Abbonamento abbonamento1 = new Abbonamento();
        var ris = abbonamento1.ToString();
        System.Console.WriteLine("\nTEST ABBONAMENTO:");
        System.Console.WriteLine(ris);
        Assert.That(ris, Is.Not.EqualTo(null));

        /* try
        {
            Abbonamento abbonamento2 = new Abbonamento(2, TipoAbbonamento.Base, DateTime.Today, new DateTime(2016, 1, 1), 100, new Pagamento());
            Abbonamento abbonamento3 = new Abbonamento(3, TipoAbbonamento.Premium, new DateTime(2016, 1, 1), new DateTime(2018, 1, 1), 200, new Pagamento());        
        }
        catch(Exception ex)
        {
            System.Console.WriteLine("Eccezione catturata: " + ex.Message);
        } */
        Abbonamento abbonamento2 = new Abbonamento(2, TipoAbbonamento.Base, DateTime.Today, new DateTime(2016, 1, 1), 100, new Pagamento());
        Abbonamento abbonamento3 = new Abbonamento(3, TipoAbbonamento.Premium, new DateTime(2016, 1, 1), new DateTime(2025, 12, 10), 200, new Pagamento());  

        Assert.That(abbonamento2.IsScaduto(), Is.EqualTo(true));
        Assert.That(abbonamento1.IsScaduto(), Is.EqualTo(false));

        System.Console.WriteLine("Giorni Rimanenti : " + abbonamento3.CalcolaGiorniRimanenti());
        Assert.That(abbonamento3.CalcolaGiorniRimanenti(), Is.EqualTo(8));
        
        abbonamento1 = abbonamento1.Rinnova();
        System.Console.WriteLine("\nAbbonamento rinnovato: ");
        System.Console.WriteLine(abbonamento1.ToString());
        Assert.That(abbonamento1.ToString(), Is.Not.EqualTo(null));
        
    }

}

