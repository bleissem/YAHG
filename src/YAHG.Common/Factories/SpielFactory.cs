using YAHG.Common.Karten;

namespace YAHG.Common.Factories
{
    public class SpielFactory
    {
        public Spiel CreateSpiel(SpielKonfiguration spielKonfiguration)
        {
            if (spielKonfiguration.AnzahlSpieler < 2 || spielKonfiguration.AnzahlSpieler > 5)
            {
                throw new ArgumentException("invalid players");
            }

            IEnumerable<Karte> karten = CreateKarten(spielKonfiguration.AnzahlFarben).SelectMany(s => s);
            IEnumerable<Spieler> spieler = CreateSpieler(spielKonfiguration.AnzahlSpieler);

            return new Spiel()
            {
                Spieler = spieler,
                Kartenstapel = new Kartenstapel()
                {
                    Karten = karten,
                }
            };
        }

        private IEnumerable<Spieler> CreateSpieler(int anzahlSpieler)
        {
            SpielerFactory factory = new SpielerFactory();
            return factory.Create(anzahlSpieler);
        }

        private IEnumerable<IEnumerable<Karte>> CreateKarten(int farben)
        {
            for (int i = 0; i < farben; ++i)
            {
                KartenFactory factory = new KartenFactory();
                yield return factory.Create((Farbe)i);
            }
        }
    }
}