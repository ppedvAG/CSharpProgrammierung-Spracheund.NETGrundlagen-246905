namespace M007_GC_Static_ref;

public class Program
{
    static void Main(string[] args)
    {
        /*
            Warum wird beim Destruktor von einem Objekt nicht die Garbage Collection gegriffen?
            - Just in Time Compiler (JIT) => in manchen Fällen trägt er das Erste Objekt länger im System

            Warum?
            - Das erste Objekt hat noch eine aktive Referenz
            - Der GC arbeitet in sogenannte Generation (0, 1, 2)
                => 0 = niedrige Priorität
                => 1 = mittlerere Priorität
                => 2 = hohe Priorität
                    => Wir können das nicht beeinflussen
        */

        /* 
            Warum funktioniert das ganze dann in der Schleife?
            => Immer wenn ein neues Objekt erstellt wird -> das die "älteren" Objekte gleich von GC priorisiert werden => Löschen
            => Mehr Objekte => Mehr Speicher verbrauch => GC arbeitet schneller zur Bereinigung => Priorität höher angesetzt
          
        */

        /*
            Warum werden nicht alle Objekte aufeinmal gelöscht?
            => Finalizer-Queue (Warteschlange)
            => Finalizer arbeitet asynchron (Zeitgleich)
            => Löscht irgendwelche Objekte die schnell bereinigt werden können (Muss garnicht in der Reihenfolge sein)
        */

        // Person p1 = new Person("Philipp");
        for (int i = 0; i <= 5; i++)
        {
            Person p = new Person("Philipp");
            p = null;
        }
        // p1 = null;
        GC.Collect(); // Erzwinge eine Garbage Collection
        GC.WaitForPendingFinalizers(); // Wartet auf die Abarbeitung des Destruktors


        // Static Methode
        // Eine Methode als static deklariere, dann kann ich sie OHNE ein Objekt der Klasse aufrufen

        //Mathe m1 = new Mathe();
        //m1.Addieren(3, 4);

        int summe = Mathe.Addieren(3, 5);
        Console.WriteLine(summe);

        // Statisches Feld / Variable
        // Eine static-Variable wird von allen Objekten geteilt
        new Auto();
        new Auto();
        new Auto();
        Auto.AnzahlAutos += 1;
        Console.WriteLine(Auto.AnzahlAutos);

        // Statische Klasse
        // eine Static-Klasse kann nicht instanziiert werden (kein new möglich)
        // => eine Sammlung von statischen Methoden
        // Helfer h1 = new Helfer();
        Helfer.ZeigeText();


        int anzahl = 0;
        int ergebnis = 0;
        ergebnis = addiere(ergebnis, 3, ref anzahl);
        Console.WriteLine($"ergebnis = {ergebnis} anzahl = {anzahl}");

        ergebnis = addiere(ergebnis, 8, ref anzahl);
        Console.WriteLine($"ergebnis = {ergebnis} anzahl = {anzahl}");

        ergebnis = addiere(ergebnis, 45, ref anzahl);
        Console.WriteLine($"ergebnis = {ergebnis} anzahl = {anzahl}");

    }
    public static int addiere(int zahl1, int zahl2, ref int anzahlAdditionen)
    {
        int summe = zahl1 + zahl2;
        anzahlAdditionen += 1;

        return summe;
    }
}

public class Person
{
    public string Vorname { get; set; }

    public Person(string vorname)
    {
        Vorname = vorname;
    }

    ~Person() 
    {
        Console.WriteLine("Objekt wurde zerstört");
    }
}

class Mathe
{
    public static int Addieren(int a, int b) // => Static Methode
    {
        return a + b;
    }
}

class Auto
{
    public static int AnzahlAutos = 0;

    public Auto()
    {
        AnzahlAutos++; //Wird bei jedem neuen Objekt von Auto um 1 höher gesetzt
    }
}

static class Helfer // Wenn eine Klasse statisch ist => alle weiteren Eigenschaften/Methoden auch statisch
{
    public static void ZeigeText()
    {
        Console.WriteLine("Hello");
    }
}