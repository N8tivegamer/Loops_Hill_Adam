namespace Loops_Hill_Adam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Why do you want to make games?");
            string responce = Console.ReadLine();

            Console.WriteLine($"The sentence, \"{responce}\" has {CountNumberOfSpaces(responce)} spaces in it. ");


            Console.WriteLine("Please enter a whole number!");
            string responce2 = Console.ReadLine();

            Console.WriteLine($"The sum of the individual digits of {responce2} is {SumOfDigits(responce2)}");
        }
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
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
