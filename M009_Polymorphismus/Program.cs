namespace M009_Polymorphismus;
public class Program
{
    static void Main(string[] args)
    {
        // Polymorphismus
        // -> Typkompatibilität
        // Welche Klassentypen passen mit welchen anderen Typen zusammen

        // Jeder Typ ist immer mit seiner Oberklasse (basisklasse) kompatibel
        Lebewesen lw = new Mensch("Max", 30);
        lw.Bewegen(50); // => Override nutzt die Mensch.Bewegen() Methode obwohl wir Lebewesen.Methode() aufrufen
        // lw.TestMethode(); // Der Mensch kann nur das Nutzen was in Lebewesen ist Eigenschaften, Methoden

        // Lebewesen kann nicht in ein Mensch umgewandelt werden
        //  Mensch m = new Lebewesen(30);

        // lw = Mensch   mit       Mensch vergleichen
        if (lw.GetType() == typeof(Mensch))
        {
            Console.WriteLine("True\n");
        }

        // lw = Mensch   mit      Lebewesen vergleichen
        if(lw.GetType() == typeof(Lebewesen))
        {
            Console.WriteLine("False");
        }

        Lebewesen lebewesen_Variablen_Objekt = new Lebewesen(20);
        Mensch mensch_Variablen_Objekt = new Mensch("Peter", 20);

        if(lebewesen_Variablen_Objekt is Lebewesen)
            Console.WriteLine("True");
        if(lebewesen_Variablen_Objekt is Mensch)
            Console.WriteLine("False");
        if(mensch_Variablen_Objekt is Lebewesen)
            Console.WriteLine("True");
        if(mensch_Variablen_Objekt is Mensch)
            Console.WriteLine("True");
        if(mensch_Variablen_Objekt is object)
            Console.WriteLine("True");

        // GetType()
        // Gibt den Typen hinter einem Objekt zurück (welches an der Variable hängt)
        // GetType() kann bei jedem beliebigen Objekt verwendet werden (variable)
        lebewesen_Variablen_Objekt.GetType();
        Console.WriteLine(lebewesen_Variablen_Objekt.GetType()); // M009.Polymorphismus.Lebewesen

        //typeof()
        // Gibt den Typen hinter einem Namen zurück (Klassenname, Structname, Enumname etc...)
        // Funktioniert nicht bei variablennamen
        Type type = typeof(Lebewesen);
        Console.WriteLine(type);
    }
}