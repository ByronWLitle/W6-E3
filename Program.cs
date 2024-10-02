using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json.Nodes;
using System.Text.Json;

namespace W6_E3
{
    internal class Program
    {
        public class StudentsInfo
        {
            public string name { get; set; }
            public string grade { get; set; }
        }
        static void Main(string[] args)
        {
           string fileName = @"C:\temp\grades.csv";
           ReadCsv(fileName);
           Console.ReadKey();
        }
        public static void ReadCsv(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string header = reader.ReadLine();
                Console.WriteLine(header);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
