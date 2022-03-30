using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static double ComputeBMI(int h, int w)

        {
            
            return
             w / Math.Pow((double)h / 100, 2);
            
                }
        static void Main(string[] args)
        {
            //    Console.Write("n=");
            //    int n=Convert.ToInt32(Console.ReadLine());
            //    Random a = new Random();

            //    int total=0;
            //    for (int i=0;i<n; i++) 
            //    {
            //         int temp = a.Next(1, 100);
            //        Console.WriteLine(temp);
            //        total+= temp;
            //    }
            //    int result = total / n;
            //    Console.Write("");
            //    Console.WriteLine("平均"+result);
            Console.WriteLine("height:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Weight:");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("身高:{0},體重{1},BMI{2}",height,weight, ComputeBMI(height, weight));

            Console.ReadLine();

           
           
        }
    }
}
