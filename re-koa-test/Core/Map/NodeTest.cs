using Xunit;
using ReKoA.Core.Map;
using System.Collections.Generic;

namespace ReKoATest.Core.Map
{
    public class NodeTest
    {
        [Fact]
        public void equalsTest()
        {
            var n1 = new Node(1, NodeAttributeRed.GetInstance());
            var n2 = new Node(1, NodeAttributeBlue.GetInstance());
            var n3 = new Node(3, NodeAttributeRed.GetInstance());

            Assert.True(n1.Equals(n2));
            Assert.True(n2.Equals(n1));
            Assert.False(n1.Equals(n3));
            Assert.False(n3.Equals(n1));
        }
    }
}
