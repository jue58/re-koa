using ReKoA.Core.Attribute;
using ReKoA.Core.Card.MonsterCard;
using System;
using System.Linq;
using System.Reflection;
using Xunit;
using Xunit.Abstractions;

namespace ReKoATest.Core.Card.MonsterCard
{
    public class MonsterCardTest
    {
        private readonly ITestOutputHelper output;

        public MonsterCardTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void getColorNameTest()
        {
            var target = new ReKoA.Core.Card.MonsterCard.MonsterCard(
                new MonsterAttributeRed(),
                new Move() { new MoveAttributeRed(), new MoveAttributeRed(), new MoveAttributeWhite() },
                10,
                15
            );

            Assert.True(target.Attribute.sameAs(new MoveAttributeWhite()));
        }
    }
}
