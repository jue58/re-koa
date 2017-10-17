using ReKoA.Core.Map;
using System.Collections.Generic;
using System.Linq;

namespace SampleWebApplication.KoA.Map
{
    public class Map : IMap
    {
        public INodeSet Nodes { get; private set; }

        public INodeObjSet NodeObjs { get; private set; }

        public IPathDictionary Paths { get; private set; }

        public Map(INodeObjSet nodeObjs, IPathDictionary paths)
        {
            NodeObjs = nodeObjs;
            Nodes = NodeObjs.getNodes();
            Paths = paths;
        }
    }

    public interface INodeObjSet : ISet<INodeObj> { INodeSet getNodes(); }

    public class NodeObjSet : SortedSet<INodeObj>, INodeObjSet { public INodeSet getNodes() => new NodeSet(this); }

    public interface INodeObj : INode
    {
        INodeObjAttribute ObjAttribute { get; }
    }

    public class NodeObj
    {
        public int ID { get; private set; }

        private INodeAttribute Attribute { get { return ObjAttribute; } }

        public INodeObjAttribute ObjAttribute { get; private set; }

        public NodeObj(int id, INodeObjAttribute objAttribute)
        {
            ID = id;
            ObjAttribute = objAttribute;
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
