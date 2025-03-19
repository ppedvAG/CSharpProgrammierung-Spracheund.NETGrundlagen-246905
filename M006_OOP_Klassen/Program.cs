using M006_OOP_Klassen.Data;

namespace M006_OOP_Klassen;

/*
    Klassen und Objekte
    
    Objekte sind Datenstrukturen, welche Daten halten
    Jedes Objekt kommt von einer Klasse
    Die Klasse hinter dem Objekt gibt den Aufbau des Objektes vor

    Die Klasse ist ein Bauplan für Objekte. In der Klasse werden nur Definitionen angelegt

    WICHTIG: In der Klasse selber werden keine Konkreten Werte definiert
    Aus der Klasse können beliebig viele Objekte definiert werden
    Die konkreten Werte werden in den Objekten definiert
    
    Objekt p1: [25J, Max, Mustermann]
    Objekt p2: [20J, Udo, Mustermann]
 
*/

internal class Program
{
    static void Main(string[] args)
    {
        // Objekt erstellen mithilfe des new-Keywords
        Person p1 = new Person("Max", "Mustermann");


        Console.WriteLine($"{p1.GetVorname()} {p1.nachnamen}");

        Person p2 = new Person();

        p2.SetVorname("Udo");
        p2.nachnamen = "Mustermann";
        p2.alter = 20;

        Console.WriteLine($"{p2.GetVorname()} {p2.nachnamen} ist {p2.alter} Jahre alt.");

        // Neues Schulung Objekt
        Schulung s = new Schulung(p2, "Burghausen", Schulungstyp.Hybrid, 4, "C# Grundkurs", p2, p1);
        Person p3 = new Person("Tobi", "Mustermann");
        Person p4 = new Person();
        p4.SetVorname("Klaus");
        p4.nachnamen = "Maier";
        s.NeueTeilnehmerHinzufuegen(p3, p4);

        Console.WriteLine($"Der Trainer: {s.Trainer.GetVorname()} {s.Trainer.nachnamen}, der Ort: {s.Standort}, die Teilnehmer: {s.Teilnehmer[1].GetVorname()} {s.Teilnehmer[1].nachnamen}");
        /*
        [0] = Max Mustermann
        [1] = Udo Mustermann
        [2] = Tobi Mustermann
        [3] = Klaus Maier
        */


        foreach(Person teilnehmer in s.Teilnehmer)
        {
            Console.WriteLine($"{teilnehmer.GetVorname()} {teilnehmer.nachnamen}");
        }

        /*
         * Erstell mal eine Klasse Auto:
         * Eigenschaften: Marke, Modell { get; set; }
         * Feld: Türen => Set-/Getmethoden:
         * Konstruktor: Standard + einen der Marke, Modell & Türen setzt
         * Erstellst du ein Objekt: 
         * Marke: VW, Modell: Golf VI, Türen: 5
         */
        
    }
}