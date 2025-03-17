#region Variablen

// Kommentare
// Mit zwei Slashes kann ein Kommentar definiert werden
// Wird vom Compiler ignoriert

/*
    Mehrzeiliger
    Kommentarblock

// Hotkey Kommentieren = [STRG + K] [STRG + C]
// Hotkey Auskommentieren = [STRG + K] [STRG + U]

// Variable 
// Behälter für einen Wert
// Werden in der Programmierung immer benötigt
*/

int Zahl = 10;

Console.WriteLine(Zahl);
Console.WriteLine(Zahl * 2); // cw + Tab => Codeschnipsel für Console.WriteLine()

// Datentypen
// Geben an, welchen Inhalt eine Variable haben darf

// Ganzzahlige Typen: int, long, short, byte
int i = 23;
long l = 23;
short s = 23;
byte b = 23;

// Kommazahltpen: double, float, decimal
double kommazahl = 23.65;
Console.WriteLine("Die Kommazahl beträgt: " + kommazahl);

float f = 23.65f; // Jede Kommazahl in C# ist standardmäßig ein Double, mit f am Ende kann eine konvertierung durchgeführt werden

decimal d = 23.65m; // Genau das selbe wie Oben bloß decimal ist M-Suffix

// float = F-Suffix
// decimal = M-Suffix

string str = "Hallo, ich bin ein String"; // Strings werden in doppelten Hochkommas geschrieben
Console.WriteLine(str);

char c = 'a'; // Char werden in einzelnen Hochkommas angegeben

// Bool: True oder False
bool wahr = true;
bool falsch = false;

#endregion

#region Strings

string ergebnis = "Die Zahl mal zwei ist: " + Zahl * 2;
Console.WriteLine(ergebnis);

// $-Prefix (String Interpolation)
Console.WriteLine($"Die Zahl mal drei ist {Zahl * 3}, das ist mein Ergebnis");

// Escape-Sequenzen: Untippbaren Zeichen in Strings einbetten
// https://learn.microsoft.com/en-us/cpp/c-language/escape-sequences?view=msvc-170

Console.WriteLine("Zeilenumbruch \n\n Zeilenumbruch");

Console.WriteLine("Tabulator \t Tabulator");


// Verbatim-String: häufig für Pfade verwendet
string pfad = @"C:\Program Files\dotnet\shared\Micrsofot.NETCore.App";

#endregion

#region Eingabe 

// Console.ReadLine(): Wartet auf die Eingabe des Benutzers, und speichert diese in die Variable (hier "eingabe")
//Console.WriteLine("\n\n String Eingabe:");
//string eingabe = Console.ReadLine();
//Console.WriteLine($"Du hast {eingabe} eingegeben");

// Console.ReadKey(): Wartet auf die einzelne Eingabe vom Benutzer
//ConsoleKeyInfo taste = Console.ReadKey();
//Console.WriteLine(taste.Key);

#endregion

#region Konvertierung

// Konvertierung: Umwandlung von einem Typen zu einem anderen Typn
string userEingabe = Console.ReadLine();

// String zu Zahl umwandeln: Parse
int Konvertierung = int.Parse(userEingabe); // Die Parse Funktion versucht de nText in eine Zahl umzuwandeln
Console.WriteLine($"Deine Zahl mal zwei ist: {Konvertierung * 2}");

// Zahl zu String umwandeln: ToString()
Console.WriteLine(Konvertierung.ToString());

// Zahl in Zahl konvertieren:
double grosseZahl = 219112434123153.28;

int x = (int)grosseZahl; 
Console.WriteLine(x);

#endregion

#region Arithmetik

int zahl1 = 3;
int zahl2 = 7;

// Aufgabe:
// Zahl2 auf zahl1 addieren
// zahl1 = zahl1 + zahl2
zahl1 += zahl2;
Console.WriteLine(zahl1);

int summe = zahl1 + zahl2;
Console.WriteLine(summe);

// Modulo (%): Rest einer Division
Console.WriteLine(8 % 5); // 3 (R)

// Um 1 Inkrementieren: ++
zahl1++;

// Um 1 dekrementieren: --
zahl2--;

// Math: Mathematischen Funktionen
double gerundet = Math.Round(2.4562472, 2); // auf 2 Nachkommastellen runden
Console.WriteLine(gerundet);

#endregion