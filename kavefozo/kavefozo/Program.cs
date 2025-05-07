using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kavefozo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kavefozo kave = new Kavefozo();

            bool kilepes = false;

            List<int> valasztasok = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            string valasztas;

            while (!kilepes)
            {
                Console.WriteLine("\nKávéfőző menü:");
                Console.WriteLine();
                Console.WriteLine("1. Kávégép feltöltése");
                Console.WriteLine("2. Kávégép kiürítése");
                Console.WriteLine("3. Kávéfőzés");
                Console.WriteLine("4. Kávé megkóstolása");
                Console.WriteLine("5. Edény kiöntése");
                Console.WriteLine("6. Állapot megtekintése");
                Console.WriteLine("7. Kilépés");
                Console.WriteLine();
                Console.Write("Válassz egy opciót: ");

                valasztas = Console.ReadLine();

                Console.WriteLine();

                if (int.TryParse(valasztas, out int valasztasi))
                {
                    if (valasztasok.Contains(valasztasi))
                    {
                        switch (valasztasi)
                        {
                            case 1:
                                Console.WriteLine("Mit szeretne bele tölteni? (kave, viz)");
                                string mit = Console.ReadLine();

                                Console.WriteLine("Hány adagot szeretne beletölteni?");
                                int mennyit = int.Parse(Console.ReadLine());

                                kave.feltolt(mit, mennyit);
                                break;

                            case 2:
                                Console.WriteLine("Mit szeretne kiönteni? (kave, viz)");
                                string mit2 = Console.ReadLine();

                                kave.kiurit(mit2);
                                break;

                            case 3:
                                kave.foz();
                                break;

                            case 4:
                                kave.kostol();
                                break;

                            case 5:
                                kave.kiont();
                                break;

                            case 6:
                                kave.ranez();
                                break;

                            case 7:
                                kilepes = true;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("A válasz nem szerepel az opciók között.");
                    }
                }
                else
                {
                    Console.WriteLine("Nem megfelelő formátum");
                }
            }
        }
    }
}
