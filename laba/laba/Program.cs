using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"input.txt";
            Student[] studs = ReadData(path);
            Console.WriteLine("Студенти, що пропустили бiльше двох iспитiв:");
            runMenu(studs);
            Console.Read();
        }
        static Student[] ReadData(string fileName)
        {
            string[] pathForFile = File.ReadAllLines(fileName);
            Student[] ArrayOfStudent = new Student[pathForFile.Length];
            for (int i = 0; i < pathForFile.Length; i++)
            {
                ArrayOfStudent[i] = new Student(pathForFile[i]);
            }
            return ArrayOfStudent;
        }
        static void runMenu(Student[] studs)
        {
            Console.WriteLine();
            for (int i = 0; i < studs.Length; i++)
            {
                if (studs[i].mathematicsMark == '-' && studs[i].physicsMark == '-' && studs[i].informaticsMark == '-')
                    Console.WriteLine(studs[i].surName);
            }
        }
    }
}