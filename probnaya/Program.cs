using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
namespace probnaya
{
    
        enum EActiv
        {
            STOP = 0, LEFT, RIGHT, UP, DOWN
        };

        class Program
        {
            
           
            static bool gameOver;
            const int width = 20;
            const int height = 20;
            static int x, y;
          

            static EActiv dir;
            static void setup()
            {
                Random rand = new Random();
                int marvel = rand.Next();

                gameOver = false;
                dir = EActiv.STOP;
                x = width / 2;
                y = height / 2;
                
            }
            static void draw()
            {
                Console.Clear();
                for (int i = 0; i <= width; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (j == 0 || j == (width - 1))
                        {
                           Console.Write("#");
                        }
                        if (i == y && j == x)
                        {
                             Console.Write("0");
                        }
                       
                        else
                        {
                             Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i <= width; i++)
                {
                   Console.Write("#");
                }
                Console.WriteLine();
              
            }
            static void input()
            {
                if (Console.KeyAvailable)
                {
                    var keyInfo = Console.ReadKey();
                    switch (keyInfo.KeyChar)
                    {
                        case 'a':
                            dir = EActiv.LEFT;
                            break;
                        case 'd':
                            dir = EActiv.RIGHT;
                            break;
                        case 'w':
                            dir = EActiv.UP;
                            break;
                        case 's':
                            dir = EActiv.DOWN;
                            break;
                        case 'x':
                            gameOver = true;
                            break;
                    }
                }
            }
            static void logicOfGame()
            {
                switch (dir)
                {
                    case EActiv.LEFT:
                        x--;
                        break;
                    case EActiv.RIGHT:
                        x++;
                        break;
                    case EActiv.DOWN:
                        y++;
                        break;
                    case EActiv.UP:
                        y--;
                        break;

                }
             
                    if (x >= width)
                        x = 0;
                    else if (x < 0)
                        x = width - 1;
                    if (y >= height)
                        y = 0;
                    else if (y < 0)
                        y = height - 1;
              
            }
            static void Main(string[] args)
            {
                setup();
                while (!gameOver)
                {
                    draw();
                    input();
                    logicOfGame();
                    Thread.Sleep(10);
                            
                }
            }

        }
}
