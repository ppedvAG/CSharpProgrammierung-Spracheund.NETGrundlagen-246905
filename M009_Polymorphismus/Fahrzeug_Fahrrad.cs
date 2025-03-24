using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M009_Polymorphismus;

// Klassenbauplan
public abstract class Fahrzeug
{
    public abstract void istFahrbereit();
}

public class Fahrrad : Fahrzeug
{
    public int Luft { get; set; }

    public override void istFahrbereit()
    {
        Console.WriteLine($"Das ist Luft");
    }
}
