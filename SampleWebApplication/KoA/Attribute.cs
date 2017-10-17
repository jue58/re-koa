using ReKoA.Core.Attribute;

namespace SampleWebApplication.KoA
{
    public interface IObjAttribute : IAttribute { string color(); }

    public abstract class ObjYellow : Yellow, IObjAttribute { public string color() => "yellow"; }

    public abstract class ObjBlue : Blue, IObjAttribute { public string color() => "blue"; }

    public abstract class ObjRed : Red, IObjAttribute { public string color() => "red"; }

    public abstract class ObjGreen : Green, IObjAttribute { public string color() => "green"; }

    public abstract class ObjWhite : White, IObjAttribute { public string color() => "white"; }

    public abstract class ObjShrine : Shrine, IObjAttribute { public string color() => "purple"; }
}
