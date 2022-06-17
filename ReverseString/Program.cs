using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Oluwafemi Moses";
            string reversedName = ReverseString(name);
            Console.WriteLine(name + " written backward is: " + reversedName);
        }


        //Reverse for loop count end of the name to the beginning
        private static string ReverseString(string name)
        {
            string r = "";

            for (int i = name.Length - 1; i >= 0; i--)
            {
                r += name[i];
            }

            return r;
        }
    }
}

