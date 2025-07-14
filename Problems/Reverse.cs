using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problems
{
    public static class Reverse
    {

        ///Reverse Words In String , (no use of Split, Reverse, Array.Reverse)
        /// <summary>
        /// Write a function that takes in a string of words separated by one or more whitespaces
        /// and returns a string that has these words in reverse order.For
        ///example, "tim is great" - function should return "great is tim"
        /// </summary> 
        /// 
        public static string ReverseWords(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input; // Return empty string if input is null or empty
            }
            List<string> words = new List<string>();
            int start = 0;
            for(int i = 0; i < input.Length; i++)
            {
                if (char.IsWhiteSpace(input[i]) || i == input.Length - 1)
                {
                    if (i == input.Length - 1 && !char.IsWhiteSpace(input[i]))
                    {
                        i++; // Include the last character if it's not a whitespace
                    }
                    string word = input.Substring(start, i - start).Trim();
                    if (!string.IsNullOrEmpty(word))
                    {
                        words.Add(word);
                    }
                    start = i + 1; // Move to the next word
                }
            }
            // Reverse the list of words
            for (int i = 0, j = words.Count - 1; i < j; i++, j--)
            {
                string temp = words[i];
                words[i] = words[j];
                words[j] = temp;
            }
            // Join the reversed words into a single string
            return string.Join("", words);
        }



    }
}
