﻿using System.ComponentModel;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace assignment_05
{
    internal class Program
    {
        //public static void printshape(int count = 10 , string pattern = "*_*") 
        //{
        //for (int i = 0; i < count; i++) {
        //        Console.WriteLine(pattern);
        //    }
        //}
        //static void swap(int x, int y) {
        //    int temp = x;
        //    x = y; 
        //    y = temp;    

        //}
        //static void swap(ref int x,ref int y) {
        //    int temp = x;
        //    x = y; 
        //    y = temp;    

        //}


        //static int sumArry(int[] arr) 
        //{
        //int sum = 0; 
        //    arr[0] = 100;
        //    for(int i = 0; i < arr.Length; i++) { sum+= arr[i]; }
        //    return sum;

        //}
        //static int sumArry(ref int[] arr) 
        //{
        //int sum = 0; 
        //    arr[0] = 100;
        //    for(int i = 0; i < arr.Length; i++) { sum+= arr[i]; }
        //    return sum;

        //}
        //static int sumArry(int[] arr) 
        //{
        //int sum = 0; 
        //    if (arr is not null)
        //    {
        //          arr = new int [] {4,5,6};
        //    for(int i = 0; i < arr.Length; i++) { sum+= arr[i]; }

        //    }
        //    return sum;

        //}
        //static int sumArry(ref int[] arr) 
        //{
        //int sum = 0; 
        //    if (arr is not null)
        //    {
        //          arr = new int [] {4,5,6};
        //    for(int i = 0; i < arr.Length; i++) { sum+= arr[i]; }

        //    }
        //    return sum;

        //}

        //static void SumMul(int x, int y , out int sum , out int mul) 
        //{
        //    sum = x + y;
        //    mul = x * y;
        //}

        //static void SumMul(int x, int y , ref int sum , ref int mul) 
        //{
        //    sum = x + y;
        //    mul = x * y;
        //}

        static void Main(string[] args)
        {
            #region print fun. code
            //printshape(2,":)"); 
            #endregion
            #region passing Value type parameters
            //int a = 10, b = 20;
            //Console.WriteLine($"a = {a} \n b = {b}");
            //swap(a, b);
            //Console.WriteLine("swap");
            //Console.WriteLine($"a = {a} \n b = {b}");
            //--------------------------------------
            //int a = 10, b = 20;
            //Console.WriteLine($"a = {a} \n b = {b}");
            //swap(ref a,ref b);
            //Console.WriteLine("swap");
            //Console.WriteLine($"a = {a} \n b = {b}");

            #endregion
            #region passing reference type parameters

            //int[] number = { 1, 2, 3 };
            //int result = sumArry(number);
            //Console.WriteLine(number[0]);
            //Console.WriteLine(result);
            //Console.WriteLine(number[0]);
            //----------------------------------------------
            //int[] number = { 1, 2, 3 };
            //int result = sumArry(ref number);
            //Console.WriteLine(number[0]);
            //Console.WriteLine(ref result);
            //Console.WriteLine(number[0]);
            #endregion
            #region passing reference type parameters with new object

            //int[] number = { 1, 2, 3 };
            //int result = sumArry(number);
            //Console.WriteLine(number[0]);
            //Console.WriteLine(result);
            //Console.WriteLine(number[0]);
            //----------------------------------------------
            //int[] number = { 1, 2, 3 };
            //int result = sumArry(ref number);
            //Console.WriteLine(number[0]);
            //Console.WriteLine(ref result);
            //Console.WriteLine(number[0]);
            #endregion
            #region  passing by out 
            //int a = 10 , b = 20 ;
            //int sumResult, mulResult;
            //SumMul(a, b, out sumResult, out mulResult);
            //Console.WriteLine(sumResult);
            //Console.WriteLine(mulResult);
            //------------------------------
            //int a = 10 , b = 20 ;
            //int sumResult=0 , mulResult=0;
            //SumMul(a, b, ref sumResult, ref mulResult);
            //Console.WriteLine(sumResult);
            //Console.WriteLine(mulResult);

            #endregion




        }
    }
}


