using System.ComponentModel;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace assignment_05
{
    internal class Program
    {

       


        static bool isprime(int n) {
            for (int i = 2;i<n;i++) 
            {
                if (n%i == 0) 
                {
                    return false;
                }
            }
            return true;
        }
        static void MinMaxArray(int[] arr , ref int max , ref int min) 
        {
            max = arr.Max();
            min = arr.Min();    
        }
        static int factorial(int n) 
        {
            int fact = 1;
            while (n > 0) {
                fact = fact * n;
                n = n - 1;
            }
            return fact;
        }
        public static void ChangeChar(ref string text, int position, char letter)
        {
            text = text.Remove(position, 1);
            text = text.Insert(position, letter.ToString());
        }
        static void Main(string[] args)
        {
          

            

            #region Q3
            //Console.WriteLine("3.Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers");
            //int num1 = 3;
            //int num2 = 4;
            //int SumResulT , SubsResult;
            //summationANDsubstract(num1, num2, out SumResulT, out SubsResult);
            //Console.WriteLine($"sum result: {SumResulT}");
            //Console.WriteLine($"substract result: {SubsResult}");
            ////Console.ReadKey();
            #endregion

            #region Q4
            //Console.WriteLine("4.Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.");
            //Console.Write("Enter the number: ");
            //int num = int.Parse(Console.ReadLine());
            //int result = sumindividual(num);

            //Console.WriteLine($"result:{result}");


            #endregion

            #region Q5

            //Console.WriteLine("5.Create a function named IsPrime, which receives an integer number and retuns true if it is prime, or false if it is not:");
            //Console.Write("Enter the number: ");
            //int num02 = int.Parse(Console.ReadLine());
            //bool result02 = isprime(num02);

            //Console.WriteLine($"result:{result02}");
            #endregion

            #region Q6
            //Console.WriteLine("6.Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters");
            //int max = 0;
            //int min = 0;
            //int[] array06 = { 2, 12, 55 , 74 , 6 };
            //MinMaxArray(array06,ref max,ref min);
            //Console.WriteLine($"max : {max}, min : {min}");
            #endregion

            #region Q7
            //Console.WriteLine("7.Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter");
            //Console.Write("Enter the number: ");
            //int num03 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Factorial of the number is: {factorial(num03)}");

            #endregion

            #region Q8
            //Console.WriteLine("8.Create a function named ChangeChar to modify a letter in a certain position (0 based) of a string, replacing it with a different letter");
            //Console.WriteLine("the word that will be changed: ");
            //string sentence = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("the letter will be replace instead of the first one: ");
            //char letter = Convert.ToChar(Console.ReadLine());

            //ChangeChar(ref sentence, 0, letter);
            //Console.WriteLine($"the new word: {sentence}");

            #endregion


        }
    }
}


