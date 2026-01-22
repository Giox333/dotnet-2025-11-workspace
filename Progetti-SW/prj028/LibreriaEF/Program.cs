using Microsoft.EntityFrameworkCore;
using LibreriaEF.Data;
using LibreriaEF.Models;

class Program
{
    static async Task Main(string[] args)
    {
        System.Console.WriteLine("==== GESTIONE LIBRERIA ====");

        using var db = new ApplicationDbContext();

        await db.Database.EnsureCreatedAsync();
        System.Console.WriteLine("Database Pronto!");

        bool continua = true;
        while (continua)
        {
            System.Console.WriteLine(@"==== MENU ====
            1. Visualizza libri
            2. Aggiungi un libro
            3. Cerca un libro
            4. Esci
            Scelta:");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    await VisualizzaLibri(db);
                    break;
                case 2:
                    await AggiungiLibro(db);
                    break;
                case 3:
                    await CercaLibro(db);
                    break;
                case 4:
                    continua = false;
                    break;
                default:
                    System.Console.WriteLine("Scelta non valida, inserisci un numero");
                    break;
            }
        }
    }
    static async Task VisualizzaLibri(ApplicationDbContext db)
    {
        var libri = await db.Libri
            .Include(l => l.Autore)
            .ToListAsync();

        Console.WriteLine("\n=== LIBRI IN CATALOGO ===");
        foreach (var libro in libri)
        {
            Console.WriteLine($"{libro.Titolo} - {libro.Autore?.NomeCompleto} - €{libro.Prezzo}");
        }
    }
    static async Task AggiungiLibro(ApplicationDbContext db)
    {
        Console.Write("Titolo: ");
        var titolo = Console.ReadLine();

        Console.Write("ISBN: ");
        var isbn = Console.ReadLine();

        Console.Write("Prezzo: ");
        var prezzo = decimal.Parse(Console.ReadLine());

        var libro = new Libro
        {
            Titolo = titolo,
            ISBN = isbn,
            Prezzo = prezzo
        };

        db.Libri.Add(libro);
        await db.SaveChangesAsync();

        Console.WriteLine($"Libro '{titolo}' aggiunto!");
    }

    static async Task CercaLibro(ApplicationDbContext db)
    {
        Console.Write("Cerca titolo: ");
        var ricerca = Console.ReadLine();

        var libri = await db.Libri
            .Where(l => l.Titolo.Contains(ricerca))
            .Include(l => l.Autore)
            .ToListAsync();

        Console.WriteLine($"\nTrovati {libri.Count} libri:");
        foreach (var libro in libri)
        {
            Console.WriteLine($"- {libro.Titolo}");
        }
    }
}