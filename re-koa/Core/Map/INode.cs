using System.Collections.Generic;

namespace ReKoA.Core.Map
{
    internal interface INode
    {
        int ID { get; }

        List<INode> AdjoiningNodes { get; }

        bool Equals(object obj);
    }

    internal class Node : INode
    {
        public int ID { get; private set; }

        public List<INode> AdjoiningNodes { get; private set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            INode n = (INode)obj;
            return this.ID.Equals(n.ID);
        }

        public override int GetHashCode()
        {
            return ID;
        }
    }
}