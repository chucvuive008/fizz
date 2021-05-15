using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public Dictionary<int, string> NumberWordPairs { get; set; }

        public FizzBuzz(Dictionary<int, string> numberWordPairs)
        {
            NumberWordPairs = numberWordPairs;
        }

        public string GetScore(int number)
        {
            string word = null;
            foreach(var pair in NumberWordPairs)
            {
                if (number % pair.Key == 0)
                {
                    word = word == null ? $"{pair.Value}" : $"{word} {pair.Value}";
                }
            }

            return word ?? number.ToString();
        }
    }
}
