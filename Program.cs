using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CopyLP05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Copy Print file to Backup - Version (2.0.0.0)");
            Console.WriteLine("Author Philip Chaston = @Systems Ltd 2015 ");
            Console.WriteLine(" ");
            Console.WriteLine("EXEC File? type G3EXEC ");
            Console.WriteLine("CHANGE CORE SIZE? type N ");
            Console.WriteLine("ENTER DATE...type TUE25OCT17 ");
            Console.WriteLine("ENTER TIME...type 1000 ");
            Console.WriteLine("Found on Unit ?? type Tab - DA GEORGE3A ");
            Console.WriteLine("GEORGE READY type MOP ON,29(If not loaded) ");
            Console.WriteLine("RESTORE - N ");
            Console.WriteLine("  ");

            var myUniqueFileName1 = "C:\\em1904s\\data\\" + string.Format(@"{0}.txt", Guid.NewGuid());
            var myUniqueFileName2 = "C:\\em1904s\\data\\" + string.Format(@"{0}.txt", Guid.NewGuid());
            var myUniqueFileName3 = "C:\\em1904s\\data\\" + string.Format(@"{0}.txt", Guid.NewGuid());
            var myUniqueFileName4 = "C:\\em1904s\\data\\" + string.Format(@"{0}.txt", Guid.NewGuid());
            var myUniqueFileName5 = "C:\\em1904s\\data\\" + string.Format(@"{0}.txt", Guid.NewGuid());
            var myUniqueFileName6 = "C:\\em1904s\\data\\" + string.Format(@"{0}.txt", Guid.NewGuid());

            using (StreamWriter w = File.AppendText(myUniqueFileName1))
            {
                Log("C:\\em1904s\\data\\lp14.txt", w);
            }
            using (StreamWriter w = File.AppendText(myUniqueFileName2))
            {
                Log("C:\\em1904s\\data\\lp15.txt", w);
            }
            using (StreamWriter w = File.AppendText(myUniqueFileName3))
            {
                Log("C:\\em1904s\\data\\lp06.txt", w);
            }
            using (StreamWriter w = File.AppendText(myUniqueFileName4))
            {
                Log("C:\\em1904s\\data\\lp10.txt", w);
            }
            using (StreamWriter w = File.AppendText(myUniqueFileName5))
            {
                Log("C:\\em1904s\\data\\lp11.txt", w);
            }
            using (StreamWriter w = File.AppendText(myUniqueFileName6))
            {
                Log("C:\\em1904s\\data\\lp12.txt", w);
            }
            try
            {
                File.Delete("C:\\em1904s\\data\\lp14.txt");
                File.Delete("C:\\em1904s\\data\\lp15.txt");
                File.Delete("C:\\em1904s\\data\\lp06.txt");
                File.Delete("C:\\em1904s\\data\\lp10.txt");
                File.Delete("C:\\em1904s\\data\\lp11.txt");
                File.Delete("C:\\em1904s\\data\\lp12.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(" ");
            Console.WriteLine("LP Print Files now Deleted ");

        }

        public static void Log(String filename1, TextWriter w)
        {
            int counter = 0;
            string line;
            try
            {
                w.Write("\r\nLog Entry : ");
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                w.WriteLine("  :");
                // Read the file and display it line by line.
                System.IO.StreamReader file =
                   new System.IO.StreamReader(filename1);
                while ((line = file.ReadLine()) != null)
                {
                    w.WriteLine("{0}", line);
                    counter++;
                }
                w.WriteLine("-------------------------------");
                file.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}

