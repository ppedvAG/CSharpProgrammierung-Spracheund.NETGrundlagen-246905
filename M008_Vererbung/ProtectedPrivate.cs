using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M008_Vererbung;

class ProtectedPrivate
{
    private protected void Anzeigen()
    {
        Console.WriteLine("Nur in abgeleitete Klasse von diesem Projekt sichtbar");
    }
}

class Ableitung : ProtectedPrivate
{
    public void Test()
    {
        Anzeigen(); // Zugriff!
    }
}

/*
    Main Methode:

    ProtectedPrivate ppr = new ProtectedPrivate();
    ppr.Anzeigen();
*/
