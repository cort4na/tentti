using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaJaOliot
{
    class Program
    {
        static void Main(string[] args)
        {

            // lista on monesti taulukkoa näppärämpi
            List<int> lista = new List<int>();
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);
            lista.Add(5);
            lista.Add(6);

            foreach (int item in lista)
            {
                Console.WriteLine(item.ToString());
            }

            Piste a = new Piste("A", 1, 2);
            Piste b = new Piste("B", 2, 3);
            Piste c = new Piste("C", 3, 4);

            // lista pisteistä
            List<Piste> pisteLista =
                new List<Piste>();
            pisteLista.Add(a);
            pisteLista.Add(b);
            pisteLista.Add(c);
            pisteLista.Add(new Piste("G", 4, 5));

            foreach (Piste item in pisteLista)
            {
                Console.WriteLine(item.ToString());
            }

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

            foreach (PisteKaksi item in pisteListaKaksi)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
