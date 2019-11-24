using System;

namespace RegularContest031
{
    class Program
    {
        static int[,] map = new int[10, 10];
        static int[,] judge = new int[10,10];
        const int H = 10;
        const int W = 10;

        static void Main(string[] args)
        {
            // Incorrect

            string[] str = new string[10];
            for(int i=0; i<10; i++)
            {
                str[i] = Console.ReadLine();
                for(int j=0; j<10; j++)
                {
                    if(str[i][j] == 'o') map[i, j] = 1;
                    else map[i, j] = 0;
                }
            }
            
            bool ans = new bool();
            ans = false;
            for(int i = 0; i<10; i++)
            {
                for(int j=0; j<10; j++)
                {
                    if(ans == false)
                    {
                        Array.Copy(map, judge, map.Length);
                        if(judge[i, j] == 0)
                        {
                            judge[i, j] = 1;
                            dfs(i, j);
                            ans = check();
                        }
                    }
                }
            }
            
             Debug_map();
             
            if(ans == true) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }

        public static void dfs(int x, int y)
        {
            if(x<0 || x>=W || y<0 || y>=H)
            {
                return;
            }
            if(judge[x, y]==0 || judge[x, y]==2)
            {
                return;
            }
            judge[x, y] = 2;
            dfs(x+1, y);
            dfs(x-1, y);
            dfs(x, y-1);
            dfs(x, y+1);
        }
        public static bool check()
        {
            for(int i=0; i<10; i++)
            {
                for(int j=0; j<10; j++)
                {
                    if(judge[i, j]==1) return false;
                }
            }
            return true;
        }

        public static void Debug_map()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("マップ");
            for(int k=0; k<10; k++)
            {
                for(int l=0; l<10; l++)
                {
                    Console.Write(map[k, l]);
                    if(l==9) Console.WriteLine();
                }
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine("判定");
            for(int k=0; k<10; k++)
            {
                for(int l=0; l<10; l++)
                {
                    Console.Write(judge[k, l]);
                    if(l==9) Console.WriteLine();
                }
            }
        }
    }
}
