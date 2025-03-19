// Funktionen
// Code in Blöcken ablegen und das Mehrmals verwenden

// Aufbau:
// <Modifier> <Rückgabewert> <Namen>(<Par1>, <Par2>) { Anweisung... }

// Modifier:
// Verschiedene Keywords, welche die Funktion beeinflussen
// Beispiele: Acces Modifier (public, private, internal, protected), static, async, ref, extern, sealed, abstract

// Rückgabewert:
// Jede Funktion kann ein Ergebnis, das wird per Return zurückgeben
// Das Ergebnis kann im Anschluss auch in eine Variable geschrieben werden und weiterverwendet werden
// void: kein Return

// Name
// Über den Namen können wir Funktionen aufrufen
// Funktionen in C# immer groß geschrieben beim Anfangsbuchstaben (Camel-Case)
// bsp: addierenundsubtrahieren => AddierenUndSubtrahieren (Camel-Case Variante)

// Parameter:
// Geben vor, welche Daten die Funktion erwartet, wenn sie ausgeführt werden soll
// Jeder Parameter benötigt IMMER ein Typen und einen Namen (wie variablen)

// Funktion-Body
// Um den Code in der Funktion auszuführen
// Kann auf die Parameter zugreifen
// Kann ein ergebnis per return-Keyword zurückgeben

internal class Program
{
    private static void Main(string[] args)
    {
        int s = Addiere(4, 10);
        Console.WriteLine($"Die Summe ist: {s}");

        double dZahl = Addiere(3.0, 3.5, 5.7);
        Console.WriteLine($"Die Summe ist: {dZahl}");

        double zwei = Addiere(s, s);
        Console.WriteLine($"Die Summe ist {zwei}");

        int[] zahl = [2, 8, 16];
        Addiere(zahl);
        Console.WriteLine(Addiere(zahl));

        Subtrahiere();
        Subtrahiere(4, 9); // c bleibt 0
        Subtrahiere(c: 10, a: 2); // b überspringen, b bleibt 0


        int quo;
        int res;
        Teile(10, 3, out quo, out res);
        Console.WriteLine($"Der Quotient: {quo}, Rest: {res}"); // Ausgabe: Quotient: 3, Rest: 1


        // TryParse gibt einen bool zurück, dieser sagt aus ob das Parsen funktioniert hat oder nicht
        int ergebnis; // Hier oben muss eine Variable definiert werden, welche über das Ergebnis (bei Erfolg) aufgreift
        bool funktioniert = int.TryParse("123", out ergebnis); // Über out Ergebnis wird der Paramter mit der Variable verbunden
        if(funktioniert )
        {
            Console.WriteLine($"Zahl: {ergebnis}");
        } else
        {
            Console.WriteLine($"Parsen hat nicht funktioniert");
        }

    }

    // Funktion: welche Zwei zahlen empfängt diese Addiert + das ganze ausgibt und zurückgibt

    public static int Addiere(int z1, int z2)
    {
        int summe = z1 + z2;
        Console.WriteLine($"{z1} + {z2} = {summe}");
        return summe;
    }

    // Überladung von Funktionen
    // Denselben Funktionsnamen mehrmals
    // Hierbei müssen sich die Parameter unterscheiden (Datentyp oder Parameteranzahl)

    // 1. Anderer Datentyp
    public static double Addiere(double z1, double z2)
    {
        double summe = z1 + z2;
        Console.WriteLine($"{z1} + {z2} = {summe}");
        return summe;
    }
    // 2. Parameteranzahl
    public static double Addiere(double z1, double z2, double z3)
    {
        double summe = z1 + z2 + z3;
        Console.WriteLine($"{z1} + {z2} + {z3} = {summe}");
        return summe;
    }

    // params
    // Ermöglicht, beliebig viele Parameter an die Funktion zu übergeben
    // Innerhabl der Funktion ist der Params-parameter ein Array
    // Jede Funktion kann nur EINEN Params-Parameter haben
    public static int Addiere(params int[] zahlen)
    {
        return zahlen.Sum();
    }

    // default Werte / optionale Parameter
    // Parameter mit einer Vorbelegung, diese kann überschrieben werden
    public static int Subtrahiere(int a = 0, int b = 0, int c = 0)
    {
        int summe = a - b - c;
        Console.WriteLine(summe);
        return summe;
    }

    // out-Parameter (RÜckgabe mehrerer Werte)
    // Mit out kann eine Methode mehrere Werte zurückgeben, indem sie Varaiblen "nach außen" beschreibt
    public static void Teile(int zahl, int divisor, out int quotient, out int rest)
    {
        quotient = zahl / divisor;
        rest = zahl % divisor;
    }
}