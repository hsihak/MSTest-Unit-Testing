/***************************
 * Assignment 1 - MSTest - Unit Test
 * Title: Aclass Method Validation Test in C#
 * Course: CSCN72010-23F-Sec3 
 * Professor: Prashathan Cheluvasai Ranga
 * Date: October 06, 2023
 * By: Hangsihak Sin
 ***************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Aclass
    {
        // Method 1: Check - Compares two integers provided and returns True if num1 is less than or equal to num2. Otherwise returns False
        public bool Check(int num1, int num2)
        {
            if (num1 <= num2)
            {
                return true;
            } else
            {
                return false;
            }
        }

        // Method 2: Max - Find the largest of floating point (num1, num2, num3) provided and returns result of the largest floating point out of the three

        public float Max(float num1, float num2, float num3)
        {
            float largestOf = num1;

            if (num2 > largestOf)
            {
                largestOf = num2;
            } else if (num3 > largestOf)
            {
                largestOf = num3;
            }

            return largestOf;
        }

        // Method 3: Fact - Calculate the factorial of integer (num1) provided and returns the result. Otherwise returns -1 if integer (num1) provided is less than 0 (negative value)

        public int Fact(int num1)
        {
            int factorial = 1;
            if (num1 >= 0)
            {
                for (int i = 1; i <= num1; i++)
                {
                    // Calculate factorial iteratively
                    factorial *= i;         // (e.g: Factorial of 4 = 1 * 1 -> 1 * 2 -> 2 * 3 -> 6 * 4) 
                }
                // Return the calculated factorial 
                return factorial;           // (e.g: Factorial of 4 = 24)
            } else
            {
                return -1;                  // Return -1 for invalid input
            }
        }

        // Method 4: Gcd - Calculates the greatest common divisor of num1 and num2 (positive values) and return the result, otherwise return -1 if one of the values provided (num1 and num2) is less than 1

        public int Gcd(int num1, int num2)
        {
            // Verify if either num1 or num2 is less than 1, which indicate invalid input since greatest common divisor should not be less than 1
            if (num1 < 1 || num2 < 1)
            {
                return -1;  // Return -1 for invalid input
            }

            // Iterate until both numbers are equal
            while (num1 != num2)
            {
                // Subtract each other until both of them at some point becomes equal
                if (num1 > num2)
                {
                    num1 -= num2;
                }
                else
                {
                    num2 -= num1;
                }
            }

            // Return value could either be num1 or num2 since they are both equal which is the greatest common divisor
            return num1;
        }

        // Method 5: Checkasc - Compares three strings (s1, s2, s3) provided lexicographically and return True if s1 is less than or equal to s2 and s2 is less than or equal to s3, otherwise return False

        public bool Checkasc(String s1, String s2, String s3)
        {
            // Compare() method is used to compare input strings lexicographically
            if (String.Compare(s1, s2) <= 0 && String.Compare(s2, s3) <= 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        // Method 6: Lengthdiff - Find the difference between the lengths of the larger string and smaller string and return the result, otherwise returns 0 if both the strings are of the same length

        public int Lengthdiff(String s1, String s2)
        {
            // Verify if s1 and s2 are of equal length, if valid then return 0
            if (s1.Length == s2.Length) { 
                return 0; 
            } 

            // Verify the length of longest string between s1 and s2 prior to computing to ensure it returns only non-negative value
            if (s1.Length > s2.Length)
            {
                return s1.Length - s2.Length;
            } else
            {
                return s2.Length - s1.Length;
            }
        }

        // Method 7: Concatcomp - Concatenates two strings (s1 and s2) and checks if the length of the resulting string is less than or equal to the specified length. Returns true if it mets the condition, otherwise returns False

        public bool Concatcomp(String s1, String s2, int len)
        {
            // Concat() method is used to concatenates s1 and s2 together and store in a variable called concatenatedString
            String concatenatedString = String.Concat(s1, s2);


            // Verify whether concatenatedString is less than or equal to provided length and return True, otherwise return False
            if (concatenatedString.Length <= len)
            {
                return true;
            } else
            {
                return false;
            }
        }


    }
}
