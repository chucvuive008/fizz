using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to create custom substitution");
            Console.WriteLine("Please enter Yes or No");
            FizzBuzz fizzBuzz;
            var defaultNumberWordPair = new Dictionary<int, string>
            {
                { 3, "Fizz" },
                { 5, "Buzz" },
                { 7, "Pop" },
            };
            fizzBuzz = new FizzBuzz(defaultNumberWordPair);
            bool nextStep = false;
            while (!nextStep)
            {
                var doCustomSubstitution = Console.ReadLine();
                if (doCustomSubstitution.ToLower() == "yes")
                {
                    Dictionary<int, string> customNumberWordPair = new Dictionary<int, string>();
                    var stopCustomSubstitution = false;
                    while (!stopCustomSubstitution)
                    {
                        Console.WriteLine("Please enter your word here");
                        var word = Console.ReadLine();
                        try
                        {
                            var isValidInput = false;
                            while (!isValidInput)
                            {
                                Console.WriteLine("Please enter your number that link to the word above");
                                var numberString = Console.ReadLine();
                                var number = int.Parse(numberString);
                                customNumberWordPair.Add(number, word);
                                isValidInput = true;
                                Console.WriteLine("Do you want to continue your custom substitution");
                                Console.WriteLine("Please enter yes or no");
                                stopCustomSubstitution = Console.ReadLine().ToLower() == "yes" ? false : true;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Input is not recognized. Please enter a valid number.");
                        }
                    }
                    fizzBuzz = new FizzBuzz(customNumberWordPair);
                }
                else if (doCustomSubstitution.ToLower() == "no")
                {
                    Console.WriteLine("Use default setting");
                }
                else
                {
                    Console.WriteLine("We did not recognize your input, we will use default setting");
                    fizzBuzz = new FizzBuzz(defaultNumberWordPair);
                }
                nextStep = true; 
            }
            var stopGame = false;
            while (!stopGame)
            {
                var isValidFizzBuzzNumber = false;
                while (!isValidFizzBuzzNumber)
                {
                    try
                    {
                        Console.WriteLine("Please enter your nunber for Fizz Buzz game");
                        var fizzBuzzNumberString = Console.ReadLine();
                        var fizzBuzzNumber = int.Parse(fizzBuzzNumberString);
                        isValidFizzBuzzNumber = true;
                        var result = fizzBuzz.GetScore(fizzBuzzNumber);
                        Console.WriteLine($"this is your result {result}");
                    }
                    catch
                    {
                        Console.WriteLine("Input is not recognized. Please enter a valid number.");
                    }
                }
                Console.WriteLine("Do you want to continue the game. Please enter yes or no");
                stopGame = Console.ReadLine().ToLower() == "yes" ? false : true;
            }
        }
    }
}
