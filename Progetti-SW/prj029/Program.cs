using var db = new ApplicationDbContext();

db.Dvd.RemoveRange(db.Dvd.ToList());

db.Dvd.Add(new Dvd());
db.Dvd.Add(new Dvd("titolo1" , "genere1"));
db.Dvd.Add(new Dvd("Infinite Hyperdeath" , "ultrakill"));


//salvare i cambiamenti

db.SaveChanges();