using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scorebord
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = true;
            string name;
            List<Persoon> personen = new List<Persoon>();
            do
            {
                Console.WriteLine("Geef en naam om een speler toe te voegen of typ stop om te stoppen");
                name = Console.ReadLine();
                if (name.ToUpper() != "STOP")
                {
                    personen.Add(new Persoon() { Naam = name, Score = 0 });
                }
                else
                {
                    stop = false;
                }
            } while (stop);

            stop = true;

            Console.Clear();
            Console.WriteLine("NAAM\t\t|SCORE");
            Console.WriteLine(new string('*', 50));

            do
            {
                foreach (var item in personen)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Geef naam van de speler om score te verhogen");
                name = Console.ReadLine();

                if (name.ToUpper() != "STOP")
                {
                    //personen.Find(e => e.Name == name).Score++;   ////doet hetzelfde
                    for (int i = 0; i < personen.Count; i++)
                    {
                        if (personen.ElementAt(i).Naam == name)
                        {
                            Console.Clear();
                            personen.ElementAt(i).Score++;
                        }
                    }
                }
                else
                stop = false;
            } while (stop);
            Console.ReadLine();
        }
    }

    class Persoon
    {
        public string Naam { get; set; }
        public int Score { get; set; }

        public override string ToString()
        {
            return Naam +"\t\t|" + Score;
        }
    }
}