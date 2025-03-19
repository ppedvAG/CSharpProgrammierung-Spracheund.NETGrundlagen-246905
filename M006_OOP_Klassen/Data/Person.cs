using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M006_OOP_Klassen.Data;

// - Vorname - string
// - Nachname - string
// - Größe - double
// - Alter - int

public class Person
{

    #region Feld
    // Feld
    // Dieses Feld hält einen Wert (hier Vorname)
    // Felder sollten nur indirekt angegriffen werden können
    // Durch den private Modifier kann das Feld nicht von außerhalb der Klasse werden (nur innerhalb der Klasse)
    private string vorname;

    // Die Get-Methode wird verwendet, um den Wert aus einem Feld auszulesen
    public string GetVorname()
    {
        return vorname;
    }

    // Die Set-Methode wird verwendet, um neue Werte in das Feld einzutragen
    // this.vorname bezieht sich auf das Feld weiter oben (in Z.19)
    // vorname bezieht sich auf en Parameter innerhalb der Methode

    public void SetVorname(string vorname)
    {
        // this: Wird verwendet, um gleichnamige Variablen voneinander zu unterscheiden
        //vorname = namevor;
        this.vorname = vorname;
    }

    #endregion

    #region Eigenschaften

    // Eigenschaft (Property)
    // Vereinfachung von dem alten Get-/Setmethoden Schema

    public string nachnamen { get; set; }
    public int alter { get; set; }

    #endregion

    #region Konstruktor

    // Konstruktor
    // "Main Methode" von der Klasse
    // Wird beim Erstellen eines Objektes ausgeführt
    // Standardkonstruktor existiert immer, wenn keine andere Konstruktoren definiert wurden

    public Person()
    {
        Console.WriteLine("Person erstellt");
    }

    public Person(string vorname, string nachname) : this() // this() bezieht sich auf Person()
    {
        this.vorname = vorname;
        this.nachnamen = nachname;
    }

    // Verkettung von Konstruktoren
    // Mithilfe von this(...) können Konstruktoren miteinander verkettet werden
    // D.h wenn dieser Konstruktor aufgerufen wird, wird auch der Konstruktor in der Kette darüber aufgerufen
    public Person(string vorname, string nachname, int alter) : this(vorname, nachname) // -> bezieht auf Person darüber (in Z.65)
    {
        this.alter = alter;
        //this.vorname = vorname;
        //this.nachnamen = nachname;

    }

    #endregion
}
