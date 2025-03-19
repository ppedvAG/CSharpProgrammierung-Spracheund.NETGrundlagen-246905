namespace M006_OOP_Klassen.Data
{

    // - Trainer
    // - Teilnehmer
    // - Ausstattung
    // - Location
    // - Schulungstyp
    // - Dauer
    // - Titel
    public class Schulung
    {
        public Person Trainer { get; set; }

        public Person[] Teilnehmer { get; set; }

        public string Standort { get; set; }    
        public Schulungstyp Typ { get; set; }
        public int Dauer { get; set; }  
        public string Titel { get; set; }

        // Kürzel für den Konstruktor herstellen => Strg + . (punkt)
        public Schulung(Person trainer, string standort, Schulungstyp typ, int dauer, string titel, params Person[] teilnehmer)
        {
            Trainer = trainer;
            Teilnehmer = teilnehmer;
            Standort = standort;
            Typ = typ;
            Dauer = dauer;
            Titel = titel;
        }

        public void NeueTeilnehmerHinzufuegen(params Person[] teilnehmer)
        {
            // Jeder neue Teilnehmer soll in das Array "Teilnehmer" drangehängt werden
            Teilnehmer = Teilnehmer.Concat(teilnehmer).ToArray();
        }
    }
}
