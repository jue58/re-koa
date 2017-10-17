using System.Collections.Generic;
using System.Linq;

namespace ReKoA.Core.Map
{
    public interface IMap
    {
        INodeSet Nodes { get; }

        IPathDictionary Paths { get; }
    }

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

    public interface INodeSet : ISet<INode> { ISet<int> ids(); }

    public class NodeSet : SortedSet<INode>, INodeSet
    {
        public NodeSet(IEnumerable<INode> collection) : base(collection) { }

        public ISet<int> ids() => new SortedSet<int>(this.Select(v => v.ID));

    }

    public interface IPathDictionary : IReadOnlyDictionary<INode, INodeSet> { }

    // 名前がいまいち
    public class PathDictionary : SortedDictionary<INode, INodeSet>, IPathDictionary { }

    // TODO MapFactory
}
