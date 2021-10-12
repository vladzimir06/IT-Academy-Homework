using System;

namespace _6
{
    class Program
    {
        private const int X = 60;
        private const int Y = 20;
       
        enum eDirection
        {
            STOP = 0,
            LEFT,
            RIGHT,
            UP,
            DOWN
        }

        static void Pole()
        {
            Console.Clear();
            int x = X / 2;
            int y = 5;
            for (int i = 0; i < X + 1; i++)
            {
                Console.Write("#");
            }

            for (int i = 0; i < Y; i++)
            {
                for (int j = 0; j < X; j++)
                {
                    if (j == 0) Console.Write("#");
                    if (j == X - 1) Console.Write("#");
                    if (i == y - 1 && j == x + 1) Console.Write("0");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 20; i++)
            {
                Console.Write("#");
            }
        }

        static void Main(string[] args)
        {
            int x = X / 2;
            int y = 5;
            eDirection dir;
            
            // Нажатие клавиш
            bool gameOver = false;
            while (!gameOver)
            {
                Pole();
                if (Console.KeyAvailable)
                {
                    var keyInfo = Console.ReadKey();
                    switch (keyInfo.KeyChar)
                    {
                        case 'a':
                            dir = eDirection.LEFT;
                            break;
                        case 'd':
                            dir = eDirection.RIGHT;
                            break;
                        case 'w':
                            dir = eDirection.UP;
                            break;
                        case 's':
                            dir = eDirection.DOWN;
                            break;
                    }
                }

                switch (eDirection.STOP)
                {
                    case eDirection.LEFT:
                        x--;
                        break;
                    case eDirection.RIGHT:
                        x++;
                        break;
                    case eDirection.UP:
                        y--;
                        break;
                    case eDirection.DOWN:
                        y++;
                        break;
                }
                
            }
                
        }
    }
}
