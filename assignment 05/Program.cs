using System.ComponentModel;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace assignment_05
{
    internal class Program
    {




        public static void ChangeChar(ref string text, int position, char letter)
        {
            text = text.Remove(position, 1);
            text = text.Insert(position, letter.ToString());
        }



        static void Main(string[] args)
        {
          

            

  


        

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


