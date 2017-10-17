using ReKoA.Core.Attribute;

namespace ReKoA.Core.Map
{
    public interface INodeAttribute : IAttribute { }

    public class NodeAttributeYellow : Yellow, INodeAttribute
    {
        private static NodeAttributeYellow instance = new NodeAttributeYellow();

        public static NodeAttributeYellow GetInstance() => instance;

        private NodeAttributeYellow() { }
    }

    public class NodeAttributeBlue : Blue, INodeAttribute
    {
        private static NodeAttributeBlue instance = new NodeAttributeBlue();

        public static NodeAttributeBlue GetInstance() => instance;

        private NodeAttributeBlue() { }
    }

    public class NodeAttributeRed : Red, INodeAttribute
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

    public class NodeAttributeWhite : White, INodeAttribute
    {
        private static NodeAttributeWhite instance = new NodeAttributeWhite();

        public static NodeAttributeWhite GetInstance() => instance;

        private NodeAttributeWhite() { }
    }

    public class NodeAttributeShrine : Shrine, INodeAttribute
    {
        private static NodeAttributeShrine instance = new NodeAttributeShrine();

        public static NodeAttributeShrine GetInstance() => instance;

        private NodeAttributeShrine() { }
    }
}
