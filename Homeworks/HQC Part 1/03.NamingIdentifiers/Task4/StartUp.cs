namespace Minesweeper
{
    using System;
    using System.Collections.Generic;
    using Models;

    public class StartUp
    {
        internal static void Main()
        {
            string command = string.Empty;
            char[,] gameField = CreateGameField();
            char[,] bombs = FillTheBombs();
            int counter = 0;
            bool hasExplosion = false;
            List<Player> shampions = new List<Player>(6);
            int row = 0;
            int column = 0;
            bool isGameEnded = true;
            const int MaxCells = 35;
            bool isWinner = false;

            do
            {
                if (isGameEnded)
                {
                    Console.WriteLine("Let's play “Minesweeper”. Try your best to find out fields without mines." +
                    " Command 'top' shows ScoreBoard, 'restart' starts new game, 'exit' will leave the game!");
                    Dumpp(gameField);
                    isGameEnded = false;
                }

                Console.Write("Enter row and column : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out column) &&
                        row <= gameField.GetLength(0) && column <= gameField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        ShowScoreBoard(shampions);
                        break;
                    case "restart":
                        gameField = CreateGameField();
                        bombs = FillTheBombs();
                        Dumpp(gameField);
                        hasExplosion = false;
                        isGameEnded = false;
                        break;
                    case "exit":
                        Console.WriteLine("Good bye!");
                        break;
                    case "turn":
                        if (bombs[row, column] != '*')
                        {
                            if (bombs[row, column] == '-')
                            {
                                NextTurn(gameField, bombs, row, column);
                                counter++;
                            }

                            if (MaxCells == counter)
                            {
                                isWinner = true;
                            }
                            else
                            {
                                Dumpp(gameField);
                            }
                        }
                        else
                        {
                            hasExplosion = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Invalid command\n");
                        break;
                }

                if (hasExplosion)
                {
                    Dumpp(bombs);
                    Console.Write(
                        "\nHrrrrrr! You are dead with {0} points. " +
                        "Enter your nickname: ",
                        counter);
                    string nickname = Console.ReadLine();
                    Player currentResult = new Player(nickname, counter);
                    if (shampions.Count < 5)
                    {
                        shampions.Add(currentResult);
                    }
                    else
                    {
                        for (int index = 0; index < shampions.Count; index++)
                        {
                            if (shampions[index].Points < currentResult.Points)
                            {
                                shampions.Insert(index, currentResult);
                                shampions.RemoveAt(shampions.Count - 1);
                                break;
                            }
                        }
                    }

                    shampions.Sort((Player r1, Player r2) => r2.Name.CompareTo(r1.Name));
                    shampions.Sort((Player r1, Player r2) => r2.Points.CompareTo(r1.Points));
                    ShowScoreBoard(shampions);

                    gameField = CreateGameField();
                    bombs = FillTheBombs();
                    counter = 0;
                    hasExplosion = false;
                    isGameEnded = true;
                }

                if (isWinner)
                {
                    Console.WriteLine("\nCONGRATULATIONS! You open 35 cells without a drop blood.");
                    Dumpp(bombs);
                    Console.WriteLine("Enter your name : ");
                    string playerName = Console.ReadLine();
                    Player playerPoints = new Player(playerName, counter);
                    shampions.Add(playerPoints);
                    ShowScoreBoard(shampions);
                    gameField = CreateGameField();
                    bombs = FillTheBombs();
                    counter = 0;
                    isWinner = false;
                    isGameEnded = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria!");
            Console.WriteLine("Good bye.");
            Console.Read();
        }

        private static void ShowScoreBoard(List<Player> points)
        {
            Console.WriteLine("\nPOINTS:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine(
                        "{0}. {1} --> {2} cells",
                        i + 1, 
                        points[i].Name, 
                        points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty ScoreBoard!\n");
            }
        }

        private static void NextTurn(char[,] field, char[,] bombs, int row, int column)
        {
            char currentBombs = CheckBombs(bombs, row, column);
            bombs[row, column] = currentBombs;
            field[row, column] = currentBombs;
        }

        private static void Dumpp(char[,] board)
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] FillTheBombs()
        {
            int rows = 5;
            int columns = 10;
            char[,] fameField = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    fameField[i, j] = '-';
                }
            }

            List<int> r3 = new List<int>();
            while (r3.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);
                if (!r3.Contains(randomNumber))
                {
                    r3.Add(randomNumber);
                }
            }

            foreach (int i2 in r3)
            {
                int column = i2 / columns;
                int row = i2 % columns;
                if (row == 0 && i2 != 0)
                {
                    column--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                fameField[column, row - 1] = '*';
            }

            return fameField;
        }

        private static void Calculate(char[,] field)
        {
            int column = field.GetLength(0);
            int row = field.GetLength(1);

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char currentBombs = CheckBombs(field, i, j);
                        field[i, j] = currentBombs;
                    }
                }
            }
        }

        private static char CheckBombs(char[,] bombs, int row, int column)
        {
            int count = 0;
            int rows = bombs.GetLength(0);
            int columns = bombs.GetLength(1);

            if (row - 1 >= 0)
            {
                if (bombs[row - 1, column] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < rows)
            {
                if (bombs[row + 1, column] == '*')
                {
                    count++;
                }
            }

            if (column - 1 >= 0)
            {
                if (bombs[row, column - 1] == '*')
                {
                    count++;
                }
            }

            if (column + 1 < columns)
            {
                if (bombs[row, column + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (bombs[row - 1, column - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (column + 1 < columns))
            {
                if (bombs[row - 1, column + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (bombs[row + 1, column - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (column + 1 < columns))
            {
                if (bombs[row + 1, column + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}