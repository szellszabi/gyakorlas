using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazifeladat3
{
    //1. ird át a tömb legnagyobb és legkisebb elemét megkereső eljárásokat függvénnyé.
    //2. készits egy olyan függvényt amelyik egy téglalap beolvasott két oldal hosszanak ismeretében kiszáolja és vissza adja atéglalap területét.
    //3.készits egy függvényt amelyik meghatározza egy adott számról(int) hogy ennek a számnak hány pozitív egész osztólya van.
    //4. készits egy függvény amelyik egy számról meghatározza hogy prím szám e vagy sem.(logikai igazt vagy hamist adjon vissza eredményül)
    //5. készits egy függvény amelyik megszámolja hogy egy adott érték hányszor szerepel a tömbben.
    //6. késztisünk egy függvény amelyik kiszámolja egy tömb elemeinek átlagát.
    //7.készitsünk egy függvény amely meghatározza hogy egy tömbben hány oolyan elem van amelynek értéke meg haladja tömb átlagát.(használd föl az elözö függvényt.)

    class Program
    {
         static int[] TMB = new int[10];
         static int 2teglalap()
         {
             int tter = 0;
             int a = 0;
             int b = 0;
             Console.WriteLine("Kérem adja meg egy téglalap A és B oldalát.");
             for (int i = 0; i < 2; i++)
             {
                 a = Int32.Parse(Console.ReadLine());
                 b = Int32.Parse(Console.ReadLine());
                 Console.WriteLine("A = {0} . B = {1}", a, b);
                 if (a > 0 && b > 0)
                 {
                     tter = a * b;
                 }
                 Console.WriteLine("A téglalap területe = {0}", tter);
                 Console.ReadLine();
                 return tter;

             }
            
         }
          static int 3hanyoszto()
         {
              int a = 0;
              int sumosztok=0;
              int[] osztok =new int[100] ;
             
              for (int i=0;i<osztok.Length;i++)
              {
                  osztok[i]+=1;
                 
                if (a%osztok[i]) 
                {
                    Console.WriteLine(osztok[i]);
                    sumosztok+=osztok[i];
                }
                else 
                    Console.WriteLine("Nincs a számnak osztója.");

              } 
              Console.ReadLine();


         }
        static bool 4primszam()
        {
            int a = 0;
            int oszto=0;
            bool prim = true;
            for (int i=0;i<TMB.Length;i++){
                if (oszto==1 || a%oszto==1){// a feltétel nem jo :/
                    Console.WriteLine("A szám prím.");
                }
                return prim;
                return false;
                
            }

        }

        static void Main(string[] args)
        {
            
            

            }
        }
    }
}

