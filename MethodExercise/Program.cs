using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is you name?");
            string userName = Console.ReadLine();

            Console.WriteLine("what is your favorite color?");
            string userFavoriteColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string userFavoriteAnimal = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            Console.WriteLine("Which is your favorite sport to play?");
            string userFavoriteSport = Console.ReadLine();

            Console.WriteLine($"There was a female name {userName},Her favorite color is {userFavoriteColor}.");
            Console.WriteLine($"Her favorite animal is the {userFavoriteAnimal},She is {age} years old,");
            Console.WriteLine($"and here favorite sport to play is {userFavoriteSport}.");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"the sum is={sum}");
        }
        public static int Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

       

        
           
            

        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        
          

    }

      
  
}
