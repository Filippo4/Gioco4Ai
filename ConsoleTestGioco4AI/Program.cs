using LibreriaClassiGioco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestGioco4AI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Umano u1  = new Umano(Schieramento.Bene);
                Personaggio p1 = new Personaggio("Filippo", u1);
                Stregoni s1 = new Stregoni(Schieramento.Male);
                Personaggio p2 = new Personaggio("Franco", s1);

                Console.WriteLine($"{p1.nome} attacca {p2.nome}");
                p1.Attacca(p2);
                Console.WriteLine($"Filippo ha {p1.GetVita()}hp\nFranco ha {p2.GetVita()}hp");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
