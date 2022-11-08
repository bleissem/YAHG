using YAHG.Common.Factories;

namespace YAHG.Common.Tests
{
    public class SpielerFactoryTests
    {
        [Theory]
        [InlineData(12)]
        [InlineData(42)]
        [InlineData(666)]
        public void TestSpielerFactory(int anzahlSpieler)
        {
            SpielerFactory factory = new SpielerFactory();

            var spieler = factory.Create(anzahlSpieler);

            Assert.Equal(anzahlSpieler, spieler.Count());

            for (int i = 0; i < anzahlSpieler; i++)
            {
                Assert.Contains(spieler, a => a.Id == i);
            }
        }
    }
}