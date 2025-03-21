using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M008_Vererbung;

class ProtectedInternal
{
    protected internal void SageHallo()
    {
        Console.WriteLine("Hallo aus ProtectedInternal Klasse");
    }
}

class Angestellt : ProtectedInternal
{
    public void Ausgeben()
    {
        SageHallo(); // Erlaubt!
    }
}
