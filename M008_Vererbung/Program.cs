namespace M008_Vererbung;

public class Program
{
    static void Main(string[] args)
    {
        Lebewesen lb = new Lebewesen(20);
        lb.Ausgeben();

        Mensch m = new Mensch(10,"Max");
        m.Ausgeben();

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

    public override string Ausgeben()
    {
        return "bla bla bla";
    }
}