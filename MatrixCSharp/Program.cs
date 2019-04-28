using System;

namespace MatrixCSharp
{

    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0;
            int n = 0, m = 0;
            Console.Write("Insira a quantidade de linhas da matriz: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Insira a quantidade de colunas da matriz: ");
            m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m]; ;
            Console.WriteLine("\nInsira as linhas da matriz: ");


            for (i = 0; i < n; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                for (j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(linha[j]);
                }
            }

            Console.Write("\nInsira um valor pertecente a matriz: ");
            int x = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    if (matrix[i, j] == x)
                    {
                        Console.WriteLine("\nPosition: " + i + "," + j);
                        Console.WriteLine("Left: " + PositionLeft(j));
                        Console.WriteLine("Right: " + PositionRight(j));
                        Console.WriteLine("Up: " + PositionUp(i));
                        Console.WriteLine("Down: " + PositionDown(i));
                        Console.WriteLine();
                    }

                }
            }

            string PositionLeft(int c)
            {
                if (c > 0)
                {
                    return matrix[i, j - 1].ToString();
                }
                else
                {
                    return "N/A";
                }
            }
            string PositionRight(int c)
            {
                if (c < n - 1)
                {
                    return matrix[i, j + 1].ToString();
                }
                else
                {
                    return "N/A";
                }
            }
            string PositionUp(int l)
            {
                if (l > 0)
                {
                    return matrix[i - 1, j].ToString();
                }
                else
                {
                    return "N/A";
                }
            }
            string PositionDown(int l)
            {
                if (l < n - 1)
                {
                    return matrix[i + 1, j].ToString();
                }
                else
                {
                    return "N/A";
                }
            }
        }


    }
}
