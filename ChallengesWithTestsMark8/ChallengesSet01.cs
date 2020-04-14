using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            var answer = minuend - subtrahend;
            return answer;
        }

        public int Add(int number1, int number2)
        {
            var answer = number1 + number2;
            return answer;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number1;
            }
            else  
            {
                return number2;
            }
            
            /*int[] numbers = new int[2];
             
            return numbers.Min();*/
        }

        public long Multiply(long factor1, long factor2)
        {
            var answer = factor1 * factor2;
            return answer;
        }

        public string GetGreeting(string nameOfPerson)
        {
            var name = nameOfPerson;
            if (name == "")
            {
                return "Hello!";
            }
            else
            {
                return ($"Hello, {name}!");
            }

        }

        public string GetHey()
        {
            string hey = "HEY!";
            return hey;
        }
    }
}
