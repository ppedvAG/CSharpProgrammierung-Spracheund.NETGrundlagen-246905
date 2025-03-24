/*
    1. Erstelle eine Basisklasse Fahrzeug, die folgende Eigenschaften hat:
    
    Modell - string
    Preis - double
    Typ (Enum) - FahrzeugTyp => Auto oder Motorrad
    Eine Methode Ausgeben() => Fahrzeug details ausgeben

    2. Erstelle zwei abgeleite Klassen
    
    Auto: Die hat die zusätzliche Eigenschaft "Kofferaum" (bool)
    Motorrad: Die zusätzliche Eigenschaft "HatBeiwagen" (bool)

    3. Override nutzen um Ausgeben()-Methode überschreiben oder anzupassen in den abgeleiteten Klassen

    4. Erstelle ein Enum FahrzeugTyp, das zwei werte hat (Auto und Motorrad)
    
    5. Speichere mehrere Fahrzeuge in einem Array speichern & per Scheife ausgeben lassen

    Fahrzeug[] fahrzeuge = new Fahrzeug[] 
    {
        new Auto(...),
        new Motorrad(...),
    }
 
*/

class Fahrzeug
{
    public string Modell { get; set; }
}