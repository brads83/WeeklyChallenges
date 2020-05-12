using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        //private readonly object abcdefghijklmnopqrstuvwxyz;

        public bool CharacterIsALetter(char c)
        {
            var alphabetWithUpper = "abcdefghijklmnopqrstuvwxyz" + "abcdefghijklmnopqrstuvwxyz".ToUpper();
            char[] letters = alphabetWithUpper.ToCharArray();

            if (letters.Contains(c) == true)
            {
                return true;
            }
            else
                return false;

        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int sizeOfArray = vals.Length;

            if (sizeOfArray % 2 == 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            else
                return true;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double lower = numbers.Min();
            double higher = numbers.Max();
            var total = lower + higher;

            if (numbers != null && numbers.Count() > 0)
            {
                return total;
            }
            return 0;

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int length1 = str1.Count();
            int length2 = str2.Count();

            //retun (str1.Length < str2.Length) ? str1.Length : str2.Length;

            if (length1 > length2)
            {
                return length2;
            }
            else
                return length1;
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Sum();
                /*for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                return sum;*/
            
        }

        public int SumEvens(int[] numbers)
        {
            //int sum = 0;
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            return numbers.Where(num => num % 2 == 0).Sum();
            /*foreach (var x in numbers)
                {
                    if (x % 2 == 0)
                    {
                        sum += x;
                    }
                }
                return sum;*/
            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            return (numbers.Sum() % 2 != 0) ? true : false;

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if(number <= 0)
            {
                return 0;
            }
            return number / 2;
        }
    }
}
