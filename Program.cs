namespace Lab5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            char[] arrayOfChar = number.ToCharArray();

            if (IsCorrect(arrayOfChar))
            {
                Console.WriteLine(SumOfNumbers(arrayOfChar));
            }
        }
        private static bool IsCorrect(char[] arrayOfChar)
        {

            if (arrayOfChar[0] == '-' || Char.IsDigit(arrayOfChar[0]))
            {
                for (int i = 1; i < arrayOfChar.Length; i++)
                {
                    if (!Char.IsDigit(arrayOfChar[i]))
                    {
                        Console.WriteLine("Not correct");
                        return false;
                    }
                }
            }

            return true;
        }

        private static int SumOfNumbers(char[] arrayOfChar)
        {
            int sum = 0;
            if (arrayOfChar[0] == '-')
            {
                for (int i = 1; i < arrayOfChar.Length; i++)
                {
                    sum += arrayOfChar[i] - '0';
                }
            }
            else
            {
                for (int i = 0; i < arrayOfChar.Length; i++)
                {
                    sum += arrayOfChar[i] - '0';
                }
            }
            return sum;
        }
    }
}