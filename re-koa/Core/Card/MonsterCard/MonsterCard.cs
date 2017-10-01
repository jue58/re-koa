using ReKoA.Core.Attribute;
using System.Collections.Generic;

namespace ReKoA.Core.Card.MonsterCard
{
    public interface IMonsterCard : ICard
    {
        IMonsterAttribute Attribute { get; }
        Move Move { get; }
        int Attack { get; }
        int Defend { get; }
    }

    public class MonsterCard : IMonsterCard
    {
        public IMonsterAttribute Attribute { get; private set; }
        public Move Move { get; private set; }
        public int Attack { get; private set; }
        public int Defend { get; private set; }


        public MonsterCard(IMonsterAttribute attribute, Move move, int attack, int defend)
        {
            Attribute = attribute;
        }

        // TODO 特殊能力の実装
    }

    public interface IMonsterAttribute : IAttribute { }
    public class MonsterAttributeYellow : Yellow, IMonsterAttribute { }
    public class MonsterAttributeBlue : Blue, IMonsterAttribute { }
    public class MonsterAttributeRed : Red, IMonsterAttribute { }
    public class MonsterAttributeGreen : Green, IMonsterAttribute { }

    public class Move : List<IMoveAttribute> { }
    public interface IMoveAttribute : IAttribute { }
    public class MoveAttributeYellow : Yellow, IMoveAttribute { }
    public class MoveAttributeBlue : Blue, IMoveAttribute { }
    public class MoveAttributeRed : Red, IMoveAttribute { }
    public class MoveAttributeGreen : Green, IMoveAttribute { }
    public class MoveAttributeWhite : IYellow, IBlue, IRed, IGreen, IMoveAttribute { public bool sameAs(IAttribute attr) => true; }

}