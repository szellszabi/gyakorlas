using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazifeladat1
{  // 1. KÉszits egy eljárást : ami egy megosztott tömb elemeit bekéri a bill röl de CSAK pozotiv számokat fogad el.
//2.: ami egy megosztott tömb elemeit bekéri a billröl de nem engedi meg azonos elem beolvasását.
//3.: ami egy megosztott tömb elemeit véletlen számokkal tölti fel a véletlen számoknak pedig 450 és 910 közé kell esnie.
//4.: ami meghatározza egy megosztott tömb elemei közül a legnagyobb értéküt és ezt az értéket elhelyezi egy max nevü megoszott változóba.
//5.:							legkisebb					     egy min nevü megosztott változoba rak
//6.: ami meghatározza   max elemet és a min elemet és a min vált
//7.: ami egy feltoltott megosztott tömb alapján meghtaározza hogy a tömbben hánykülönbözöérték szerepel és az eredmény elhelyezi egy megosztott egy külön db változóba.||| nem tudtam
//8.: ami egy feltölött megosztott tömb elemeit végig olvasva kiirja a képernyöre hogy a tömb elemeit növekvö sorrandbe vannak e renezve vagy
    // csökkenö sorrendbe vannak e rendezve vagy egyáltalán nincsenek rendezve.|||nemtudtam
//9.: ami egy hossz nevü megosztott változoba megadja a már feloltott megoszott tömb elemei közül a leghosszabb azonos értékü egymésmellett található elemek számát.||| nem tudtam

    class Program
    {
         static int Min = 450;
        static int Max = 910;
        static int[] TMB = new int[10];
        static void pozszam()
        {
            Console.WriteLine("Kérem adjon meg 10 darab pozitív egész számot.");
            for (int i = 0; i < TMB.Length; i++)
            {
                String poz = Console.ReadLine();
                TMB[i] = Int32.Parse(poz);
                if (TMB[i]>0)
                {
                    Console.WriteLine("A megadott szám {0} helyes.", TMB[i]);                    
                }
                else
                    Console.WriteLine("A megadott szám helytelen.");
            }
        }
        static void nemazonelem()
        {
            for (int i = 0; i < TMB.Length; i++)
            {
                String poz = Console.ReadLine();
                TMB[i] = Int32.Parse(poz);
                if (TMB[i].Equals(TMB[i]))
                {
                    Console.WriteLine("A megadott szám megegyezik egy másik számmal.", TMB[i]);
                    Console.ReadLine();
                    // nem jo
                }               
            }
           

               
            
        }
            static void randomszamok(){ 
                int Min = 450;
                int Max = 910;
                Random randNum = new Random();
                
                for (int i = 0; i < TMB.Length; i++)
                {
                    TMB[i] = randNum.Next(Min, Max);
                    Console.ReadLine();
                }// nem jo 
            }
            static void legnagyobbertek()
            {
                int Max=0;
                Console.WriteLine(TMB.Max(element => Math.Abs(element)));
                
                Console.ReadLine();
            }// nem jo
        
        
           



                

                
        
        static void Main(string[] args)
        {
            pozszam();
            legnagyobbertek();

            


           
                
        }
    }
}
