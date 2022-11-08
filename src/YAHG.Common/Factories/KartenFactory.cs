using YAHG.Common.Karten;

namespace YAHG.Common.Factories
{
    public class KartenFactory
    {
        public IEnumerable<Karte> Create(Farbe farbe) 
        {
            for (int i = 0; i < 3; ++i)
            {
                yield return new Karte(farbe, Wert.Eins);
            }

            for (int i = 0; i < 2; ++i)
            {
                yield return new Karte(farbe, Wert.Zwei);
                yield return new Karte(farbe, Wert.Drei);
                yield return new Karte(farbe, Wert.Vier);
            }

            yield return new Karte(farbe, Wert.Fuenf);
            
        }
    }
}