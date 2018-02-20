using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinaryDataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("C:\\tmp\\bindataTentti.bin",
    FileMode.Open);

            BinaryReader reader = new BinaryReader(stream);

            reader.BaseStream.Seek(0, SeekOrigin.Begin);

            string a = reader.ReadString();
            double b = reader.ReadDouble();
            double c = reader.ReadDouble();
            string d = reader.ReadString();
            double e = reader.ReadDouble();
            double f = reader.ReadDouble();

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);

            reader.Close();
            stream.Close();

            // luetaan ptdata.bin
            stream = new FileStream(@"C:\tmp\\bindataTentti.bin",
                FileMode.Open);

            reader = new BinaryReader(stream);

            reader.BaseStream.Seek(0, SeekOrigin.Begin);

            while (reader != null && reader.BaseStream.Position < reader.BaseStream.Length)
            {
                string Nimi = reader.ReadString();
                double X = reader.ReadDouble();
                double Y = reader.ReadDouble();

                Console.WriteLine(Nimi + " " + X + " " + Y + " ");
                Console.WriteLine("Position: " + reader.BaseStream.Position);
            }
        }
    }
}
