namespace Minimum_Number_of_Swaps_to_Make_String_Balanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int MinSwaps(string s)
        {
            // https://www.youtube.com/watch?v=3YDBT9ZrfaU
            int closingBrackets = 0;
            int min = 0;
            foreach (char c in s)
            {
                if (c == '[')
                {
                    closingBrackets--;
                }
                else if (c == ']')
                {
                    closingBrackets++;
                }
                min = Math.Max(closingBrackets, min);
            }

            return (min + 1) / 2;
        }
    }
}
