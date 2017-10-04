using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReKoA.Core.Map;

namespace SampleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }

    public class MapGenerator
    {
        public static Map GenerateMap()
        {
            var red = NodeAttributeRed.GetInstance();
            var shrine = NodeAttributeShrine.GetInstance();
            var mapData = new List<(int, INodeAttribute, ISet<int>)>() {
                (1, red, new SortedSet<int>() { 2, 3 }),
                (2, red, new SortedSet<int>() { 1, 4 }),
                (3, red, new SortedSet<int>() { 1, 4, 5 }),
                (4, red, new SortedSet<int>() { 2, 3, 6 }),
                (5, red, new SortedSet<int>() { 3, 6 }),
                (6, shrine, new SortedSet<int>() { 4, 5 })
            };
            var intermediate = mapData.Select(p => (NodeGenerator.GenerateNode(p.Item1, p.Item2), p.Item3));
            var nodes = intermediate.Aggregate(new Dictionary<int, INode>(), (n, i) => { n.Add(i.Item1.ID, i.Item1); return n; });

            return null;
/*            return new Map(nodes, intermediate.Aggregate(new SortedDictionary<INode, ISet<INode>>(), (p, i) =>
                {
                    p.Add(i.Item1, i.Item2.Aggregate(new SortedSet<INode>(), (n, id) => { n.Add(nodes[id]); return n; }));
                    return p;
                }
            ));
            */
        }
    }
}
