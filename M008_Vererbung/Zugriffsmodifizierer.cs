using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M008_Vererbung;

internal class Zugriffsmodifizierer
{
    public string Vorname { get; set; } // public: Kann von überall angegriffen werden (Projekte, Klassen, Abgeleitete Klassen)

    private string Nachname { get; set; } // Kann nur innerhalb der Klasse verwendet werden

    internal int Alter {  get; set; } // Kann von überall angegrifen werden, aber nur innerhalb vom Projekt

    /////////////////////////////////////////////
    
    protected double Groesse { get; set; } // innerhalb er Klasse & abgeleitete Klassen

    protected private int Gehalt { get; set; } // Nur in abgeleitete Klassen

    protected internal string Adresse { get; set; } // Nur in abgeleitete Klassen & internen Projekt 
}
