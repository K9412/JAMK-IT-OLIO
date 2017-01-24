using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demot
{
    class Ikkuna
    {
        //properties
        public float Leveys { get; set; }
        public float Korkeus { get; set; }
        public float Pintaala
        {
            get
            {
                return Leveys * Korkeus;
            }
        }
        public float Piiri
        {
            get
            {
                return 2 * (Leveys + Korkeus);
            }
        }
        //constructors
        public Ikkuna()
        {
            //oletusconstructor
        }
        public Ikkuna(float leveys, float korkeus)
        {
            Korkeus = korkeus;
            Leveys = leveys;
        }
        //methods
        public float LaskePintaala()
        {
            return Leveys * Korkeus;
        }
        public float LaskePiiri()
        {
            return 2 * (Leveys + Korkeus);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OOIkkunaDemo();
        }

        static void OOIkkunaDemo()
        {
            //ohjelma laskee ikkunan pinta-alan ja piirin
            float Leveys = 0;
            float Korkeus = 0;
            float Ala = 0;
            float Piiri = 0;
            //kysytään käyttäjältä mitat
            Console.Write("Anna leveys millimetreina: ");
            string temp = Console.ReadLine();
            Leveys = float.Parse(temp);
            Console.Write("Anna korkeus millimetreina: ");
            temp = Console.ReadLine();
            Korkeus = float.Parse(temp);
            Ala = Leveys * Korkeus;
            Piiri = 2 * (Leveys + Korkeus);
            Console.WriteLine("Ikkunan pinta-ala on {0} ja piiri on {1}", Ala, Piiri);

            //sama homma olion avulla
            Ikkuna ikkuna = new Demot.Ikkuna();
            ikkuna.Leveys = Leveys;
            ikkuna.Korkeus = Korkeus;
            //Ala = ikkuna.LaskePintaala();
            Ala = ikkuna.Pintaala;
            //Piiri = ikkuna.LaskePiiri();
            Piiri = ikkuna.Piiri;
            Console.WriteLine("Olion avulla lasketun ikkunan pinta-ala on {0} ja piiri on {1}", Ala, Piiri);
            //kokeillaan puolta pienemmalla ikkunalla toista konstruktoria
            Ikkuna ikkuna2 = new Ikkuna(Leveys/2, Korkeus/2);
            Console.WriteLine("Olion avulla lasketun ikkunan 2 pinta-ala on {0} ja piiri on {1}", ikkuna2.Pintaala, ikkuna2.Piiri);
        }
    }
}
