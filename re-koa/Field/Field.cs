using ReKoA.Core.Map;
using ReKoA.Core.Player;
using System.Collections.Generic;

namespace ReKoA.Field
{
    public class Field
    {
        public Map Map { get; private set; }

        public ISet<IPlayer> Players { get; private set; }

        public int Key { get; private set; }
    }
}
