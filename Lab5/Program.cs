/**
 * Grading ID:  L8486
 * Lab:         5
 * Course:      CIS199-72
 * Due:         10/27/19
 * Description: Displays the 4 star patterns separately, one after the other.
 **/

using System;
using static System.Console;

namespace Lab5
{
    class Program
    {
        private const int MAX_ROWS = 10;    // Maximum rows in each pattern

        // Main method that uses nested for loops to draw stars using WriteLines
        static void Main()
        {
            int spaces; // Amount of spaces used in patterns C & D

            WriteLine("Pattern A");
            WriteLine();
            for (int rows = 0; rows <= MAX_ROWS; ++rows)
            {
                for (int stars = 0; stars <= rows; ++stars)
                {
                    Write("*");
                }
                WriteLine();
            }
            WriteLine();
            WriteLine("Pattern B");
            WriteLine();
            for (int rows = MAX_ROWS; rows >= 0; --rows)
            {
                for (int stars = 0; stars <= rows; ++stars)
                {
                    Write("*");
                }
                WriteLine();
            }
            WriteLine();
            WriteLine("Pattern C");
            WriteLine();
            for (int rows = MAX_ROWS; rows >= 0; --rows)
            {
                
                for (spaces = MAX_ROWS - rows; spaces >= 0; --spaces)
                {
                    Write(" ");
                }
                for (int stars = 0; stars <= rows; ++stars)
                {
                    Write("*");
                }
                WriteLine();
            }
            WriteLine();
            WriteLine("Pattern D");
            WriteLine();
            for (int rows = 0; rows <= MAX_ROWS; ++rows)
            {

                for (spaces = MAX_ROWS - rows; spaces >= 0; --spaces)
                {
                    Write(" ");
                }
                for (int stars = 0; stars <= rows; ++stars)
                {
                    Write("*");
                }
                WriteLine();
            }
        }
    }
}