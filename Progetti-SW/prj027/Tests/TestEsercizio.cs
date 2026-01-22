using NUnit.Framework;


    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Codice da eseguire prima di ogni test
        }

        [Test]
        public void Test1()
        {
            Esercizio es1 = new Esercizio();
            var ris = es1.ToString();
            System.Console.WriteLine(ris);
            Assert.That(ris, Is.Not.EqualTo(null));

            Assert.That(es1.CalcolaCaricoLavoro(), Is.EqualTo(30));
            es1.VerificaDifficoltà(Livello.Intermedio);
            Assert.That(es1.Livello, Is.EqualTo(Livello.Intermedio));
            
            //string istruzioni = es1.GetIstruzioni();
            System.Console.WriteLine(es1.GetIstruzioni());
            Assert.That(es1.GetIstruzioni, Is.Not.EqualTo(null));
            
        }

    }

