#region Arrays

// Array: Container, die mehrere Variablewerte halten kann
// Alle Werte müssen den gleichen Typen haben

int[] zahlen = new int[10]; // Array erstellt mit Länge 10 (Index 0-9)
zahlen[0] = 10; // Erste Arrayelement => Wert 10
Console.WriteLine(zahlen[0]);

// Direkte Initialisierungen
zahlen = new int[] { 1, 2, 3, 4, 5 };
zahlen = new[] { 1, 2, 3, 4, 5 };
int[] zahlen2 = { 1, 2, 3, 4, 5 };
int[] zahlen3 = [1, 2, 3, 4, 5]; // Ab .NET 8

// Funktionen
// Length: Gibt die Anzahl der Plätze im Array aus
Console.WriteLine(zahlen2.Length);

// Contains: Prüft, ob ein Wert im Array enthalten ist
zahlen.Contains(3); // Ist 3 im Array enthalten?
Console.WriteLine(zahlen.Contains(3));

// Mehrdimensionael Arrays
int[,] zweidimensional;
zweidimensional = new int[,] { { 1, 2, 3, 4, 5}, { 6, 7, 8, 9, 10 } };

Console.WriteLine(zweidimensional[0, 3]);

#endregion

#region Bedingungen

// If-Bedingung
// Führt Code nur aus, wenn die Bedingung true ist

// Vergleichsoperatoren
// ==, != (gleich, ungleich)
// >, <= (größer, kleiner-gleich)
// <, >= (kleiner, größer gleich)

string Hallo = "Hallo";
string Welt = "Welt";

//if(Hallo > Welt) { }
if (Hallo.Length > Welt.Length)
{
    Console.WriteLine("Hallo ist länger als Welt!"); // Längen vergleichen
}

// Logische Operatoren
// && (und)
// ||(oder)
// ! (nicht)
// ^ (exklusiv-oder, XOR) "Caret"

int z1 = 5;
int z2 = 8;
int z3 = 13;

if(z1 > z2 && z1 > z3)
{
    // Hier müssen beide Bedingungen gültig sein:
    Console.WriteLine("z1 ist größer als z2 & z3");
}

if(z1 > z2 || z1 > z3)
{
    // Hier müss NUR EINE Bedingungen gültig sein:
    Console.WriteLine("z1 ist größer als z2 oder z3");
}

if(z1 > z2 ^ z1 > z3)
{
    // Hier müss NUR EINE Bedingungen gültig sein (aber nicht beide):
    Console.WriteLine("z1 ist größer als z2 oder z3");
}

if(!zahlen.Contains(10))
{
   // Prüfen ob Array keine 10 enthält
    Console.WriteLine("Das Array enthält keine 10");
}

// if, if-else, else
if(z1 > z2)
{
    // Bedingung A war erfolgreich
}
else if(z1 == z2)
{
    // Bedingung A war falsch, Bedingung B ist erfolgreich
}
else
{
    // Bedingung A und B waren falsch, else wird ausgeführt
}

// Ternary Operator
// Bedingung ? True-Wert : False-Wert;
// Wann kann ich den Ternary Operator nutzen?
// => Wenn die Ausgabe nur 1 Befehl hat
string x = (z1 > z2) ? "z1 ist größer als z2" : "z1 ist kleiner als z2";
Console.WriteLine(x);

#endregion