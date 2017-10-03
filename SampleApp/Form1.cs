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
            var red = new NodeAttributeRed();
            var shrine = new NodeAttributeShrine();
            var paths = new SortedDictionary<int, (INodeAttribute, ISet<int>)>() {
                { 1, (red, new SortedSet<int>() { 2, 3 }) },
                { 2, (red, new SortedSet<int>() { 1, 4 }) },
                { 3, (red, new SortedSet<int>() { 1, 4, 5 }) },
                { 4, (red, new SortedSet<int>() { 2, 3, 6 }) },
                { 5, (red, new SortedSet<int>() { 3, 6 }) },
                { 6, (shrine, new SortedSet<int>() { 4, 5 }) }
            };
            // 変換処理
            return null;
        }
    }
}
