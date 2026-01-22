/* RetrieverManager manager = new RetrieverManager("cf49b87064mshbd15f06691e0c69p177397jsn3b686c354843");
var anime = manager.Search();
//System.Console.WriteLine(libro[0].ToString());


using var db = new ApplicationDbContext();
//db.Anime.RemoveRange(db.Anime.ToList());

foreach (var a in anime)
    db.Anime.Add(a); */
using var db = new ApplicationDbContext();

List<Root> stampaAnime = db.Anime.ToList();
StreamWriter sw = new StreamWriter("Anime.txt");

foreach (var a in stampaAnime)
{
    if (a != null)
        sw.WriteLine(a.ToString());
}

//salvare i cambiamenti

db.SaveChanges();