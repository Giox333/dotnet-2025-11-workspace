using NUnit.Framework;


public class TestCorso
{

    [Test]
    public void TestCorso1()
    {
        Corso corso1 = new Corso();
        System.Console.WriteLine("TEST CORSO: ");
        System.Console.WriteLine(corso1.ToString());
        Assert.That(corso1.ToString(), Is.Not.EqualTo(null));

        Assert.That(corso1.VerificaDisponibilità(), Is.EqualTo(true)); 
        corso1.AggiungiPartecipante(new PartecipazioneCorso());
        corso1.AggiungiPartecipante(new PartecipazioneCorso());

        System.Console.WriteLine(corso1.ToString());
        Assert.That(corso1.ToString(), Is.Not.EqualTo(null));
               
        //da finire
    }

}

