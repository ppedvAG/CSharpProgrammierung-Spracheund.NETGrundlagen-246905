namespace M008_Vererbung;

public class Program
{
    static void Main(string[] args)
    {
        Lebewesen lb = new Lebewesen(20);
        lb.Ausgeben();

        Mensch m = new Mensch(10,"Max");
        m.Ausgeben();

        // Protected Private
        //ProtectedPrivate ppr = new ProtectedPrivate();
        //ppr.Anzeigen();

        Ableitung ab = new Ableitung();
        ab.Test(); // Zugriff

        // Protected Internal
        ProtectedInternal ppi = new ProtectedInternal();
        ppi.SageHallo(); // => Basisklassen aufruf ist möglich

        Angestellt a = new Angestellt();
        a.Ausgeben(); // => Ausgabe aus der abgeleiteten Funktioniert auch!
    }
}

public class Lebewesen
{
    public int Alter { get; set; }

    public Lebewesen(int alter)    
    {
        Alter = alter;
    }   

    public virtual string Ausgeben()
    {
        return $"Lebewesen ist {Alter} Jahre alt";
    }
}

public class Mensch : Lebewesen
{
    public Mensch(int alter, string name) : base(alter)
    {
        this.Name = name;
    }

    public string Name { get; set; }

    public sealed override string Ausgeben()
    {
        string dranhängen = $"{base.Ausgeben()} Und Name ist: {Name}";
        return dranhängen;
    }
}

public class Kind : Mensch
{
    public Kind(int alter, string name) : base(alter, name)
    {
    }

    //public override string Ausgeben()
    //{
    //    return "bla bla bla";
    //}
}