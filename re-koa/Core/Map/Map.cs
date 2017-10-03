using System.Collections.Generic;

namespace ReKoA.Core.Map
{
    public class Map
    {
        public IReadOnlyDictionary<INode, ISet<INode>> Paths { get; private set; }

        public Map(IReadOnlyDictionary<INode, ISet<INode>> paths)
        {
            Paths = paths;
        }
    }

    // TODO MapFactory

}
