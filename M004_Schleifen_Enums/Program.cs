#region Schleifen

// Schleifen
// Bestimmten Code mehrmals auszuführen

// while
using System.Threading.Channels;

int a = 0;
int b = 10;
while (a < b)
{
    Console.WriteLine($"while: {a}");
    a++;
}

// do-while

a = 0;

do
{
    Console.WriteLine($"do-while: {a}");
    a++;
} while(a < b);

// for-schleife
for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"for: {i}");
}

// Iterierung über ein Array
int[] zahlen = { 1, 2, 3, 4, 5, 6 };
for(int i = 0;i < zahlen.Length;i++)
{
    Console.WriteLine($"Array: {zahlen[i]}");
}

// Problem: Den Index manipulieren => außerhalb des Arrays
// Lösung: foreach-Schleife

// foreach-schleife
// Keinen Zähler, sondern nur das Element selbst
// => Foreach wird immer for-schleife bevorzugt
// mit var ist das ganze variable
foreach(int element in zahlen) // zahlen = {1, 2, 3, 4, 5, 6}
{
    Console.WriteLine($"Foreach: {element}");
}

// Continue & Break

// Break: Beendet die Schleife
// break wird generell mit einer if-Bedingung kombiniert

// Continue:
// Überspringt den Code danach, und geht zum Schleifenkopf zurück (zur Bedingung)
a = 0;
while (a < b)
{
    a++;
    if(a % 2 == 0) 
        continue;
    Console.WriteLine($"while continue: {a}");
}

#endregion

#region Enums

// Enum
// Liste von Konstanten (Werten die nicht veränderbar sind)
// Eigener Datentyp
// Jedes Enum hat ein Numerischen Wert (standard ist bei 0) kann man beliebig einstellen
Wochentag wt = Wochentag.Di;
if(wt == Wochentag.Di)
{
    Console.WriteLine("Jetzt ist Dienstag immer genau ein Zustand");
}

// Die Enum Klasse => Enum Wochentag in variable speichern
Wochentag[] tage = Enum.GetValues<Wochentag>(); // Ich speicher mir alle Wochentage in "tage" variable rein (array)
foreach(var w in tage )
{
    Console.WriteLine($"Enum Wochentag: {w}");
    Console.WriteLine($"Enum Wochentag (int):  {(int)w}");
}

// Enum.Parse: Text zu einem Enumwert konvertieren
Console.WriteLine(Enum.Parse<Wochentag>("Mo"));
Console.WriteLine(Enum.Parse<Wochentag>("4"));


#endregion

#region Switch

// Switch
// prüft eine Variable auf mehrere Werte (Möglichkeiten)
Wochentag t = Wochentag.Fr;

switch(t)
{
    case Wochentag.Mo:
    case Wochentag.Di:
    case Wochentag.Mi:
    case Wochentag.Do:
    case Wochentag.Fr:
        Console.WriteLine("Wochentag");
        break;
    case Wochentag.Sa:
    case Wochentag.So:
        Console.WriteLine("Wochenende");
        break;
    default:
        Console.WriteLine("Fehler");
        break;
}

// In einer If-Abfrage
if(t == Wochentag.Mo || t == Wochentag.Di || t == Wochentag.Mi || t == Wochentag.Do || t == Wochentag.Fr)
{
    Console.WriteLine("Wochentag");
}
else if (t == Wochentag.Sa || t == Wochentag.So)
{
    Console.WriteLine("Wochenenede");
}
else
{
    Console.WriteLine("Fehler!");
}

// Boolscher Switch
switch(t)
{
    case >= Wochentag.Mo and <= Wochentag.Fr:
        Console.WriteLine("Wochentag");
        break;
    case Wochentag.Sa or Wochentag.So:
        Console.WriteLine("Wochenende");
        break;
    default:
        Console.WriteLine("Fehler!");
        break;
}

#endregion 

enum Wochentag
{
    Mo = 1, Di, Mi, Do, Fr, Sa, So
}
