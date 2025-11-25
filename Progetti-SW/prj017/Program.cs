namespace prj017;

class Program
{
    static void Main(string[] args)
    {
        /* VeicoloAMotore veicolo1 = new VeicoloAMotore();
        System.Console.WriteLine(veicolo1.ToString());
        System.Console.WriteLine(veicolo1.Marca);

        Furgone furgone1 = new Furgone();
        System.Console.WriteLine(furgone1.ToString());

        Automobile auto1 = new Automobile();
        System.Console.WriteLine(auto1.ToString());

        Motocicletta moto1 = new Motocicletta();
        System.Console.WriteLine(moto1.ToString());

        Garage garage1 = new Garage();
        garage1.ImmettiNuovoVeicolo(furgone1);
        garage1.ImmettiNuovoVeicolo(auto1);
        garage1.ImmettiNuovoVeicolo(moto1);
        garage1.StampaSituazionePosti();
        VeicoloAMotore v2 =  garage1.EstraiVeicolo(1);
        System.Console.WriteLine("\n" + v2.ToString());
        garage1.StampaSituazionePosti(); */
        bool fine = true;
        int scelta = 0;
        Garage garage = new Garage();
        while (fine)
        {
            System.Console.WriteLine(@"Seleziona un operazione da fare:
            1: Aggiungi un veicolo
            2: Rimuovi un veicolo
            3: Stampa i veicoli
            4: Esci dal programma");
            try
            {
                scelta = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Errore, carattere messo non valido, inserisci un numero");
            }
            switch (scelta)
            {
                case 1:
                    System.Console.WriteLine("Inserisci l'anno di Immatricolazione");
                    int anno = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Inserisci la marca");
                    string marca = Console.ReadLine();
                    System.Console.WriteLine("Inserisci l'alimentazione");
                    string alimentazione = Console.ReadLine();
                    System.Console.WriteLine("Inserisci la cilindrata");
                    int cilindrata = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Inserisci il tipo di veicolo:1 = furgone, 2 = automobile, 3 = Motocicletta");
                    int tipo = int.Parse(Console.ReadLine());
                    switch (tipo)
                    {
                        case 1:
                            System.Console.WriteLine("Inserisci la capacità di carico");
                            int carico = int.Parse(Console.ReadLine());
                            garage.ImmettiNuovoVeicolo(new Furgone(anno, marca, alimentazione, cilindrata, carico));
                            break;
                        case 2:
                            System.Console.WriteLine("Inserisci il numero di Porte");
                            int porte = int.Parse(Console.ReadLine());
                            garage.ImmettiNuovoVeicolo(new Automobile(anno, marca, alimentazione, cilindrata, porte));
                            break;
                        case 3:
                            System.Console.WriteLine("Inserisci il tipo di moto");
                            string tipoMoto = Console.ReadLine();
                            System.Console.WriteLine("Inserisci il numero di tempi motore");
                            int tempiMotore = int.Parse(Console.ReadLine());
                            garage.ImmettiNuovoVeicolo(new Motocicletta(anno, marca, alimentazione, cilindrata, tipoMoto, tempiMotore));
                            break;
                        default:
                            System.Console.WriteLine("Valore immesso non valido, scegli uno tra quelli scritti");
                            break;
                    }
                    break;
                case 2:
                    System.Console.WriteLine("Inserisci la posizione da dove vuoi togliere il veicolo");
                    int posizione = int.Parse(Console.ReadLine());
                    //VeicoloAMotore veicolo = garage.EstraiVeicolo(posizione);
                    System.Console.WriteLine("Veicolo rimosso: " + garage.EstraiVeicolo(posizione));
                    break;
                case 3:
                    garage.StampaSituazionePosti();
                    break;
                case 4:
                    Environment.Exit(123);
                    break;
                default:
                    System.Console.WriteLine("Valore immesso non valido, inserisci un valore tra 1 e 4");
                    break;
            }
        }
    }
}
