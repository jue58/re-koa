namespace ReKoA.Core.Attribute
{
    public interface IAttribute { bool sameAs(IAttribute attr); }

    public interface IYellow : IAttribute { }

    public interface IBlue : IAttribute { }

    public interface IRed : IAttribute { }

    public interface IGreen : IAttribute { }

    public abstract class Yellow : IYellow { public bool sameAs(IAttribute attr) => attr is IYellow; }

    public abstract class Blue : IBlue { public bool sameAs(IAttribute attr) => attr is IBlue; }

    public abstract class Red : IRed { public bool sameAs(IAttribute attr) => attr is IRed; }

    public abstract class Green : IGreen { public bool sameAs(IAttribute attr) => attr is IGreen; }
}
