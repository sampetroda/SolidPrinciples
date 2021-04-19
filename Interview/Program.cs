using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class Program
    {
     static void Main(string[] args)
        {
            // Predicate<int> IsEventNumber = (x) => x % 2 == 0;        
            /// Func<int,bool> EvenNumber = (x )=> x % 2 == 0 ? true : false;
           Func<int, int> EventNumber = EvenNumber;
            Action<int> Showdel = ShowMessage;
            Showdel(EvenNumber(5));
  
        }
        public static bool IsEvenNumber(int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
                  
        }
        public static int EvenNumber(int number)
        {
            if (number % 2 == 0)
                return number;
            else
                return 0;
        }
        public  static void ShowMessage(int number)
        {
            Console.WriteLine(number);
            Console.ReadKey(true);  
        }
    }
}
