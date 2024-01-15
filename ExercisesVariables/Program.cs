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
                string pesel;  //musi być string bo to ciąg znaków chociaż cyfry
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
            int height;
            int width;
            int.TryParse(sHeight, out height);
            int.TryParse(sWidth, out width);
            double c;
            c = Math.Sqrt( Math.Pow(height, 2) + Math.Pow(width, 2) );
            Console.WriteLine($"the diagonal of the rectangle is:{c}");
          
        }
     
        
       

        
        
    }
}