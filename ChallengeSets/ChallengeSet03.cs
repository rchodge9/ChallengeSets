﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var item in vals)
            {
                if (item == false)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            int oddTotal = 0;

            foreach (var num in numbers)
            {
                if (Math.Abs(num) % 2 == 1)
                {
                    oddTotal += Math.Abs(num);
                }
            }

            return oddTotal % 2 == 1;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upperCase = false;
            bool lowerCase = false;
            bool numCase= false;

            foreach (var item in password)
            {
                if (Char.IsUpper(item))
                {
                    upperCase = true;
                }

                if (Char.IsLower(item))
                {
                    lowerCase = true;
                }

                if (Char.GetNumericValue(item)>=0)
                {
                    numCase = true;
                }
            }

            return upperCase && lowerCase && numCase;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {

            return val[val.Length-1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return (divisor == 0) ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }
        public int[] GetOddsBelow100()
        {
            var odds = new List<int>();

            for (int i = 1; i < 100; i += 2)
            {
                odds.Add(i);
            }

            return odds.ToArray();
        }

        public string[] ChangeAllElementsToUppercase(string[] words)
        {
            int i = 0;
            foreach (var item in words)
            {
                words[i] = item.ToUpper();
                i++;
            }
            return words;
        }
    }
}
