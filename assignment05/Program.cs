namespace assignment05
{
    internal class Program
    {
        public static void DoublicateTheValue1(int x, int y)
        {
            x *= 2;
            y *= 2;

            Console.WriteLine("the value of the parameters in the function");
            Console.WriteLine($"x: {x} \ny: {y}");
        }
        public static void DoublicateTheValue2(ref int x, ref int y)
        {
            x *= 2;
            y *= 2;
            Console.WriteLine("the value of the parameters in the function");
            Console.WriteLine($"x: {x} \ny: {y}");
        }
        static int average(int[] arr)
        {
            int sum = 0;
            int NumberOfArr = arr.Length;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            int average = sum / NumberOfArr;
            Console.WriteLine($"the average: {average}");
            Console.WriteLine("change a element with index 1 then print:");
            arr[1] = 20000;
            Console.WriteLine($"the arr: {arr[0]},{arr[1]},{arr[2]} ");
            Console.WriteLine("assign a new object in arr then print arr:");
            arr = new int[] { 15000, 9000, 12500 };
            Console.WriteLine($"new arr: {arr[0]}, {arr[1]}, {arr[2]}");
            return average;
        }
        static int average2(ref int[] arr)
        {
            int sum = 0;
            int NumberOfArr = arr.Length;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            int average = sum / NumberOfArr;
            Console.WriteLine($"the average: {average}");
            Console.WriteLine("change a element with index 1 then print:");
            arr[1] = 20000;

            Console.WriteLine($"the arr[1]: {arr[0]}, {arr[1]}, {arr[2]}");
            Console.WriteLine("assign a new object in arr then print arr:");
            arr = new int[] { 15000, 9000, 12500 };
            Console.WriteLine($"new arr: {arr[0]}, {arr[1]}, {arr[2]}");
            return average;
        }
        static void summationANDsubstract(int x, int y, out int sum, out int subs)
        {
            sum = x + y;
            subs = x - y;

        }
        static int sumindividual(int n)
        {
            int sum = 0;
            string arrnum = Convert.ToString(n);
            for (int i = 0; i < arrnum.Length; i++)
            {
                n = int.Parse(arrnum.Substring(i, 1));
                //Console.WriteLine(n);
                sum += n;
                //Console.WriteLine(sum);
            }
            return sum;
        }
        static bool isprime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void MinMaxArray(int[] arr, ref int max, ref int min)
        {
            max = arr.Max();
            min = arr.Min();
        }
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("1 - Explain the difference between passing(Value type parameters) by value and by reference then write a suitable c# example.");
            //// Value type parameters like int , decimal , char ..
            #region 1.1.passing by value 
            //// that mean it will take only value of the variable which sent as argements.
            //// and the varible will keep their value doesn't change.
            //// Pass by value means passing a copy of the variable to the function.
            //// ex doublicate the value function
            //Console.WriteLine("1.1.passing by value ex");
            //int A = 3;
            //int B = 5;
            //Console.WriteLine("the value of the var. before calling the function");
            //Console.WriteLine($"A: {A} \nB: {B}");

            //DoublicateTheValue1(A, B);

            //Console.WriteLine("the value of the var. after calling the function");
            //Console.WriteLine($"A: {A} \nB: {B}");
            #endregion

            #region 1.2.passing by Ref
            //// that mean it will refer to this variables and the the changed will happen on parameter the variables will  be changed with it.
            ////Pass by reference means passing access to the variable to the method.

            //Console.WriteLine("2.2.passing by Ref ex");

            //int C = 3;
            //int D = 5;
            //Console.WriteLine("the value of the var. before calling the function");
            //Console.WriteLine($"C: {C} \nD: {D}");

            //DoublicateTheValue2(ref C, ref D);

            //Console.WriteLine("the value of the var. after calling the function");
            //Console.WriteLine($"C: {C} \nD: {D}");
            #endregion

            #endregion

            #region Q2
            //Console.WriteLine("2.Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.");
            //// reference type parameters like string , array ...
            #region 2.1.passing by value 
            ////-If the method assigns the parameter to refer to a different object,
            //      //those changes aren't visible from the caller.
            ////-If the method modifies the state of the object referred to by the parameter,
            //      //those changes are visible from the caller.
            //// ex average function
            //Console.WriteLine("2.1.passing by value ex");
            //int[] salary = { 10000, 8000, 6500, 12000 };
            //Console.WriteLine("the value of the var. before calling the function");
            //Console.WriteLine($"salary: {salary[0]}, {salary[1]}, {salary[2]}");


            //average(salary);

            //Console.WriteLine("the value of the var. after calling the function");
            //Console.WriteLine($"salary: {salary[0]}, {salary[1]}, {salary[2]}");
            //Console.WriteLine("notes that changed in parameter appeare in the variable but when assign new object that didn't affect on the variable. ");


            #endregion

            #region 2.passing by Ref
            //// If the method assigns the parameter to refer to a different object,
            //// those changes are visible from the caller.
            ////If the method modifies the state of the object referred to by the parameter,
            ////those changes are visible from the caller.
            //Console.WriteLine("2.passing by Ref ex");
            //int[] salary2 = { 5000, 7000, 4500 };
            //Console.WriteLine("the value of the var. before calling the function");
            //Console.WriteLine($"salary: {salary2[0]}, {salary2[1]}, {salary2[2]}");


            //average2(ref salary2);

            //Console.WriteLine("the value of the var. after calling the function");
            //Console.WriteLine($"salary: {salary2[0]}, {salary2[1]}, {salary2[2]}");
            //Console.WriteLine("notes that changed in parameter appeare in the variable and when assign new object that affected on the variable.");


            ////Console.ReadLine();
            #endregion

            #endregion

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

        }
    }
}