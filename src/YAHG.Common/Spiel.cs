using YAHG.Common.Karten;

namespace YAHG.Common
{
    /// <summary>
    /// HanabiGame
    /// </summary>
    public class Spiel
    {
        public Kartenstapel Kartenstapel { get; set; }

        public IEnumerable<Spieler> Spieler { get; set; }
    }
}