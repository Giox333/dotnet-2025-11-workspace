using NUnit.Framework;


public class TestPagamento
{

    [Test]
    public void TestPaga()
    {
        Pagamento pagamento1 = new Pagamento();
        var ris = pagamento1.ToString();
        System.Console.WriteLine(ris);
        Assert.That(ris, Is.Not.EqualTo(null));

        Pagamento pagamento2 = new Pagamento(2, new DateTime(2015, 1, 1), 100, "Contanti", false);
        pagamento2.EseguiPagamento();
        Assert.That(pagamento2.Pagato, Is.EqualTo(true));

        var ricevuta = pagamento2.GeneraRicevuta();
        Assert.That(ricevuta, Is.Not.EqualTo(null));

        Pagamento paga3 = new Pagamento(3, new DateTime(2015, 1, 1), 10, "Mastercard", false);
        paga3.EseguiPagamento();
        Assert.That(paga3.VerificaScadenzaPagamento, Is.EqualTo(true));
    }

}

