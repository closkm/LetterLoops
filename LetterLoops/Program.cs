using System.Text;

namespace LetterLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some random letters");

            string input = Console.ReadLine();
            StringBuilder customString = new StringBuilder();

            for(int i = 0; i < input.Length; i++)
            {
                for(int j = 0; j < i + 1; j++)
                {
                    if (j == 0 && i == 0)
                    {
                        char upper = Char.ToUpper(input[i]);
                        customString.Append(upper + "-");
                    }
                    else if (j == i && i != input.Length - 1)
                    {
                        char lower = Char.ToLower(input[i]);
                        customString.Append(lower + "-");
                    }
                    else if (j == i) {
                        char lower = Char.ToLower(input[i]);
                        customString.Append(lower);
                    }
                    else if (j == 0)
                    {
                        char upper = Char.ToUpper(input[i]);
                        customString.Append(upper);
                    }
                    else if(j < i)
                    {
                        char lower = Char.ToLower(input[i]);
                        customString.Append(lower);
                    }
                }
            }
            Console.WriteLine(customString);
        }
    }
}