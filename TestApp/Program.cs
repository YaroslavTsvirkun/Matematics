using Numerics;
using Numerics.Geometry.Point;
using Numerics.Algorithms.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Numerics.NumberSystems;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Point[] v = new Point[6];
            // v[0] = new Point(0, false, "F");
            // v[1] = new Point(9999, false, "A");
            // v[2] = new Point(9999, false, "B");
            // v[3] = new Point(9999, false, "C");
            // v[4] = new Point(9999, false, "D");
            // v[5] = new Point(9999, false, "E");
            // Ribs[] rebras = new Ribs[10];
            // rebras[0] = new Ribs(v[0], v[2], 8);
            // rebras[1] = new Ribs(v[0], v[3], 4);//FC
            // rebras[2] = new Ribs(v[0], v[1], 9);//FA
            // rebras[3] = new Ribs(v[2], v[3], 7);//bc
            // rebras[4] = new Ribs(v[2], v[5], 5);//be
            // rebras[5] = new Ribs(v[3], v[5], 5);//ce
            // rebras[6] = new Ribs(v[1], v[5], 6);//ae
            // rebras[7] = new Ribs(v[1], v[4], 5);//ad
            // rebras[8] = new Ribs(v[3], v[4], 4);//cd
            // rebras[9] = new Ribs(v[2], v[4], 7);//bd
            // DekstraAlgorithm da = new DekstraAlgorithm(v, rebras);
            // da.Run(v[0]);
            // //PrintGrath.Show(PrintGrath.PrintAllPoints(da));
            // try
            // {
            //     PrintGrath.Show(PrintGrath.PrintAllMinPaths(da));
            // }
            // catch(NullReferenceException ex)
            // {
            //     Console.WriteLine(ex.Message, ex.StackTrace);
            // }

            IEnumerable<Int32> aq = new []{ 1, 2, 78, 5, 100, 12, 3, 9 };
            foreach(Int32 item in aq)
            {
                Console.Write(item.ToString());
            }
            Console.WriteLine();
            IEnumerable<Int32> ad = MergeSort.Sort(aq);
            foreach (Int32 item in ad)
            {
                Console.Write(item.ToString());
            }
            Console.WriteLine();
            //IEnumerable<Int32> aw = SelectionSort.Sort<Int32>(aq);
            //foreach (Int32 item in aw)
            //{
            //    Console.WriteLine(item.ToString(), ",");
            //}

            TranslationNumbers aa = new TranslationNumbers();
            Int32 xx = aa.DecimalToBinary(25);
            Console.WriteLine(xx);
            Console.ReadKey(true);
        }
    }
}
