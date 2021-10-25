/*Simple program that checks if two words are anagrams. 
 * Takes user input and compairs.
 *  
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            //takes words from user.
            Console.WriteLine("Enter first word: ");
            string value1 = Console.ReadLine();
            Console.WriteLine("Enter second word: ");
            string value2 = Console.ReadLine();

            //takes value1/2 and sends them to a char array.
            char[] char1 = value1.ToLower().ToCharArray();
            char[] char2 = value2.ToLower().ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);

            string newValue1 = new string(char1);
            string newValue2 = new string(char2);

            if (newValue1 == newValue2)
            {
                Console.WriteLine("Yes! words \"{0}\" and \"{1}\" are anagrams", value1,value2);
            }
            else
                Console.WriteLine("Sorry words \"{0}\" and \"{1}\" are not anagrams", value1, value2);
        }
    }
}
