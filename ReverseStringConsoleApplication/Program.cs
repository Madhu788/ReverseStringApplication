using System;

namespace ReverseStringConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ReverseString("tree");
        }

        internal static void ReverseString(string str)
        {

            char[] charArray = str.ToCharArray();
            for (int i=0, j=str.Length-1; i<j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string newArrayString = new string(charArray);
            Console.WriteLine(newArrayString);
        }
    }
}
