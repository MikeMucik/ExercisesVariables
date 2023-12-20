using System;

namespace ExercisesVariables
{
    class Program
    {
            static void Main(string[] args)
            {
                string firstName;
                string lastName;
                int age;    //lub uint age
                char gender;
                int pesel;  //lub uint pesel
                int workerId; //lub uint workerId

                char first = 'A';
                char second = 'B';
                char third = 'C';

            Console.WriteLine(third);
            Console.WriteLine(second);
            Console.WriteLine(first);

            Console.WriteLine("Write height of rectangle:");
            string sHeight = Console.ReadLine();
            Console.WriteLine("Write width of rectangle");
            string sWidth = Console.ReadLine();
            Int32 height;
            Int32 width;
            Int32.TryParse(sHeight, out height);
            Int32.TryParse(sWidth, out width);
            double c;
            c =Math.Sqrt( Math.Pow(height, 2) + Math.Pow(width, 2) );
            Console.WriteLine($"the diagonal of the rectangle is:{c}");
          
        }
     
        
       

        
        
    }
}