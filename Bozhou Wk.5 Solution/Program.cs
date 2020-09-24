/* Programmer: Bozhou Chem
 * Group Members: Jacob B, Charles B, Tyler D, Bozhou C, Cyrus C
 * Date: 9/24/2020
 * C#
 * Week 5 Group Exercise
 * Purpose: Allows the user to input any number of hexadecimal characters
 *          Sum the values and display the sum as a hexadecimal value.
 */
using System;
using static System.Console;

namespace Bozhou_Wk._5_Solution
{
    class Isosceles_triangle_printer
    {
        public static void Main(string[] args)
        {
            char ch1, ch2;
            int peak1, peak2;
            ch1 = PromptC();
            ch2 = CheckC(ch1);
            peak1 = PromptP();
            peak2 = CheckP(peak1);
            WriteLine();
            PrintT(peak2, ch2);
            ReadKey();
        }  // end of Main()

        public static char PromptC()  // prompt a character from the user
        {
            string inputValue;
            char a;
            Write("Please enter a character for your isosceles triangle: ");
            inputValue = ReadLine();
            a = char.Parse(inputValue);
            return a;
        }
        public static int PromptP()  // prompt the peak from the user
        {
            string inputValue;
            int b;
            Write("Please enter the size of the peak for the triangle (enter an integer): ");
            inputValue = ReadLine();
            b = int.Parse(inputValue);
            return b;
        }
        public static char CheckC(char a)  // check whether the character is valid
        {
            bool result;
            char newC;
            result = Char.IsSymbol(a);
            if (result == true)
                newC = a;
            else
                newC = '*';
            return newC;
        }
        public static int CheckP(int b)  // check whether the user's input value is > 10 or < 2
        {
            int c;
            if (b > 10 || b < 2)
                c = 3;
            else
                c = b;

            return c;
        }
        public static void PrintT(int c, char newC)  // print isosceles triangle
        {
            for (int i = 1; i <= c; i++)
            {
                string newS = NewString(newC, i);
                Write(newS);
                WriteLine();
            }
            for (int i = c-1; i >= 1; i--)
            {
                string newS = NewString(newC, i);
                Write(newS);
                WriteLine();
            }
            return;
        }
        public static string NewString(char newC, int n)  // repeat characters
        {
            return new String(newC, n);
        }
    }
}
