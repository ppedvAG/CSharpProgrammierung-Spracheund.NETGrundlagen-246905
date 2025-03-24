using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M009_Polymorphismus;

public class Lebewesen
{
    public int Alter { get; set; }
    public Lebewesen(int alter)
    {
        Alter = alter;
    }

    public virtual void Bewegen(int distanz)
    {
        Console.WriteLine($"Lebewesen bewegt sich um {distanz}m");
    }
}
public class Mensch : Lebewesen
{
    public string Name { get; set; }
    public Mensch(string name, int alter) : base(alter) 
    {
        Name = name;
    }

    // new verhindert die überschreibung
    public new void Bewegen(int distanz)
    {
        Console.WriteLine($"{Name} bewegt sich um {distanz}m");
    }

    public void TestMethode()
    {
        Console.WriteLine("Ich bin eine TestMethode");
    }
}
