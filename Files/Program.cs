//#define WRITE_TO_FILE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if WRITE_TO_FILE
            Console.WriteLine("Hello Files");

            //Console.WriteLine(Directory.GetCurrentDirectory());

            string directory = Directory.GetCurrentDirectory();
            String FileName = "File.txt";
            StreamWriter sw = new StreamWriter(FileName);
            sw.WriteLine("Hello Files");
            sw.Close();

            using (StreamWriter file = File.AppendText(FileName))
            {
                file.WriteLine("Привет");
            }

            string cmd = directory + "\\" + FileName;
            System.Diagnostics.Process.Start("notepad", cmd); 
#endif
            StreamReader sr = new StreamReader("File.txt");
            while (!sr.EndOfStream) { 
                string buffer = sr.ReadLine();
                Console.WriteLine(buffer);
            }
            sr.Close();
        }
    }
}
