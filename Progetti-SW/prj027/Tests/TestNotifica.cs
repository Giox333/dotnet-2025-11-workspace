using NUnit.Framework;


    public class TestNotifica
    {

        [Test]
        public void TestNotif()
        {
            Notifica notifica1 = new Notifica();
            System.Console.WriteLine(notifica1.Invia());
            Assert.That(notifica1.Invia(), Is.Not.EqualTo(null));

            notifica1.SegnaComeLetta();
            Assert.That(notifica1.Letta, Is.EqualTo(true));
        }

    }

