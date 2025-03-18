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