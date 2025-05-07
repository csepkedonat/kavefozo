using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace kavefozo
{
    internal class Kavefozo
    {
        public int Kave { get; set; }

        public int Viz { get; set; }

        public bool Hasznalt { get; set; }

        public string Minoseg { get; set; }

        public int Adag { get; set; }

        public Edeny Allapot { get; set; }

        public Edeny Edeny { get; set; }
        public Kavefozo()
        {
            Kave = 0;
            Viz = 0;
            Hasznalt = false;
            Minoseg = string.Empty;
            Adag = 0;
            Edeny = new Edeny("üres", "üres");
        }

        public void feltolt (string mivel, int mennyit)
        {
            
            if (mivel == "kave")
            {
                if (Hasznalt == true)
                {
                    Console.WriteLine("A gépben használt kávé van, először ürítsd ki!");
                }
                else
                {
                    if (mennyit > 0 && mennyit < 7)
                    {
                        if (mennyit > 6 - Kave)
                        {
                            Console.WriteLine($"A gépbe már csak {6 - Kave} adag kávé fér");
                        }
                        else
                        {
                            Kave = mennyit+Kave;
                            Hasznalt = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Maximum 6 adag kávé fér a gépbe");
                    }
                }
            }
            else if (mivel == "viz")
            {
                if (mennyit > 0 && mennyit < 11)
                {
                    if (mennyit > 10 - Viz)
                    {
                        Console.WriteLine($"A gépbe már csak {10 - Viz} adag víz fér");
                    }
                    else
                    {
                            Viz = mennyit+Viz;
                    }
                }
                else
                {
                    Console.WriteLine("Maximum 10 adag víz fér a gépbe");
                }
                
            }
        }

        public void kiurit (string mit)
        {
            if (mit == "kave")
            {
                Kave = 0;
                Hasznalt = false;
            }
            else if (mit == "viz")
            {
                Viz = 0;
            }
        }

        public void foz()
        {
            if (Kave < 1)
            {
                Console.WriteLine("Kifogyott a kávé, töltsd fel!");
            }
            else if (Viz < 1)
            {
                Console.WriteLine("Kifogyott a víz, töltsd fel!");
            }
            else
            {
                if (Hasznalt == true)
                {
                    Minoseg = "Pocsék";
                    Edeny.Minoseg = "Pocsék";
                }
                else if (Kave > Viz)
                {
                    Minoseg = "Túl erős";

                    if (Edeny.Minoseg == "Pocsék")
                    {
                        Edeny.Minoseg = "Pocsék";
                    }
                    else
                    {
                        Edeny.Minoseg = "Túl erős";
                    }
                    
                }
                else
                {
                    Minoseg = "Tökéletes";

                    if (Edeny.Minoseg == "Pocsek")
                    {
                        Edeny.Minoseg = "Pocsék";
                    }
                    else if (Edeny.Minoseg == "Túl erős")
                    {
                        Edeny.Minoseg = "Túl erős";
                    }
                    else
                    {
                        Edeny.Minoseg = "Tökéletes";
                    }
                }

                Console.WriteLine($"Főztél {Kave} adag kávét");

                Adag = Kave;

                Hasznalt = true;

                Viz = Viz - Kave;

                Kave = 0;
            }
        }

        public void kostol()
        {
            Console.WriteLine($"Ez a kávé {Edeny.Minoseg}");
        }

        public void kiont()
        {
            if (Adag != 0)
            {
                Adag = 0;
                Edeny.Minoseg = "üres";
            }
            else
            {
                Console.WriteLine("Az edény üres");
            }
        }

        public void ranez()
        {
            Console.WriteLine(Kave);
            Console.WriteLine(Viz);

            if (Hasznalt == true)
            {
                Console.WriteLine("Használt kávé van benne");
            }
            else if (Kave > 0)
            {
                Console.WriteLine("Új kávé van benne");
            }

            if(Edeny.Minoseg == "üres")
            {
                Console.WriteLine("Az edény üres");
            }
            else
            {
                Console.WriteLine($"Az edényben {Adag} adag {Edeny.Minoseg} kávé van");
            }
            
            
        }

    }
}
