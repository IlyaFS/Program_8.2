using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Program_8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "lab 8.2";
            DirectoryInfo folder = new DirectoryInfo(path);// создаем папку

            if (!folder.Exists)
                folder.Create();

            string path2 = "lab 8.2/lab 8.2.txt";
            using (StreamWriter xx = new StreamWriter(path2))// создаем файл
            {
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                    xx.WriteLine(random.Next(1, 15));// запись случайных чисел
            }
            using (StreamReader xy = new StreamReader(path2))
            {
               int [] n = new int[10];
               int sum = 0;

                for (int i = 0; i < 10; i++)
                {
                    n[i] = Convert.ToInt32(xy.ReadLine());
                    sum += n[i];                   
                }
                Console.WriteLine(sum);
            }
            Console.ReadKey();
        }
    }
}
//Программно создайте текстовый файл и запишите в него 10 случайных чисел.
//Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.
