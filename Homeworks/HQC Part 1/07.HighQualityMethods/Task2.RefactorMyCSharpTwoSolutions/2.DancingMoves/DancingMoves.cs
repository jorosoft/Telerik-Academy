using System;
using System.Linq;

class DancingMoves
{
    static void Main()
    {
        var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var input = Console.ReadLine();
        double result = 0;
        int moves = 0;
        int position = 0;
        while (input != "stop")
        {
            var move = input.Split(' ');
            var movesCount = int.Parse(move[0]);
            var direction = move[1];
            var step = int.Parse(move[2]);            
            int sum = 0;
            if (direction == "right")
            {
                for (int i = 0; i < movesCount; i++)
                {
                    position += (step % array.Length);
                    if (position > array.Length - 1)
                    {
                        position = position - array.Length;
                    }
                    sum += array[position];
                }
            }
            if (direction == "left")
            {
                for (int i = 0; i < movesCount; i++)
                {
                    position -= (step % array.Length);
                    if (position < 0)
                    {
                        position = array.Length + position;
                    }
                    sum += array[position];
                }
            }
            result += sum;
            moves++;
            input = Console.ReadLine();
        }
        Console.WriteLine("{0:F1}", result / moves);
    }
}
