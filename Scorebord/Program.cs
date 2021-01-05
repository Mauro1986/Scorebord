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
            Persoon s1 = new Persoon();
            s1.Naam = "emre";

            List<Persoon> Personen = new List<Persoon>();
            Persoon.add (s1);
            
            List<student> Students = new List<student>
            {
            new Persoon(){Id=1, Name="Toon" },
            new Persoon(){Id=2, Name="Emre" },
            new Persoon(){Id=3, Name="Jan" }
            };


            foreach (var item in Students)
            {
                Console.WriteLine(item);
            }

        }

    }


     class Persoon
    {
    public string Naam { get; set; }
    public int Score { get; set; }
    }
}