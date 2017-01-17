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
            //Tehtava4();
            //Tehtava5();
            //Tehtava6();
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
        static void Tehtava4()
        {
            //Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta, 
            //tulosta "alaikäinen", jos se on 18-65 vuotta, tulosta "aikuinen", 
            //muussa tapauksessa tulosta "seniori". 
            Console.Write("Anna ikasi > ");
            string retval = Console.ReadLine();
            int ika = int.Parse(retval);
            if (ika < 18)
            {
                Console.WriteLine("Alaikainen");
                return;
            }
            if (ika >= 18 && ika <= 65)
            {
                Console.WriteLine("Aikuinen");
                return;
            }
            Console.WriteLine("Seniori");
            
        }
        static void Tehtava5()
        {
            //Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina. Aikamääre sekuntteina kysytään käyttäjältä. 
            Console.Write("Anna sekunnit > ");
            string retval = Console.ReadLine();
            int sekuntit = int.Parse(retval);
            int tunnit = (sekuntit / 3600);
            int minuutit = (sekuntit % 3600) / 60;
            int loput = (sekuntit % 3600) % 60;

            Console.WriteLine("Antamasi sekunttiaika voidaan ilmaista muodossa: {0} tunti {1} minuutti {2} sekuntti", tunnit, minuutit, loput);
        }
        static void Tehtava6()
        {
            //Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa. Tee ohjelma, joka tulostaa ajetulla 
            //matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän. 
            Console.Write("Anna matka > ");
            string retval = Console.ReadLine();
            double matka = int.Parse(retval);
            double hinta = 1.595, kulutus = 7.02;
            double kulutusLopullinen, kustannus;
            kulutusLopullinen = Math.Round(((matka / 100) * kulutus), 2);
            kustannus = Math.Round((kulutusLopullinen * hinta), 2);

            Console.WriteLine("Bensaa kuluu {0} litraa, kustannus {1} euroa", kulutusLopullinen, kustannus);
        }

    }
}
