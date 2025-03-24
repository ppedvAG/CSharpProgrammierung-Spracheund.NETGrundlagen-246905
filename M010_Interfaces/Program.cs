using System.Transactions;

namespace M010_Interfaces;

public class Program
{
    static void Main(string[] args)
    {
        Smartphone s = new Smartphone();
        Weltkarte w = new Weltkarte();

        s.Maximum = 100;
        s.Aufladen(50);
        s.PrintLadezustand();

        w.Maximum = 95;
        w.Aufladen(85);
        w.PrintLadezustand();

        // Das selbe wie Oben, bloß als Interface Objekt
        IAufladbar[] aufladenArray = [s, w];

        aufladenArray[0].Maximum = 100;
        aufladenArray[0].Aufladen(80);
        aufladenArray[0].PrintLadezustand();    
        
        aufladenArray[1].Maximum = 100;
        aufladenArray[1].Aufladen(80);
        aufladenArray[1].PrintLadezustand();
    }
}

public interface IAufladbar
{
    int Ladezustand { get; set; }
    int Maximum { get; set; }
    public void Aufladen(int x);
    public void PrintLadezustand();
    public double MaxProzent();
}

public class Smartphone : IAufladbar
{
    public int Ladezustand { get; set; }

    public int Maximum { get; set; }

    public void Aufladen(int x)
    {
        if(Ladezustand + x > Maximum ||Ladezustand + x < 0)
        {
            return;
        }
        Ladezustand += x;
    }
    public double MaxProzent()
    {
        return (double)Ladezustand / Maximum;
    }

    public void PrintLadezustand()
    {
        Console.WriteLine($"Das Smartphone ist zu {MaxProzent() * 100}% geladen");
    }
}

public class Weltkarte : Smartphone, IAufladbar // Wenn wir mehrfachvererben zwingend komma setzen (Hat keinen Zweck der Inhalt)
{
    public int Ladezustand { get; set; }

    public int Maximum { get; set; }

    public void Aufladen(int x)
    {
        if(Ladezustand + x > Maximum ||Ladezustand + x < 0)
        {
            return;
        }
        Ladezustand += x;
    }
    public double MaxProzent()
    {
        return (double)Ladezustand / Maximum;
    }

    public void PrintLadezustand()
    {
        Console.WriteLine($"Das Smartphone ist zu {MaxProzent() * 100}% geladen");
    }
}

//public interface IBeladbar
//{
//    Fahrzeug Ladung { get; set; }
//    Eigenschaft Namens "Ladung" hat vom Typ das Fahrzeug

//    void Belade(Fahrzeug fz);
//    Methode Belade => void, Parameter => das jetzige Fahrzeug
//      Das jetzige Fahrzeug was erstellt wurde, wird in den Paramter bei Belade geschrieben und ausgegeben

//   Fahrzeug Entlade();
//    Methode "Entlade" => das jetzige Fahrzeug wird entladen(also auf null) geschrieben
//}