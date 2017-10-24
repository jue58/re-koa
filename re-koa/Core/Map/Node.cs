﻿using ReKoA.Core.Attribute;

namespace ReKoA.Core.Map
{
    public interface INode
    {
        int ID { get; }

        INodeAttribute Attribute { get; }

        bool Equals(object obj);

        int GetHashCode();
    }

    // TODO publicのままでいくなら、テストの修正が必要
    public class Node : INode
    {
        public int ID { get; protected set; }

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

    public abstract class NodeGeneratorBase
    {
        protected INode generateNode(int id, INodeAttribute attr) => new Node(id, attr);
    }

}
