using Newtonsoft.Json;
using System.Diagnostics;
using System.Xml.Serialization;

namespace M014_Dateien;

public class Program
{
    static void Main(string[] args)
    {
        // Grundlegende Klassen
        // Path, Dircetory, File

        // 1. Pfad + Ordner erstellen
        // Pfade werden als Strings dargestellt
        string folderPath = "Test";
        if(!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }

        // 2. Pfad zur Datei + Datei erstellen
        string filePath = Path.Combine(folderPath, "Test.txt");
        File.WriteAllText(filePath, "Hallo Welt");


        // Stream
        // Byte für Byte Daten schreiben/lesen
        
        // Streamwriter
        // Datei beschreiben
        StreamWriter writer = new StreamWriter(filePath);
        writer.Write("Hallo");
        writer.Write("Welt");

        // Streams sind Pipes, haben einen Buffer
        // Diesen Buffer niederschreiben
        writer.Flush(); // Flush() schreibt Buffer in das File
        writer.Close(); // Die Close() Methode gibt den Zugriff auf das File wieder frei

        // StreamReader
        // Stream lesen
        StreamReader reader = new StreamReader(filePath);
        List<string> lines = new List<string>();
        while (!reader.EndOfStream) 
        {
            // Ließt alles aus der Datei und speichert des in eine Liste
            lines.Add(reader.ReadLine());
        }
        foreach (var i in lines)
        {
            Console.WriteLine(i);
        }
        reader.Close();

        // using-Block
        // Am Ende des Blocks wird der Stream automatisch geschlossen
        using(StreamWriter sw = new StreamWriter(filePath))
        {
            sw.WriteLine("Hallo2");
            sw.WriteLine("Welt2");
        }

        // JSON & XML
        // Serialisierungsformate brauchen wir, wenn wir mit mehreren Geräten/Anwendungen kommunizeren wollen

        // JSON
        // In C# 2 große JSON Frameworks
        // System.Text.JSON (intern)
        // Newtonsoft.Json (extern)

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

        // Pfad öffnen, datei erstellen
        string jsonPath = Path.Combine(folderPath, "Test.json");

        JsonSerializerSettings options = new JsonSerializerSettings(); // Optionen setzen, beim schreiben/esen von JSON
        options.Formatting = Newtonsoft.Json.Formatting.Indented; // JSON Schön schreiben

        // Schreibe mir die Fahrzeug Liste mit den Optionen in das JSON mit dem JSON-Path
        string json = JsonConvert.SerializeObject(fz, options); // Wichtig!, Optionen mitgeben
        File.WriteAllText(jsonPath, json);

        // XML
        string xmlPath = Path.Combine(folderPath, "Test.xml");

        XmlSerializer xml = new XmlSerializer(fz.GetType());

        using(StreamWriter xmlWriter = new StreamWriter(xmlPath))
        {
            xml.Serialize(xmlWriter, fz);
        }
    }
}
// Für Debuggen
[DebuggerDisplay("Fahrzeug - Marke: {Marke}, MaxV: {MaxV}")]
public class Fahrzeug
{
    public int MaxV;
    public FahrzeugMarke Marke;

    public Fahrzeug(int maxV, FahrzeugMarke marke)
    {
        MaxV = maxV;
        Marke = marke;
    }

    public Fahrzeug() { }
}

public enum FahrzeugMarke
{
    Audi, BMW, VW, Mercedes
}