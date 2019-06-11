using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp
{
    class calendar
    {

        private bool solve_finished; //是否被solve过
        private int n = 0;//数组大小
        private int[,] ans;
        private int day;

        // 构造函数 申请内存空间
        public calendar(int nn)
        {
            solve_finished = false;
            n = nn;
            ans = new int[n + 10, n + 4];
            for (int i = 1; i <= n; i++)
                ans[i, 0] = i;
            day = n % 2 == 0 ? n - 1 : n;
        }

        // 析构函数，释放内存
        public void print_to_crt()// 输出到显示器
        {
            if (!solve_finished)
            {
                solve(1, n);
                solve_finished = true;
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i.ToString()+" ");
                for (int j = 1; j <= day; j++)
                {
                    Console.Write( ans[i, j].ToString()+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------");
            return;
        }
        public string[,] return_string()
        {
            if (!solve_finished)
            {
                solve(1, n);
                solve_finished = true;
            }
            string[,] ret = new string[n + 1, day + 1];
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= day; j++)
                {
                    ret[i, j] = ans[i, j ].ToString();
                }
            }
            return ret;
        }
        protected void solve(int start, int n)
        {
            int temp;
            if (n == 2)//只有2人,直接安排赛程
            {
                ans[start, 1] = ans[start + 1, 0];
                ans[start + 1, 1] = ans[start, 0];
            }
            else
            {
                if (n % 2 == 1) //n为奇数
                {
                    temp = ans[start + n, 0];
                    ans[start + n, 0] = 0;
                    solve(start, n + 1);
                    ans[start + n, 0] = temp;
                }
                else//n为偶数
                {
                    int m = n / 2;
                    solve(start, m);
                    solve(start + m, m);
                    if (m % 2 == 1)//m为奇数,安排第m+1天到第n-1天的赛程
                    {
                        for (int i = start; i < start + m; i++)//安排两组中轮空的2个选手比赛
                        {
                            for (int j = 1; j <= m; j++)
                            {
                                if (ans[i, j] == 0)
                                {
                                    ans[i, j] = ans[i + m, 0];
                                    ans[i + m, j] = ans[i, 0];
                                }
                            }
                        }
                        for (int i = 1; i <= m; i++)
                        {
                            for (int j = m + 1; j < n; j++)
                            {
                                int ttemp = (i + j - 1) % m + m + 1;
                                ans[start + i - 1, j] = ans[start + ttemp - 1, 0];
                                ans[start + ttemp - 1, j] = ans[start + i - 1, 0];
                            }
                        }
                    }
                    else//m为偶数,安排第m天到第n-1天的赛程
                    {
                        for (int i = 1; i <= m; i++)
                        {
                            for (int j = m; j <= n - 1; j++)
                            {
                                int ttemp = (i + j - 1) % m + m + 1;
                                ans[start + i - 1, j] = ans[start + ttemp - 1, 0];
                                ans[start + ttemp - 1, j] = ans[start + i - 1, 0];
                            }
                        }
                    }
                }
            }
        }

        public int getDay()
        {
            return day;
        }
    }
}