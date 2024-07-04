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
        }
    }
}