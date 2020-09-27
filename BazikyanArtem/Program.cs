using System;

namespace BazikyanArtem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass1 = new int[3];
            int[] mass2 = new int[3];
            Console.WriteLine("ВВедите первый массив : ");
            for (int i = 0; i < 3; i++)
                mass1[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("ВВелите вторй масс : ");
            for (int k = 0; k < 3; k++)
                mass2[k] = int.Parse(Console.ReadLine());
            int[] most_val = new int[6];
            int c = 5;
            for (int j = 0; j < 3; j++)
            {
                most_val[j] = mass1[j];
                most_val[c] = mass2[j];
                c--;
            }
            Array.Sort(most_val);
            for (int i = 5; i > 0; i--)
                Console.Write($"{most_val[i] - 5} ");
            Console.ReadKey();
        }
    }
}
