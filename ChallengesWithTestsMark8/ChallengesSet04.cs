using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();

            /*List<int> numList = new List<int>();
            int sum = numList.Sum();

            if (numbers == null)
            {
                return 0;
            }
            for(int i = 0; i < numbers.Length; i++)
            {
                if(i % 2 != 0)
                {
                    numList.Add(-i);
                }
                numList.Add(i);
                
            }
            return sum;*/
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //string[] words = { str1, str2, str3, str4 };
           // return words.Min(w => w.Length);
            //or
            var list = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };
            return list.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            //int x = Math.Min(number1, Math.Min(number2, number3));
            //int y = Math.Min(x, number4);
            //return y;

            var list = new List<int>() { number1, number2, number3, number4 };
            return list.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            int a = sideLength1;
            int b = sideLength2;
            int c = sideLength3;

            if(a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            double num;

            if (double.TryParse(input, out num)) //TryParse returns true if output is number, false if not
            {
               return true;
            }
            return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount = objs.Length;

            var count = 0;

            foreach(var x in objs)
            {
                if(x == null)
                {
                    count++;
                }
            }
            if(count > objs.Length/2)
            {
                return true;
            }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            if (numbers.Where(x => x % 2 == 0).Count() > 0)
            {
                return numbers.Where(x => x % 2 == 0).Average();
            }
            return 0;
        }

        public int Factorial(int number)
        {
            if(number == 1 || number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }
    }
}
