using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViikkoTehtavat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tehtava1();
            //Tehtava2();
            //Tehtava3();
        }

        static void Tehtava1()
        {
            //Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan 
            //luvun sanana (yksi, kaksi tai kolme).
            Console.Write("Anna luku > ");
            string retval = Console.ReadLine();
            int luku = int.Parse(retval);
            switch(luku)
            {
                case 1:
                    Console.WriteLine("Annoit luvun yksi");
                    break;
                case 2:
                    Console.WriteLine("Annoit luvun kaksi");
                    break;
                case 3:
                    Console.WriteLine("Annoit luvun kolme");
                    break;
                default:
                    Console.WriteLine("Joku muu luku");
                    break;
            }
            

        }
        static void Tehtava2()
        {
            //Tee ohjelma, jossa annetaan oppilaalle koulunumero
            //pistemaara kysytaan ja ohjelma tulostaa numeron
            Console.Write("Anna pistemaara > ");
            string retval = Console.ReadLine();
            int pisteet = int.Parse(retval);
            switch(pisteet)
            {
                case 0:
                case 1:
                    Console.WriteLine("Koulunumero on 0");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("Koulunumero on 1");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Koulunumero on 2");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Koulunumero on 3");
                    break;
                case 8:
                case 9:
                    Console.WriteLine("Koulunumero on 4");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Koulunumero on 5");
                    break;
                default:
                    Console.WriteLine("Virhe!");
                    break;
            }
        }
        static void Tehtava3()
        {
            //Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan 
            //ja keskiarvon. 
            Console.WriteLine("Anna kolme lukua.");
            string[] retval = new string[3];
            int[] luvut = new int[3];
            for (int x = 0; x < retval.Length; x++)
            {
                Console.Write("Luku {0} > ", (x + 1));
                retval[x] = Console.ReadLine();
                luvut[x] = int.Parse(retval[x]);
            }
            int summa, keskiarvo;
            summa = luvut[0] + luvut[1] + luvut[2];
            keskiarvo = (summa / 3);
            Console.WriteLine("Lukujesi summa: {0}, ja keskiarvo: {1}", summa, keskiarvo);
        }
    }
}
