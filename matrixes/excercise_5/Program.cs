using System;
using System.Linq;

namespace excercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int [][] rubixMatrix = CreateRubiksMatrix(dimensions);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int rowCol = int.Parse(commands[0]);
                string direction = commands[1];
                int moves = int.Parse(commands[2]);
                if (direction == "up")
                {
                    MoveUp(rubixMatrix, rowCol, moves % dimensions[0]);
                }
                if (direction == "down")
                {
                    MoveDown(rubixMatrix, rowCol, moves % dimensions[0]);
                }
                if (direction == "left")
                {
                    MoveLeft(rubixMatrix, rowCol, moves % dimensions[1]);
                }
                if (direction == "right")
                {
                    MoveRight(rubixMatrix, rowCol, moves % dimensions[1]);
                }

            }

            int counter = 1;
            for (int row = 0; row < rubixMatrix.Length; row++)
            {
                for (int col = 0; col < rubixMatrix[row].Length; col++)
                {
                    if (rubixMatrix[row][col] == counter)
                    {
                        Console.WriteLine("No swap required");
                        counter++;
                    }
                    else
                    {
                        Rearange(rubixMatrix, row, col, counter);
                        counter++;
                    }
                }
            }

            //PrintMatrix(rubixMatrix);

        }

        private static void Rearange(int[][] rubixMatrix, int row, int col, int counter)
        {
            
            for (int targerRow = 0; targerRow < rubixMatrix.Length; targerRow++)
            {
                for (int targetCol = 0; targetCol < rubixMatrix[targerRow].Length; targetCol++)
                {
                    if (rubixMatrix[targerRow][targetCol] == counter)
                    {
                        rubixMatrix[targerRow][targetCol] = rubixMatrix[row][col];
                        rubixMatrix[row][col] = counter;
                        Console.WriteLine($"Swap ({row}, {col}) with ({targerRow}, {targetCol})");
                    }
                }
            }
        }

        private static void MoveRight(int[][] rubixMatrix, int row, int moves)
        {
            for (int i = 0; i < moves; i++)
            {
                int last = rubixMatrix[row][rubixMatrix[row].Length - 1];
                for (int col = rubixMatrix[row].Length - 1; col > 0; col--)
                {
                    rubixMatrix[row][col] = rubixMatrix[row][col - 1];
                }
                rubixMatrix[row][0] = last;
            }
        }

        private static void MoveLeft(int[][] rubixMatrix, int row, int moves)
        {
            for (int i = 0; i < moves; i++)
            {
                int first = rubixMatrix[row][0];
                for (int col = 0; col < rubixMatrix.Length - 1; col++)
                {
                    rubixMatrix[row][col] = rubixMatrix[row][col + 1];
                }
                rubixMatrix[row][rubixMatrix[row].Length - 1] = first;
            }
        }

        private static void MoveDown(int[][] rubixMatrix, int col, int moves)
        {
            for (int i = 0; i < moves; i++)
            {
                int last = rubixMatrix[rubixMatrix.Length - 1][col];
                for (int row = rubixMatrix.Length - 1; row > 0 ; row--)
                {
                    rubixMatrix[row][col] = rubixMatrix[row - 1][col];
                }
                rubixMatrix[0][col] = last;
            }
        }

        private static void MoveUp(int[][] rubixMatrix, int col, int moves)
        {
            for (int i = 0; i < moves; i++)
            {
                int first = rubixMatrix[0][col];
                for (int row = 0; row < rubixMatrix.Length - 1; row++)
                {
                    rubixMatrix[row][col] = rubixMatrix[row + 1][col];
                }
                rubixMatrix[rubixMatrix.Length - 1][col] = first;
            }
        }

        private static void PrintMatrix(int[][] rubixMatrix)
        {
            for (int row = 0; row < rubixMatrix.Length; row++)
            {
                for (int col = 0; col < rubixMatrix.Length; col++)
                {
                    Console.Write(rubixMatrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int[][] CreateRubiksMatrix(int[] dimensions)
        {
            int[][] rubiksMatrix = new int[dimensions[0]][];
            int counter = 1;
            for (int row = 0; row < rubiksMatrix.Length; row++)
            {
                rubiksMatrix[row] = new int[dimensions[1]];
                for (int col = 0; col < rubiksMatrix[row].Length; col++)
                {
                    rubiksMatrix[row][col] = counter;
                    counter++;
                }
            }
            return rubiksMatrix;
        }
    }
}
