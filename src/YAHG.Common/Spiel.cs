using YAHG.Common.Karten;

namespace YAHG.Common
{
    public class Spiel
    {
        public Kartenstapel Kartenstapel { get; set; }

        public IEnumerable<Spieler> Spieler { get; set; }
    }
}