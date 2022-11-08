using YAHG.Common.Karten;

namespace YAHG.Common.Tests
{
    public class KartenTests
    {
        [Fact]
        public void TestKartenGleichheit()
        {
            Karte karte1 = new Karte()
            {
                Farbe = Farbe.Blau,
                Wert = Wert.Eins,
            };

            Karte karte2 = new Karte()
            {
                Farbe = Farbe.Blau,
                Wert = Wert.Eins,
            };

            Assert.True(karte1.Equals(karte2));
        }

        [Fact]
        public void TestKartenUnGleichheitBeiFarbe()
        {
            Karte karte1 = new Karte()
            {
                Farbe = Farbe.Gruen,
                Wert = Wert.Eins,
            };

            Karte karte2 = new Karte()
            {
                Farbe = Farbe.Blau,
                Wert = Wert.Eins,
            };

            Assert.False(karte1.Equals(karte2));
        }

        [Fact]
        public void TestKartenUnGleichheitBeiWert()
        {
            Karte karte1 = new Karte()
            {
                Farbe = Farbe.Rot,
                Wert = Wert.Eins,
            };

            Karte karte2 = new Karte()
            {
                Farbe = Farbe.Rot,
                Wert = Wert.Zwei,
            };

            Assert.False(karte1.Equals(karte2));
        }

        [Fact]
        public void TestKartenUnGleichheitBeiWertUndFarbe()
        {
            Karte karte1 = new Karte()
            {
                Farbe = Farbe.Gruen,
                Wert = Wert.Vier,
            };

            Karte karte2 = new Karte()
            {
                Farbe = Farbe.Gelb,
                Wert = Wert.Fuenf,
            };

            Assert.False(karte1.Equals(karte2));
        }
    }
}