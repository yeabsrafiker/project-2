using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age, num;
            char gender;
            Console.WriteLine("How many students do you wanna register?");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("write name for student " + (i + 1));
                name = Console.ReadLine();
                Console.WriteLine("write age for student " + (i + 1));
                age = int.Parse(Console.ReadLine());
                if (age <= 0)
                {
                    Console.WriteLine("Age cannot be less than 0. Write Again");
                    age = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("write gender for student(F or M) " + (i + 1));
                gender = char.Parse(Console.ReadLine());
                if (gender != 'F' || gender != 'M')
                {
                    Console.WriteLine("Write F or M");
                    gender = char.Parse(Console.ReadLine());
                }
            }



        }
    }
}
        
    

