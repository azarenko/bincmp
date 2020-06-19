using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace bincmp
{
    class Program
    {
        private static int i1, i2, readed;

        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("I am waiting two input files and comparsion level");
                return;
            }

            double comparsionLevel = double.Parse(args[2]);

            if (!File.Exists(args[0]))
            {
                Console.WriteLine(string.Format("I can't open the file path {0}", args[0]));
                return;
            }

            if (!File.Exists(args[1]))
            {
                Console.WriteLine(string.Format("I can't open the file path {0}", args[1]));
                return;
            }

            byte[] buffer1;
            byte[] buffer2;

            using (FileStream fs1 = new FileStream(args[0], FileMode.Open))
            using (FileStream fs2 = new FileStream(args[1], FileMode.Open))
            {
                buffer1 = new byte[fs1.Length];
                buffer2 = new byte[fs2.Length];

                readed = i1 = 0;

                do
                {
                    readed = fs1.Read(buffer1, i1, buffer1.Length);
                }
                while (readed > 0);

                readed = i1 = 0;

                do
                {
                    readed = fs2.Read(buffer2, i1, buffer2.Length);
                }
                while (readed > 0);
            }


        }
    }
}
