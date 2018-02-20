using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

// Newtonsoft.json

namespace ListaJaTiedostot
{
    class Program
    {
        static void Main(string[] args)
        {
            Piste a = new Piste("A", 1, 2);
            Piste b = new Piste("B", 2, 3);
            Piste c = new Piste("C", 3, 4);

            // lista pisteistä
            List<Piste> pisteLista =
                new List<Piste>();
            pisteLista.Add(a);
            pisteLista.Add(b);
            pisteLista.Add(c);
            pisteLista.Add(new Piste("D", 4, 5));

            KirjoitaTiedostoon(pisteLista);

            PisteKaksi d = new PisteKaksi("D", 1, 2);
            PisteKaksi e = new PisteKaksi("E", 2, 3);
            PisteKaksi f = new PisteKaksi("F", 3, 4);

            // lista pisteistä
            List<PisteKaksi> pisteListaKaksi =
                new List<PisteKaksi>();
            pisteListaKaksi.Add(d);
            pisteListaKaksi.Add(e);
            pisteListaKaksi.Add(f);
            pisteListaKaksi.Add(new PisteKaksi("H", 4, 5));

            KirjoitaTiedostoon(pisteLista);

            // sarjallista yksi olio JSON-muotoon (using Newtonsoft.Json;)

            string jsonString = "{\"Nimi\":\"A\",\"X\":1.0,\"Y\":2.0}";
            Piste pp = JsonConvert.DeserializeObject<Piste>(jsonString);

            string jsonString2 = "[{\"Nimi\":\"A\",\"X\":1.0,\"Y\":2.0}, {\"Nimi\":\"B\",\"X\":1.0,\"Y\":2.0}]";
            List<Piste> plista = JsonConvert.DeserializeObject<List<Piste>>(jsonString2);
            Console.WriteLine("lista: " + pisteLista[0]); 

            string s = JsonConvert.SerializeObject(pisteLista);
            Console.WriteLine(s);

            // sarjallista lista olioita JSON-muotoon

            // luetaan tiedosto
            List<Piste> uudetPisteet = LueTiedosto();
            foreach (Piste item in uudetPisteet)
            {
                Console.WriteLine(item.ToString());
            }
        }
        /// <summary>
        /// Kirjoittaa listan sisällön tiedostoon
        /// </summary>
        /// <param name="pisteet">Lista pisteistä</param>
        static void KirjoitaTiedostoon(List<Piste> pisteet)
        {
            // alkuun using System.IO;
            // avataan tiedosto
            StreamWriter sw = new StreamWriter(@"C:\tmp\pisteet.txt");
            foreach (Piste item in pisteet)
            {
                sw.WriteLine(item.ToString());
            }
            // suljetaan tiedosto
            sw.Close();
        }

        /// <summary>
        /// Lukee pisteet tiedostosta
        /// </summary>
        /// <returns>lista tiedostosta luetuista pisteistä</returns>
        static List<Piste> LueTiedosto()
        {
            List<Piste> luetutPisteet = new List<Piste>();
            // avataan tiedosto
            StreamReader sr = new StreamReader(@"C:\tmp\pisteet.txt");
            // muuttuja yhtä riviä varten
            string rivi;
            // luetaan rivi kerrallaan
            while ((rivi = sr.ReadLine()) != null)
            {
                // palastellaan rivi (eli poimitaan riviltä nimi, x ja y)
                string[] palaset = rivi.Split();
                string nimi = palaset[0];
                double x = double.Parse(palaset[1]);
                double y = double.Parse(palaset[2]);
                // luodaan piste-olio
                Piste p = new Piste(nimi, x, y);
                // laitetaan piste-olio listaan
                luetutPisteet.Add(p);
            }
            sr.Close();
            return luetutPisteet;
        }
    }
}
