using YAHG.Common.Factories;

namespace YAHG.Common.Tests
{
    public class SpielFactoryTests
    {
        [Theory]
        [InlineData(4,4)]
        public void TestSpielFactory(int spieler, int farben)
        {
            SpielFactory factory = new SpielFactory();

            Spiel spiel = factory.CreateSpiel(new SpielKonfiguration()
            {
                AnzahlFarben = farben,
                AnzahlSpieler = spieler
            });

            Assert.Equal(spieler, spiel.Spieler.Count());
            Assert.Equal(farben, spiel.Kartenstapel.Karten.Select(s => s.Farbe).Distinct().Count());
        }
    }
}