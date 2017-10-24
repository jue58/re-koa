using System.Collections.Generic;
using System.Linq;

namespace ReKoA.Core.Map
{
    public interface IMap
    {
        INodeSet Nodes { get; }

        IPathDictionary Paths { get; }
    }

    // TODO INodeSetはISetを継承せずに使われそうなメソッドを定義するだけにする？
    public interface INodeSet : ISet<INode> { ISet<int> ids(); }

    public class NodeSet : SortedSet<INode>, INodeSet
    {
        public NodeSet(IEnumerable<INode> collection) : base(collection) { }

        public ISet<int> ids() => new SortedSet<int>(this.Select(v => v.ID));

    }

    public interface IPathDictionary : IReadOnlyDictionary<INode, INodeSet> { }

    // TODO 名前がいまいち
    public class PathDictionary : SortedDictionary<INode, INodeSet>, IPathDictionary
    {
        public PathDictionary(IDictionary<INode, INodeSet> dictionary) : base(dictionary) { }
    }

    // TODO MapFactory
}
