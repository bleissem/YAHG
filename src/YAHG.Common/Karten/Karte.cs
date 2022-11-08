namespace YAHG.Common.Karten
{
    public record Karte
    {
        public Karte()
        {
        }

        public Karte(Farbe farbe, Wert wert)
        {
            Farbe = farbe;
            Wert = wert;
        }

        public Farbe Farbe { get; set; }

        public Wert Wert { get; set; }
    }
}