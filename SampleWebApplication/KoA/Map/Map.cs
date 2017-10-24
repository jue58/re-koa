using ReKoA.Core.Map;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace SampleWebApplication.KoA.Map
{
    // HACK NodeSetなくして、PathDictionaryだけでどうにかなりそうな気がする
    // partialでidsとか実装できないかな？
    public class Map : IMap
    {
        public INodeSet Nodes { get; private set; }

        public INodeObjSet NodeObjs { get; private set; }

        public IPathDictionary Paths { get; private set; }

        public IObjPathDictionary ObjPaths { get; private set; }

        public Map(INodeObjSet nodeObjs, IObjPathDictionary paths)
        {
            NodeObjs = nodeObjs;
            Nodes = NodeObjs.getNodes();
            ObjPaths = paths;
            Paths = ObjPaths.getPathDictionary();
        }
    }

    public class NodeGenerator : NodeGeneratorBase
    {
        private static NodeGenerator instance = new NodeGenerator();

        public static NodeGenerator GetInstance() => instance;

        private NodeGenerator() { }

        public INodeObj generateNode(int id, INodeObjAttribute attr, int x, int y) => new NodeObj(id, attr, x, y);
    }

    public interface INodeObjSet : ISet<INodeObj>
    {
        INodeSet getNodes();

        ISet<int> ids();
    }

    public class NodeObjSet : SortedSet<INodeObj>, INodeObjSet
    {
        private INodeSet NodeSet { get; set; }

        public NodeObjSet(IEnumerable<INodeObj> collection) : base(collection)
        {
            NodeSet = new NodeSet(collection);
        }

        public INodeSet getNodes() => NodeSet;

        public ISet<int> ids() => NodeSet.ids();
    }


    public interface IObjPathDictionary : IReadOnlyDictionary<INodeObj, INodeObjSet> { IPathDictionary getPathDictionary(); }

    public class ObjPathDictionary : SortedDictionary<INodeObj, INodeObjSet>, IObjPathDictionary
    {
        public ObjPathDictionary(IDictionary<INodeObj, INodeObjSet> dictionary) : base(dictionary) { }

        public IPathDictionary getPathDictionary() => new PathDictionary(((IDictionary<INode, INodeSet>)this));
    }

    public interface INodeObj : INode
    {
        INodeObjAttribute ObjAttribute { get; }

        Point Point { get; }
    }

    public class NodeObj : Node, INodeObj
    {
        public INodeObjAttribute ObjAttribute { get; private set; }

        public Point Point { get; private set; }

        public NodeObj(int id, INodeObjAttribute objAttribute, int x, int y) : base(id, objAttribute)
        {
            ObjAttribute = objAttribute;
            Point = new Point(x, y);
        }
    }

    public interface INodeObjAttribute : INodeAttribute, IObjAttribute { }

    public class NodeObjAttributeYellow : ObjYellow, INodeObjAttribute
    {
        private static NodeObjAttributeYellow instance = new NodeObjAttributeYellow();

        public static NodeObjAttributeYellow GetInstance() => instance;

        private NodeObjAttributeYellow() { }
    }

    public class NodeObjAttributeBlue : ObjBlue, INodeObjAttribute
    {
        private static NodeObjAttributeBlue instance = new NodeObjAttributeBlue();

        public static NodeObjAttributeBlue GetInstance() => instance;

        private NodeObjAttributeBlue() { }
    }

    public class NodeObjAttributeRed : ObjRed, INodeObjAttribute
    {
        private static NodeObjAttributeRed instance = new NodeObjAttributeRed();

        public static NodeObjAttributeRed GetInstance() => instance;

        private NodeObjAttributeRed() { }
    }

    public class NodeObjAttributeGreen : ObjGreen, INodeObjAttribute
    {
        private static NodeObjAttributeGreen instance = new NodeObjAttributeGreen();

        public static NodeObjAttributeGreen GetInstance() => instance;

        private NodeObjAttributeGreen() { }
    }

    public class NodeObjAttributeWhite : ObjWhite, INodeObjAttribute
    {
        private static NodeObjAttributeWhite instance = new NodeObjAttributeWhite();

        public static NodeObjAttributeWhite GetInstance() => instance;

        private NodeObjAttributeWhite() { }
    }

    public class NodeObjAttributeShrine : ObjShrine, INodeObjAttribute
    {
        private static NodeObjAttributeShrine instance = new NodeObjAttributeShrine();

        public static NodeObjAttributeShrine GetInstance() => instance;

        private NodeObjAttributeShrine() { }
    }
}
