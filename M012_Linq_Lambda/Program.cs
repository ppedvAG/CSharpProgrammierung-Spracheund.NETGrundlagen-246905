namespace M012_Linq_Lamba;

public class Program
{
    static void Main(string[] args)
    {
        #region Einfaches Linq
        // IEnumerable
        // Beispiel Liste mit Daten
        IEnumerable<int> zahlen = Enumerable.Range(0, 1_000_000); // Eine Liste von 0 - 1,000,000 Range

        List<int> ints = Enumerable.Range(1, 20000).ToList();

        Console.WriteLine(ints.Average());
        Console.WriteLine(ints.Min());
        Console.WriteLine(ints.Max());
        Console.WriteLine(ints.Sum());

        Console.WriteLine(ints.First());
        Console.WriteLine(ints.Last());

        // Linq-Funktion
        // Suche das erste Element, welches durch 50 Teilbar ist
        Console.WriteLine(ints.FirstOrDefault(e => e % 50 == 0));

        #endregion

        #region Linq Mit Objekten

        // Linq mit Objekten
        List<Fahrzeug> fz = new List<Fahrzeug>()
        {
            new Fahrzeug(250, FahrzeugMarke.BMW),
            new Fahrzeug(350, FahrzeugMarke.Mercedes),
            new Fahrzeug(200, FahrzeugMarke.VW),
            new Fahrzeug(300, FahrzeugMarke.Audi),
            new Fahrzeug(170, FahrzeugMarke.Audi),
            new Fahrzeug(230, FahrzeugMarke.Mercedes),
            new Fahrzeug(150, FahrzeugMarke.VW),
            new Fahrzeug(650, FahrzeugMarke.VW),
            new Fahrzeug(320, FahrzeugMarke.Mercedes),
            new Fahrzeug(178, FahrzeugMarke.Audi),
            new Fahrzeug(243, FahrzeugMarke.BMW),
        };

        // Alle VWs finden
        List<Fahrzeug> vws = fz.Where(e => e.Marke == FahrzeugMarke.VW).ToList();

        #endregion

        // Alle VWS finden, welche mind. 220km/h fahren können
        fz.Where(e => e.Marke == FahrzeugMarke.VW && e.MaxV >= 220);

        // ODER (ist dasselbe wie oben)
        fz.Where(e => e.Marke == FahrzeugMarke.VW)
            .Where(e => e.MaxV >= 220);

        // OrderBy, OrderByDescending
        // Alle Fahrzeuge nach der Marke sortieren
        fz.OrderBy(e => e.Marke); // Aufsteigend
        fz.OrderByDescending(e => e.Marke);

        // Alle Fahrzeuge nach Marke, MaxV sortieren
        fz.OrderBy(e => e.Marke).ThenBy(e => e.MaxV);
        fz.OrderByDescending(e => e.Marke).ThenByDescending(e => e.MaxV);



    }
}

public class Fahrzeug
{
    public int MaxV;
    public FahrzeugMarke Marke;

    public Fahrzeug(int maxV, FahrzeugMarke marke)
    {
        MaxV = maxV;
        Marke = marke;
    }
}

public enum FahrzeugMarke
{
    Audi, BMW, VW, Mercedes
}