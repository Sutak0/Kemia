using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Adatok> ujlista = new List <Adatok> ();

            using (StreamReader sr = new StreamReader("felfedezesek.csv"))
            {

                sr.ReadLine();
                do
                {
                    string sor = sr.ReadLine();
                    Adatok sor1 = new Adatok();
                    ujlista.Add(sor1);

                } while (!sr.EndOfStream);

                Console.WriteLine($"3-as feladat: \t Kemia elemek felfedezesi adatai:  {ujlista.Count} ");

                int Okor = ujlista.Where(x=>x.Ev == "Okor").Count();
                Console.WriteLine($"4-es feladat: \t Az ókorbn felfedezett kémiai elemek száma: {Okor}");

                //5 
               /* string betujel = sr.ReadLine();
                while (true)
                {

                } */

                //6
                Console.WriteLine("6-os feladat: ");
                foreach (var item in ujlista)
                {
                    int vegyjel = ujlista.Where(x => x.Vegyjel == "SG" && x.Vegyjel == "sg").Count();
                    if (true)
                    {
                        Console.WriteLine($"Adatai:\t Éve:  {item.Ev} \t , Neve: {item.Nev} \t , Vegyjele: {item.Vegyjel} \t , Rendszáma: {item.Rendszam} \t , Felfedezője:  {item.Felfedezo} ");
                    }

                    else {

                        Console.WriteLine("Nincs ilyen elem az adatforrásban!");
                    
                    }

                }

                //7
                Console.WriteLine("7-es feladat: ");

            }
        }
    }
}
