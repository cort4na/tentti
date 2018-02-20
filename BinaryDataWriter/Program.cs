using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinaryDataWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = null;
            try
            {
                stream = new FileStream(@"C:\tmp\fcyc.bin",
                    FileMode.Open);

                BinaryWriter writer = new BinaryWriter(stream);

                string a = "";
                double b = 0;
                double c = 0;
                string d = "";
                double e = 0;
                double f = 0;

                writer.Write(b);
                writer.Write(a);
                writer.Write(c);
                writer.Write(d);
                writer.Write(e);
                writer.Write(f);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }
    }
}
