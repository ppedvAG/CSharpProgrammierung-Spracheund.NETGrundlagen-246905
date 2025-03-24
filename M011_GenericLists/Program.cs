namespace M011_GenericLists;

// Generische Listen

// Platzhalter für ein konkreten Datentyp
// Platzhalter wird mit "T" bezeichnet
// Wenn hier ein Typ genommen wird, wird er mit T ersetzt
public class Program
{
    static void Main(string[] args)
    {
        // List
        // Kann eine beliebige Menge an Daten halten (flexibel)
        // Der generische Datentyp, in der spitzen Klammer, gibt den Datentyp der Liste an
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);

        // Liste iterieren
        foreach(int i in list)
        {
            Console.WriteLine($"Listelemnt: {i}");
        }

        // Index wie bei Array
        Console.WriteLine(list[1]);

        if(list.Contains(1))
        {
            Console.WriteLine("Es enthält die 1");
        }

        // String Liste
        List<string> strings = new List<string>();
        strings.Add("A");
        strings.Add("B");
        strings.Add("C");
        strings.Add("D");
        strings.Add("E");

        foreach(string s in strings)
        {
            Console.WriteLine($"StringListe: {s}");
        }

        // Stack
        Stack<string> stacking = new Stack<string>();
        stacking.Push("A"); // Element eintragen
        stacking.Peek(); // oberste Element ausgeben
        stacking.Pop(); // oberste Element ausgeben & danach löschen

        Queue<string> queue = new Queue<string>();
        queue.Enqueue("A"); // Element hinzufügen
        queue.Peek(); // älteste Element ausgeben
        queue.Dequeue(); // älteste Element aus & lösche es

        // Dictionary
        // Liste von Schlüssel-Wert-Paaren
        // Jeder Schüssel hat einen angehängten Wert
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(1, "Wien");
        dictionary.Add(2, "Berlin");
        dictionary.Add(3, "Paris");
        dictionary.Add(4, "Berlin");

        // WICHTIG!: Schlüssel müssen eindeutig sein!
        // Es dürfen keine doppelten Keys vorhanden!!!

        // Alle Key, Value Pairs ausgeben
        foreach(KeyValuePair<int, string> pair in dictionary)
        {
            Console.WriteLine($"Der Schlüssel: {pair.Key} hat als Wert {pair.Value}.");
        }

        if(dictionary.ContainsValue("Berlin"))
        {
            Console.WriteLine($"{dictionary.Keys} {dictionary.Values}");
        }

        foreach (KeyValuePair<int, string> pair in dictionary)
        {
            
            if(dictionary.ContainsValue("Berlin"))
            {
                Console.WriteLine($"Wir haben den Wert {pair.Key} {pair.Value}");
                Console.WriteLine("True");
            }
        }

        Console.WriteLine(dictionary[0]);
    }
}