using System.Security.Cryptography;

namespace M013_Exceptions;

// Fehlerbehandlung
// try-catch
// Wird verwendet um Exeptions (= Fehler -> Abstürze zu verhindern)
// Hintergrund: Plattformunabhängigkeit
// Wenn im Code ein Fehler auftreten sollte, soll dieser Fehler per Exception verursacht werden
// Wenn eine Exception auftritt, kann der Benutzer des Codes selbst entscheiden, wie diese Exception behandelt wird

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            string eingabe = Console.ReadLine();
            int x = int.Parse(eingabe);
        }
        // Wenn ein catch-Block ausgeführt wird, stürzt das Programm nicht mehr ab, sondern es wird eine Fehlermeldung ausgegeben und er gibt den Inhalt aus
        catch (FormatException ex)
        {
            // über ex kann auf den Fehler zugegriffen werden
            Console.WriteLine("Die Eingabe ist keine Zahl");
            Console.WriteLine(ex.Message); // Die C# interne Fehlermeldung
            Console.WriteLine(ex.StackTrace); // Rückverfolgung, Log ausgeben lassen => wo ist der Fehler passiert?
            //return; // Return hat keinen Input auf das abbrechen der "Schleife"
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Die Eingabe ist zu groß/klein");
            Console.WriteLine(ex.Message); // Die C# interne Fehlermeldung
            Console.WriteLine(ex.StackTrace); // Rückverfolgung, Log ausgeben lassen => wo ist der Fehler passiert?
        }
        catch (Exception) // Alle anderen Fehler aus
        {
            Console.WriteLine("Andere Fehler");
        }
        finally // Wird immer ausgeführt egal ob Fehler oder nicht
        {
            Console.WriteLine("Parsen war erfolgreich");
        }
    }
}