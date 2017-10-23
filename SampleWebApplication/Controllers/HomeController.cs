using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleWebApplication.KoA.Map;
using ReKoA.Core.Map;

namespace SampleWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var map = MapGenerator.GetMap();
            // 次回：mapをテンプレート上でjsのオブジェクトに変換する
            return View();
        }


        public IActionResult Error()
        {
            return View();
        }
    }


    public class MapGenerator
    {
        public static Map GetMap()
        {
            var red = NodeObjAttributeRed.GetInstance();
            var shrine = NodeObjAttributeShrine.GetInstance();
            var mapData = new List<(int, INodeObjAttribute, ISet<int>, int, int)>() {
                    (1, red, new SortedSet<int>() { 2, 3 }, 10, 10),
                    (2, red, new SortedSet<int>() { 1, 4 }, 10, 20),
                    (3, red, new SortedSet<int>() { 1, 4, 5 }, 10, 30),
                    (4, red, new SortedSet<int>() { 2, 3, 6 }, 10, 40),
                    (5, red, new SortedSet<int>() { 3, 6 }, 10, 50),
                    (6, shrine, new SortedSet<int>() { 4, 5 }, 10, 60)
                };
            var generator = NodeGenerator.GetInstance();
            var intermediate = mapData.Select(p => (generator.generateNode(p.Item1, p.Item2, p.Item4, p.Item5), p.Item3));
            var nodes = new NodeObjSet(intermediate.Select(n => n.Item1));

            return new Map(nodes, intermediate.Aggregate(new PathDictionary(), (p, i) =>
                {
                    p.Add(i.Item1, new NodeSet(i.Item2.Select(id => nodes.First(n => n.ID == id))));
                    return p;
                }
            ));
        }
    }

}
