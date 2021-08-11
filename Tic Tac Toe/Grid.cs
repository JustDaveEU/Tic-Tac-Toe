using System;

namespace Tic_Tac_Toe
{
    public class Grid
    {
        //Fields

        //Constructor

        public Grid()
        {
            char[][] grid = new char[3][];
            grid[0] = new[] {'7', '8', '9'};
            grid[1] = new[] {'4', '5', '6'};
            grid[2] = new[] {'1', '2', '3'};
            FullGrid = grid;
        }

        //Properties

        public char[][] FullGrid { get; }

        public char[] RowOne => FullGrid[0];
        public char[] RowTwo => FullGrid[1];
        public char[] RowThree => FullGrid[2];
        

        public void PrintGrid()
        {
            WriteContentLine(FullGrid[0]);
            DrawLine();
            WriteContentLine(FullGrid[1]);
            DrawLine();
            WriteContentLine(FullGrid[2]);
        }

        private void DrawLine()
        {
            Console.WriteLine("---+---+---");
        }

        private void WriteContentLine(char[] line)
        {
            for (int index = 0; index < 2; ++index)
                if (char.IsNumber(line[index]))
                {
                    Console.Write($"({line[index]})");
                    Console.Write("|");
                }
                else
                {
                    switch (line[index])
                    {
                        case 'X':
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case 'O':
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                    }

                    Console.Write($" {line[index]} ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("|");
                }

            if (char.IsNumber(line[2]))
            {
                Console.Write($"({line[2]})");
                Console.WriteLine("");
            }
            else
            {
                switch (line[2])
                {
                    case 'X':
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case 'O':
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                }

                Console.Write($" {line[2]} ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("");
            }

        }
    }
}