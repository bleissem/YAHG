namespace YAHG.Common.Factories
{
    public class SpielerFactory
    {
        public IEnumerable<Spieler> Create(int anzahlSpieler)
        {
            for (int i = 0; i < anzahlSpieler; ++i)
            {
                yield return new Spieler()
                {
                    Id = i,
                };
            }
        }
    }
}