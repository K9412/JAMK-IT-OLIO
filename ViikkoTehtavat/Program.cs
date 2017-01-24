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
            //Tehtava7();
            //Tehtava8();
            //Tehtava9();
            //Tehtava10();
            //Tehtava11();
            Tehtava12();
            //Tehtava13();
            //Tehtava14();
            //Tehtava15();
            //Tehtava16();
            //Tehtava17();
            //Tehtava18();
            //Tehtava19();
            
        }

        static void Tehtava1()
        {
            //Tee ohjelma, joka tulostaa k„ytt„j„n antamaa lukua (1, 2 tai 3) vastaavan 
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
            //Tee ohjelma, joka kysyy k„ytt„j„lt„ kolme lukua ja tulostaa niiden summan 
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
            //Tee ohjelma, jossa kysyt„„n k„ytt„j„lt„ t„m„n ik„. Jos ik„ on alle 18 vuotta, 
            //tulosta "alaik„inen", jos se on 18-65 vuotta, tulosta "aikuinen", 
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
            //Tee ohjelma, joka n„ytt„„ annetun sekuntim„„r„n tunteina, minuutteina ja sekunteina. Aikam„„re sekuntteina kysyt„„n k„ytt„j„lt„. 
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
            //matkalla (kysyt„„n k„ytt„j„lt„) kuluvan bensan m„„r„n sek„ bensaan menev„n rahan m„„r„n. 
            Console.Write("Anna matka > ");
            string retval = Console.ReadLine();
            double matka = int.Parse(retval);
            double hinta = 1.595, kulutus = 7.02;
            double kulutusLopullinen, kustannus;
            kulutusLopullinen = Math.Round(((matka / 100) * kulutus), 2);
            kustannus = Math.Round((kulutusLopullinen * hinta), 2);

            Console.WriteLine("Bensaa kuluu {0} litraa, kustannus {1} euroa", kulutusLopullinen, kustannus);
        }
        static void Tehtava7()
        {
            //Tee ohjelma, joka nayttaa onko annettu vuosi karkausvuosi. Vuosiluku kysytaan kayttajalta. 
            Console.Write("Anna vuosi > ");
            string retval = Console.ReadLine();
            int vuosiluku = int.Parse(retval);
            if ( (vuosiluku % 4) == 0 && (vuosiluku % 100) != 0 || (vuosiluku % 400) == 0 )
            {
                Console.WriteLine("Vuosi on karkausvuosi.");
            }
            else
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi.");
            }
        }
        static void Tehtava8()
        {
            //Tee ohjelma, joka kysyy k„ytt„j„lt„ 3 kokonaislukua ja tulostaa niist„ suurimman. 
            int[] numbers = new int[3];
            for(int x = 0; x < numbers.Length; x++)
            {
                Console.Write("Anna luku > ");
                string returnValue = Console.ReadLine();
                int temp = int.Parse(returnValue);
                numbers[x] = temp;
            }
            Array.Sort(numbers);
            Console.WriteLine("Suurin luku on {0}", numbers[2]);
        }
        static void Tehtava9()
        {
            //Tee ohjelma, joka kysyy k„ytt„j„lt„ lukuja, kunnes h„n sy”tt„„ luvun 0. 
            //Ohjelman tulee tulostaa sy”tettyjen lukujen summa. 
            int summa = 0;
            int temp;
            do
            {
                Console.Write("Anna luku > ");
                string returnValue = Console.ReadLine();
                temp = int.Parse(returnValue);
                summa += temp;
            } while (temp != 0);
            Console.WriteLine("Lukujen summa on {0}", summa);
        }
        static void Tehtava10()
        {
            //Tee ohjelma, joka alustaa sovellukseen k„ytt”” seuraavan taulukon arvot 
            //= [1,2,33,44,55,68,77,96,100]. K„y sovelluksessa taulukko l„pi ja tulosta ruutuun 
            //"HEP" -sana aina kun taulukossa oleva luku on parillinen. 
            int[] taulukko = new int[] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            for(int x = 0; x < taulukko.Length; x++)
            {
                Console.Write(taulukko[x]);
                if(taulukko[x] % 2 == 0)
                {
                    Console.Write(" HEP");
                }
                Console.WriteLine();
            }
        }
        static void Tehtava11()
        {
            /* Tee kahden sis„kk„isen for-silmukan avulla ohjelma, joka tulostaa seuraavanlaisen kuvion:
                *
                **
                ***
                ****
                ***** */
            Console.Write("Anna luku > ");
            string returnValue = Console.ReadLine();
            int luku = int.Parse(returnValue);
            for(int x = 0; x < luku; x++)
            {
                Console.Write("*");
                for(int y = 0; y < x; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Tehtava12()
        { 
            //Tee ohjelma, joka kysyy k„ytt„j„lt„ 5 kokonaislukua. Luvut tulee sijoittaa taulukkoon. 
            //Ohjelman tulee tulostaa annetut luvut k„„nteisess„ j„rjestyksess„.
            int[] taulukko = new int[5];
            for(int x = 0; x < taulukko.Length; x++)
            {
                Console.Write("Anna luku > ");
                string returnValue = Console.ReadLine();
                taulukko[x] = int.Parse(returnValue);
            }
            Console.Write("Luvut ovat ");
            for (int x = 4; x >= 0; x--)
            {
                Console.Write("{0}, ", taulukko[x]);
            }
        }
        static void Tehtava13()
        {
            //M„kihypyss„ k„ytet„„n viitt„ arvostelutuomaria. Kirjoita ohjelma, joka kysyy arvostelupisteet 
            //yhdelle hypylle ja tulostaa tyylipisteiden summan siten, ett„ summasta on v„hennetty pois 
            //pienin ja suurin tyylipiste. 
            int[] pisteTaulukko = new int[5];
            for(int x = 0; x < pisteTaulukko.Length; x++)
            {
                Console.Write("Anna pisteet > ");
                string returnValue = Console.ReadLine();
                pisteTaulukko[x] = int.Parse(returnValue);
            }
            Array.Sort(pisteTaulukko);
            int kokonaisPisteet = pisteTaulukko[1] + pisteTaulukko[2] + pisteTaulukko[3];
            Console.WriteLine("Kokonaispisteet ovat {0}", kokonaisPisteet);
        }
        static void Tehtava14()
        {
            //Kirjoita ohjelma, joka pyytaa kayttajalta opiskelijoiden arvosanat 0-5 ja tulosta ne kayttaen tahtimerkkeja
            int[] arvosanat = new int[6] { 0, 0, 0, 0, 0, 0 };
            string returnValue;
            Console.WriteLine("Anna opiskelijoiden arvosanat. Voit lopettaa arvosanojen syoton kirjoittamalla exit");
            do
            {
                Console.Write("Anna arvosana > ");
                returnValue = Console.ReadLine();
                if(returnValue != "exit")
                {
                    int temp = int.Parse(returnValue);
                    switch(temp)
                    {
                        case 0:
                            arvosanat[0]++;
                            break;
                        case 1:
                            arvosanat[1]++;
                            break;
                        case 2:
                            arvosanat[2]++;
                            break;
                        case 3:
                            arvosanat[3]++;
                            break;
                        case 4:
                            arvosanat[4]++;
                            break;
                        case 5:
                            arvosanat[5]++;
                            break;
                        default:
                            Console.WriteLine("VIRHE! KOKEILE UUDESTAAN!");
                            break;
                    }
                }
            } while (returnValue != "exit");
            Console.WriteLine("Arvosanat:");
            for (int x = 0; x < arvosanat.Length; x++)
            {
                Console.Write("{0}: ", x);
                for(int y = 0; y < arvosanat[x]; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Tehtava15()
        {
            //Tee ohjelma, joka tulostaa seuraavanlaisen kuvion. Kysy käyttäjältä puunkorkeus käytä juurena 
            //kaksi korkeuden yksikkö. 
            Console.Write("Anna luku > ");
            string returnValue = Console.ReadLine();
            int annettuLuku = int.Parse(returnValue);

            for(int x = 0; x < (annettuLuku - 2); x++)
            {
                int valilyonnit = (annettuLuku - 2) - x;
                for(int y = 0; y <= valilyonnit; y++)
                {
                    Console.Write(" ");
                }
                for(int z = 0; z <= (x * 2); z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for(int x = 0; x < 2; x++)
            {
                for(int y = 0; y <= (annettuLuku - 2); y++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
        }
        static void Tehtava16()
        {
            //Tee ohjelma, joka arpoo satunnaisluvun väliltä 0-100. 
            //Tämän jälkeen ohjelman käyttäjää kehoitetaan arvaaman arvottu luku.
            Random rnd = new Random();
            int arvattavaLuku = rnd.Next(1, 100);
            int arvaustenMaara = 0;
            string returnValue;
            int annettuLuku;

            do
            {
                Console.Write("Arvaa luku > ");
                returnValue = Console.ReadLine();
                annettuLuku = int.Parse(returnValue);
                if (annettuLuku > arvattavaLuku)
                {
                    Console.WriteLine("Luku on pienempi.");
                }
                if (annettuLuku < arvattavaLuku)
                {
                    Console.WriteLine("Luku on suurempi.");
                }
                if (annettuLuku > 100 || annettuLuku < 1)
                {
                    Console.WriteLine("Luku on valilta 1-100.");
                }
                arvaustenMaara++;

            } while (annettuLuku != arvattavaLuku);

            Console.WriteLine("Hienoa, arvasit luvun {0} kerralla.", arvaustenMaara);
                

        }
        static void Tehtava17()
        {
            //Tee ohjelma, joka lajittelee kahdessa kokonaislukutaulukossa olevat alkiot suurusjärjestykseen 
            //kolmanteen kokonaislukutaulukkoon.
            int[] t1 = new int[] {10, 20, 30, 40, 50 };
            int[] t2 = new int[] {5, 15, 25, 35, 45 };
            int[] t3 = new int[] { };

            Console.WriteLine("Luvut taulukossa 1 : {0}, {1}, {2}, {3}, {4}", t1[0], t1[1], t1[2], t1[3], t1[4]);
            Console.WriteLine("Luvut taulukossa 2 : {0}, {1}, {2}, {3}, {4}", t2[0], t2[1], t2[2], t2[3], t2[4]);
            t3 = t1.Concat(t2).ToArray();
            Array.Sort(t3);
            Console.Write("Luvut yhdistetyssa taulukossa : ");
            for(int x = 0; x < t3.Length; x++)
            {
                Console.Write("{0}, ", t3[x]);
            }
        }
        static void Tehtava18()
        {
            //Tee ohjelma, joka kysyy käyttäjältä merkkijonon (lause). Sovelluksen tulee ilmoittaa käyttäjälle 
            //oliko annettu merkkijono palidromi. 
            Console.Write("Anna jokin lause > ");
            string lause = Console.ReadLine();
            lause = lause.ToLower();
            char[] temp = lause.ToCharArray();
            Array.Reverse(temp);
            string lause2 = new string(temp);

            int test = string.Compare(lause, lause2);
            if(test == 0)
            {
                Console.WriteLine("Lauseesi on palindromi.");
            }
            else
            {
                Console.WriteLine("Lauseesi ei ole palindromi.");
            }  
        }
        static void Tehtava19()
        {
            //Tee tekstipohjainen Hirsipuu-peli. Voit kovakoodata arvattavan sanan ja toteuta looppi, 
            //jossa käyttäjältä kysytään seuraavaa kirjainta.
            char[] arvattavaSana = new char[] { 's', 'a', 'l', 'a', 's', 'a', 'n', 'a' };
            char[] alaViivat = new char[] { '_', '_', '_', '_', '_', '_', '_', '_' };
            char[] vaaratKirjaimet = new char[3] { ' ', ' ', ' ' };
            char arvaus;
            int maxArvaukset = 3;
            int arvauksetCounter = 0;

            Console.WriteLine("HIRSIPUU!!");
            Console.WriteLine("Aloita peli antamalla kirjain");
            
            //jos alaViivat array ei sisalla enaa '_' merkkia, peli on voitettu.
            //eli siis aina kun oikea kirjain loytyy, se sijoitetaan alaViivat
            //arrayyn sita vastaavalle paikalle.
            while (alaViivat.Contains('_'))
            {
                Console.Write("Anna kirjain > ");
                arvaus = Console.ReadKey().KeyChar;
                Console.WriteLine();
                //taalla sijoitetaan kirjaimia alaViivat arrayyn niin kauan kuin osumia loytyy
                if (arvattavaSana.Contains(arvaus))
                {
                    while (arvattavaSana.Contains(arvaus))
                    {
                        int indeksi = Array.IndexOf(arvattavaSana, arvaus);
                        alaViivat[indeksi] = arvaus;
                        //sijoitetaan arvattavaSana arrayyn arvattua kirjainta vastaavalle paikalle '0', etta
                        //voidaan etsia seuraava mahdollinen osuma
                        arvattavaSana[indeksi] = '0';
                    }
                }
                //jos ei osumaa
                else
                {
                    vaaratKirjaimet[arvauksetCounter] = arvaus;
                    arvauksetCounter++;
                    if (arvauksetCounter >= maxArvaukset)
                    {
                        Console.Clear();
                        Console.WriteLine("Olet hirressä!");
                        return;
                    }
                }
                Console.Clear();
                Console.WriteLine(alaViivat);
                Console.WriteLine("Arvauksia jaljella: {0}", (maxArvaukset - arvauksetCounter));
                Console.Write("Vaarat arvaukset: ");
                //tulostetaan vaarin arvatut kirjaimet
                for (int x = 0; x < arvauksetCounter; x++)
                {
                    Console.Write(vaaratKirjaimet[x]);
                    Console.Write("   ");
                }
                
            }
            Console.WriteLine("VOITIT PELIN!");
        }
    }
}
