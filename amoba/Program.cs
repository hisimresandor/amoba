using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amoba
{
    class Program
    {
        static char[,] feltoltes()
        {
            char[,] temp = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    temp[i, j] = '*';
                }
            }
            return temp;
        }

        static void kiiras(char[,] temp)
        {
            Console.Clear();
            Console.WriteLine("Amőba\n");
            Console.WriteLine("  A B C");
            for (int i = 0; i < 3; i++)
            {
                Console.Write((i + 1) + " ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(temp[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            char[,] jatek = feltoltes();
            kiiras(jatek);
            bool end = false;
            int kor = 0;
            string mezo;
            int x;
            int y;
            char winner = '*';

            while (!end)
            {
                if (kor % 2 == 0)
                {
                    do
                    {
                        Console.WriteLine("\nX köre!");
                        Console.Write("Adja meg a megjelölni kívánt mezőt (pl.: A1): ");
                        mezo = Console.ReadLine();
                        x = mezo[1] - 49;
                        y = mezo[0] - 65;
                        kiiras(jatek);
                    } while (jatek[x,y] != '*');
                    jatek[x, y] = 'X';
                } else
                {
                    do
                    {
                        Console.WriteLine("\nY köre!");
                        Console.Write("Adja meg a megjelölni kívánt mezőt (pl.: A1): ");
                        mezo = Console.ReadLine();
                        x = mezo[1] - 49;
                        y = mezo[0] - 65;
                        kiiras(jatek);
                    } while (jatek[x, y] != '*');
                    jatek[x, y] = 'Y';
                }

                for (int i = 0; i < 3; i++)
                {
                    if (jatek[i, 0] == 'X' && jatek[i, 1] == 'X' && jatek[i, 2] == 'X')
                    {
                        end = true;
                        winner = 'X';
                        Console.WriteLine(1);
                    }
                    else if (jatek[i, 0] == 'Y' && jatek[i, 1] == 'Y' && jatek[i, 2] == 'Y')
                    {
                        end = true;
                        winner = 'Y';
                    }
                    else if (jatek[0, i] == 'X' && jatek[1, i] == 'X' && jatek[2, i] == 'X')
                    {
                        end = true;
                        winner = 'X';
                    }
                    else if (jatek[0, i] == 'Y' && jatek[1, i] == 'Y' && jatek[2, i] == 'Y')
                    {
                        end = true;
                        winner = 'Y';
                    }
                }
                if (jatek[0, 0] == 'X' && jatek[1, 1] == 'X' && jatek[2, 2] == 'X')
                {
                    end = true;
                    winner = 'X';
                }
                else if (jatek[0, 0] == 'Y' && jatek[1, 1] == 'Y' && jatek[2, 2] == 'Y')
                {
                    end = true;
                    winner = 'Y';
                }
                else if (jatek[0, 2] == 'X' && jatek[1, 1] == 'X' && jatek[2, 0] == 'X')
                {
                    end = true;
                    winner = 'X';
                    Console.WriteLine(4);
                }
                else if (jatek[0, 2] == 'Y' && jatek[1, 1] == 'Y' && jatek[2, 0] == 'Y')
                {
                    end = true;
                    winner = 'Y';
                }
                kiiras(jatek);
                kor++;
            }
            Console.WriteLine("Ezt a játékot a(z) " + winner + " játékos nyerte.");


            Console.ReadKey();
        }
    }
}
