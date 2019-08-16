using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObligOppgave
{
    class Program
    {
        static void Main(string[] args)
        {

            Personer kongen = new Personer(_firstName: "Harald", "N/A", 1937, "N/A", 2);
            Personer ingrid = new Personer("Ingrid Alexandra", "N/A", 2004, "N/A", 7);
            Personer olav = new Personer("Olav", "N/A", 1903, "1991", 1);
            Personer mette = new Personer("Mette Marit", "Høiby", 1973, "N/A", 5);
            Personer marius = new Personer("Marius", "Borg Høiby", 1997, "N/A", 6);
            Personer sverre = new Personer("Sverre Magnus", "N/A", 2005, "N/A", 8);
            Personer sonja = new Personer("Sonja", "Haraldsen", 1937, "N/A", 3);
            Personer haakon = new Personer("Haakon Magnus", "N/A", 1973, "N/A", 4);

            sverre.father = haakon;
            sverre.mother = mette;
            ingrid.father = haakon;
            ingrid.mother = mette;
            marius.mother = mette;
            haakon.father = kongen;
            haakon.mother = sonja;
            kongen.father = olav;

            List<Personer> kongefamilien = new List<Personer>(8)
            {
                olav,
                kongen,
                sonja,
                haakon,
                mette,
                marius,
                ingrid,
                sverre
            };

            Show();
            start:
            Console.WriteLine();
            var answer = Console.ReadLine().ToUpper();
            Console.WriteLine();
            if (answer == "HJELP")
            {
                Console.WriteLine("Liste => lister alle personer med id, fornavn, fødselsår, dødsår og navn og id på mor og far om det finnes registrert.");
                Console.WriteLine("Id => viser en bestemt person med mor, far og barn. Eksempel id 5");
            }
            if (answer == "LISTE")
            {
                foreach (var a in kongefamilien)
                {
                    a.Print();
                }
            }
            else if (answer.Contains("ID "))
            {
                var answerId = answer.Substring(3);
                var x = Int32.Parse(answerId);
                for (var i = 0; i < kongefamilien.ToArray().Length; i++)
                {
                    if (kongefamilien[i].id.Equals(x))
                    {
                        kongefamilien[i].Print();
                        var familie = kongefamilien[i];
                        foreach (var a in kongefamilien)
                        {
                            if (a.father == familie || a.mother == familie) a.Print();
                        }
                    }
                }
            }

            goto start;
        }

        private static void Show()
        {
            Console.WriteLine("Velkommen til det kongelige slektstreet!");
            Console.WriteLine("Dette er kommandoene du kan skrive:");
            Console.WriteLine("Hjelp");
            Console.WriteLine("Liste");
            Console.WriteLine("Vis ID");
        }

    }
}
