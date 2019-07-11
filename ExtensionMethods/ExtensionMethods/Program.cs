using System;
using System.Text;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World";
            Console.WriteLine($"Does the string start with capitalize letter?\nAnswer: {s.FirstCapitalLetter()}");
            string s1 = "method";
            Console.WriteLine($"The pluralize string is:{s1.AppendS()}");
            string s2 = "mom";
            Console.WriteLine($"The string with the first capitalize letter is:{s2.CapitalizeFirstLetterOfWord()}");
            string s3 = "Hello World";
            Console.WriteLine($"The pluralize and capitalize string is:{s3.PluralizeCapitalize()}");
            Console.WriteLine($"The number of character is:{s3.CountCharacters()}");
            decimal number = 300.50M;
            Console.WriteLine($"The result of applying VAT is:{number.ApplyVAT()}");
        }

    }
    static class ExtensionMethods
    {
        //Write an extension method to check if a string starts with a capital letter or not.
        public static bool FirstCapitalLetter(this string myString)
        {   
            if (myString != string.Empty)
            {
                if (myString[0] == char.ToUpper(myString[0]))
                {
                   return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        //Write an extension method that appends an ‘s’ to a string.
       // input : method
       //output:methods
       public static string AppendS(this string myString)
        {
            return myString.Insert((myString.Length), "s");
        }
        //Write an extension method that will capitalize a word.
        //Input: mom
        //Output: Mom
        public static string CapitalizeFirstLetterOfWord(this string myString)
        {
            return myString.Substring(0, 1).ToUpper()+myString.Substring(1);
        }
        //Write a program that will capitalize a string , and pluralize the same string.
        //You cand write a new extension method or use what you already have.
        public static  string PluralizeCapitalize(this string myString)
        {
            return myString.AppendS().CapitalizeFirstLetterOfWord();
        }
        //Write an extension method what will count the number of characters in a string.
        public static int CountCharacters(this string myString)
        {
            int index = myString.IndexOf(myString[0]);
            return myString.Substring(index).Length;
        }
        //Write an extension method that will apply a VAT of 24% on an input.This input can be a decimal value, or an integer on
        public static decimal ApplyVAT(this decimal input)
        {
            return 0.24M * input;
        }
    }
}
