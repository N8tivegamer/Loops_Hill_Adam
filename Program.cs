namespace Loops_Hill_Adam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user why do you wnat to make games.
            Console.WriteLine("Why do you want to make games?");
            string responce = Console.ReadLine();

            // Displays the user's sentence and the number of spaces it contains
            Console.WriteLine($"The sentence, \"{responce}\" has {CountNumberOfSpaces(responce)} spaces in it. ");

            // Ask the user too enter a whole number.
            Console.WriteLine("Please enter a whole number!");
            string responce2 = Console.ReadLine();

            // Calls SumOfDigits to calculate the total of each digit in the user's input
            // and prints the result to the console
            Console.WriteLine($"The sum of the individual digits of {responce2} is {SumOfDigits(responce2)}");
        }
        /// <summary>
        /// // Counts how many space characters are in the given sentence
        /// </summary>
        /// <param name="sentence">The sentence to count number of spaces in</param>
        /// <returns>Number of spaces in the sentence</returns>
        static int CountNumberOfSpaces(string sentence)
        { 
            int numberOfSpaces = 0;
            foreach (char charater in sentence)
            {
                if (charater == ' ')
                   numberOfSpaces++;
                 
            }
            return numberOfSpaces;
        }
        /// <summary>
        /// Calculates the sum of all individual digits in a string of numbers.
        /// </summary>
        /// <param name="number">A string containing numeric characters.</param>
        /// <returns>The total sum of the digits.</returns>
        static int SumOfDigits(string number)
        {
          int sum = 0;
            foreach (char digit in number)
            {
                sum += (int)Char.GetNumericValue(digit);
            }
            return sum;
        }
    }
}
