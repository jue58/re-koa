using ReKoA.Core.Attribute;

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

    public class NodeGenerator
    {
        public static INode GenerateNode(int id, INodeAttribute attr) => new Node(id, attr);
    }
}
