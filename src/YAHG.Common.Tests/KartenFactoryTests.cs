using YAHG.Common.Factories;
using YAHG.Common.Karten;

namespace YAHG.Common.Tests
{
    public class KartenFactoryTests
    {
        [Theory]
        [InlineData(Farbe.Blau)]
        [InlineData(Farbe.Gelb)]
        public void TestKartenFactory(Farbe farbe)
        {
            KartenFactory factory = new KartenFactory();
            var karten = factory.Create(farbe);

            Assert.Equal(10, karten.Count());
            Assert.Equal(10, karten.Count(w => w.Farbe == farbe));

            Assert.Equal(3, karten.Count(w => w.Wert == Wert.Eins));
            Assert.Equal(2, karten.Count(w => w.Wert == Wert.Zwei));
            Assert.Equal(2, karten.Count(w => w.Wert == Wert.Drei));
            Assert.Equal(2, karten.Count(w => w.Wert == Wert.Vier));
            Assert.Equal(1, karten.Count(w => w.Wert == Wert.Fuenf));
        }
    }
}