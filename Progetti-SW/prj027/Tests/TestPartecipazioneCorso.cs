using NUnit.Framework;


public class TestPartecipazioneCorso
{

    [Test]
    public void TestPartecipa()
    {
        PartecipazioneCorso partecipazione1 = new PartecipazioneCorso();
        System.Console.WriteLine(partecipazione1.ToString());
        Assert.That(partecipazione1.ToString(), Is.Not.EqualTo(null));

        partecipazione1.RegistraPresenza();
        Assert.That(partecipazione1.Presente, Is.Not.EqualTo(false));        
    }

}

