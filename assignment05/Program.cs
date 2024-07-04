﻿namespace assignment05
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
        }
    }
}