using ReKoA.Core.Attribute;

namespace ReKoA.Core.Map
{
    public interface INodeAttribute : IAttribute { }

    public sealed class NodeAttributeYellow : Yellow, INodeAttribute
    {
        private static NodeAttributeYellow instance = new NodeAttributeYellow();

        public static NodeAttributeYellow GetInstance() => instance;

        private NodeAttributeYellow() { }
    }

    public sealed class NodeAttributeBlue : Blue, INodeAttribute
    {
        private static NodeAttributeBlue instance = new NodeAttributeBlue();

        public static NodeAttributeBlue GetInstance() => instance;

        private NodeAttributeBlue() { }
    }

    public sealed class NodeAttributeRed : Red, INodeAttribute
    {
        private static NodeAttributeRed instance = new NodeAttributeRed();

        public static NodeAttributeRed GetInstance() => instance;

        private NodeAttributeRed() { }
    }

    public class NodeAttributeGreen : Green, INodeAttribute
    {
        private static NodeAttributeGreen instance = new NodeAttributeGreen();

        public static NodeAttributeGreen GetInstance() => instance;

        private NodeAttributeGreen() { }
    }

    public class NodeAttributeWhite : IYellow, IBlue, IRed, IGreen, INodeAttribute
    {
        private static NodeAttributeWhite instance = new NodeAttributeWhite();

        public static NodeAttributeWhite GetInstance() => instance;

        private NodeAttributeWhite() { }

        public bool sameAs(IAttribute attr) => true;
    }

    public class NodeAttributeShrine : IYellow, IBlue, IRed, IGreen, INodeAttribute
    {
        private static NodeAttributeShrine instance = new NodeAttributeShrine();

        public static NodeAttributeShrine GetInstance() => instance;

        private NodeAttributeShrine() { }

        public bool sameAs(IAttribute attr) => true;
    }
}
