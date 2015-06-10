using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {/**1. Írj egy programot, amely egy N elemet tartalmazó tömbről megmondja, hogy a szomszédos
        elemek között mekkora legnagyobb különbség!
      **/
        static int[] TMB = new int[10];
        static int i;
        static int j;
        static void biggestdifference()
        {
            Console.WriteLine("Kérem adjon meg 10 számot.");
            for (i = 0; i < TMB.Length; i++)
            {
                

                TMB[i] = Int32.Parse(Console.ReadLine());
                

            }              

            Console.WriteLine("Köszönöm.");

            Console.WriteLine("A megadott legnagyobb szám: {0} ", TMB.Max());
            Console.WriteLine("A megadott legkisebb szám: {0}", TMB.Min());
            Console.WriteLine("Ezen számok különbsége: {0}-{1}={2}", TMB.Max(), TMB.Min(), TMB.Max() - TMB.Min());
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            biggestdifference(); // Valamiért nem jövök rá hogy kell két szomszédos elem között megvizsgálni a legnagyobb különbséget csak a max és min között tudom.
        }
    }
}
