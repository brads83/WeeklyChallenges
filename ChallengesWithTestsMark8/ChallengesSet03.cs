using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if(vals.Contains(false))
            {
                return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int num = 0;
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            for (int i = 0; i < numbers.Count(); i++)
            {
                if(num % 2 != 0)
                {
                    num += num;
                }
            }
            if(numbers.Sum() % 2 == 0)
            {
                return false;
            }
            return true;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var isLower = false;
            var isUpper = false;
            var isNumber = false;

            for(int i = 0; i < password.Length; i++)
            {
                if(char.IsLower(password[i]))
                {
                    isLower = true;
                }
                if(char.IsUpper(password[i]))
                {
                    isUpper = true;
                }
                if(char.IsNumber(password[i]))
                {
                    isNumber = true;
                }
            }
            if(isLower && isUpper && isNumber)
            {
                return true;
            }
            return false;
           /* string str = "";
            
            if(password.Contains(str.ToUpper()) && password.Contains(str.ToLower()) && password.Any(char.IsDigit))
            {
                return true;
            }
            return false;*/
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            char c = val[val.Length - 1];
            return c;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if( divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            int first= nums[0];
            int last = nums.Last();
            return last - first;
            // or return nums.Last() - nums[0];

        }

        public int[] GetOddsBelow100()
        {
            var oddsList = new List<int>();
            for(int i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    oddsList.Add(i);
                }
            }
            int[] odds = oddsList.ToArray();
            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            
        }
    }
}
