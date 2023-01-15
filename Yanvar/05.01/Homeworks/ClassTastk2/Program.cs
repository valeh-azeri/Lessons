using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Sinifdə neçə  tələbə var");
            short studentCount = Convert.ToInt16(Console.ReadLine());

            

            string[] studentName = new string[studentCount];

            int[] studentAgeName = new int[studentCount];

            for (int i = 0; i < studentName.Length || i< studentAgeName.Length; i++)
            {
                Console.Write(i + 1 + " Tələbənin  adını girin :");
                string studentName1 = Console.ReadLine();
                studentName[i] = studentName1;

                Console.Write(i + 1 + " Tələbənin  yasini girin :");
                int studentAgeName1 = Convert.ToInt16(Console.ReadLine());
                studentAgeName[i] = studentAgeName1;

            }

            Console.Clear();

            for (int i = 0; i < studentName.Length || i < studentAgeName.Length; i++)
            {
                Console.WriteLine(i + 1 + " telebe Adı -\t" + studentName[i]+"\t"+(i+1)+"-telebe yasi "+studentAgeName[i]);
            }
            Console.ReadLine();
        }
    }
}
