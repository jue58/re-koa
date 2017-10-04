using System.Collections.Generic;

namespace ReKoA.Core.Map
{
    public class Map
    {
        public INodeSet Nodes { get; private set; }

        public IPathDictionary Paths { get; private set; }

        public Map(INodeSet nodes, IPathDictionary paths)
        {
            Nodes = nodes;
            Paths = paths;
        }
    }

    public interface INodeSet : ISet<INode> { }

    public class NodeSet : SortedSet<INode>, INodeSet { }

    public interface IPathDictionary : IReadOnlyDictionary<INode, INodeSet> { }

    // 名前がいまいち
    public class PathDictionary : SortedDictionary<INode, INodeSet>, IPathDictionary { }

    // TODO MapFactory
}
