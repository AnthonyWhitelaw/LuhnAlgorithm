using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuhnAlgorithm
{
        public static class Luhn
        {
            public static bool LuhnCheck(this string cardNumber)
            {
                return LuhnCheck(cardNumber.Select(c => c - '0').ToArray());
            }
 
            private static bool LuhnCheck(this int[] digits)
            {
                return GetCheckValue(digits) == 0;
            }
 
            private static int GetCheckValue(int[] digits)
            {
                return digits.Select((d, i) => i % 2 == digits.Length % 2 ? ((2 * d) % 10) + d / 5 : d).Sum() % 10;
            }
        }
 
    public static class TestProgram
    {
        public static void Main()
        {
            Console.WriteLine("Enter a card number to see if the number is valid or not!");
            string testNumber = Console.ReadLine();
            long cardNumber = Convert.ToInt64(testNumber);
            
                Console.WriteLine("{0} is {1}valid card number", testNumber, testNumber.ToString().LuhnCheck() ? "a " : "not a ");
                Console.ReadKey();
        }
    }
}
