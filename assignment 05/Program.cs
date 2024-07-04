using System.ComponentModel;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace assignment_05
{
    internal class Program
    {
        public static void printshape(int count = 10 , string pattern = "*_*") 
        {
        for (int i = 0; i < count; i++) {
                Console.WriteLine(pattern);
            }
        
        
        }
        static void Main(string[] args)
        {
            #region print fun. code
            //printshape(2,":)"); 
            #endregion
        }
    }
}


