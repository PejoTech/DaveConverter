using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaveConverter.Common
{
    public class ReadFile
    {
        public static void WriteTextFromFileByLine(string file)
        {
            using (var reader = new StringReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("TABL"))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Sektion {0} wird angezeigt", line);
                        Console.ReadLine();
                    }

                    Console.WriteLine(line);
                }
            }

            // Suspend the screen.
            Console.ReadLine();
        }

        public static String LoadStringFromFile(string path)
        {
            try
            {
                using (var sr = new StreamReader(path))
                {
                    return sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read: {0}", path);
                Console.WriteLine(e.Message);
            }

            return "";
        }
    }
}
