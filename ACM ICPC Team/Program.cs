using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var line1 = Console.ReadLine();
        int N = int.Parse(line1.Split(' ')[0].Trim());
        int M = int.Parse(line1.Split(' ')[1].Trim());

        var list = new List<string>();
        for (int i = 0; i < N; i++) 
        {
            list.Add(Console.ReadLine());
        }

        bool[,] matrix = new bool[N,M];
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                matrix[i, j] = list[i].ToCharArray()[j] == '1';
            }
        }

        int highest = 0;
        int nHighest = 0;

        for (int i = 0; i < N; i++)
        {
            for (int j = i+1; j < N; j++)
            {
                int score = 0;
                for (int k = 0; k < M; k++)
                {
                    if (matrix[i, k] || matrix[j, k])
                    {
                        score++;
                    }
                }
                if (score > highest)
                {
                    highest = score;
                    nHighest = 1;
                }
                else if (score == highest)
                {
                    nHighest++;
                }
            }
        }
        Console.WriteLine(highest);
        Console.WriteLine(nHighest);
    }
}