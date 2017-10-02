using ReKoA.Core.Attribute;
using System.Collections.Generic;

namespace ReKoA.Core.Map
{
    public interface INode
    {
        int ID { get; }

        INodeAttribute Attribute { get; }

        bool Equals(object obj);
    }

    internal class Node : INode
    {
        public int ID { get; private set; }

        public INodeAttribute Attribute { get; private set; }

        public Node(int id, INodeAttribute attribute)
        {
            ID = id;
            Attribute = attribute;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Node n = (Node)obj;
            return ID.Equals(n.ID);
        }

        public override int GetHashCode()
        {
            return ID;
        }
    }

    public interface INodeAttribute : IAttribute { }
    public class NodeAttributeYellow : Yellow, INodeAttribute { }
    public class NodeAttributeBlue : Blue, INodeAttribute { }
    public class NodeAttributeRed : Red, INodeAttribute { }
    public class NodeAttributeGreen : Green, INodeAttribute { }
    public class NodeAttributeWhite : IYellow, IBlue, IRed, IGreen, INodeAttribute { public bool sameAs(IAttribute attr) => true; }
}