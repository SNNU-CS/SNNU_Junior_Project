/*
Problem:比赛日程表
Author:QiZhao
Data:2018-09-30
Description:
Copyright  2018 QiZhao. All rights reserved.
*/

#include<iostream>
#include<cstring>
#include<string>
class calendar
{
public:
    calendar(int nn);// 构造函数，间接实现动态二维数组
    ~calendar();// 析构函数
    void print_to_crt();// 输出到显示器
    void print_to_file();// TODO 输出到文件
    std::string return_string();
protected:
    void solve(int start, int n);
private:
    bool solve_finished; //是否被solve过
    int n = 0;//数组大小
    int **ans;
};
// 构造函数 申请内存空间
calendar::calendar(int nn)
{
    solve_finished = false;
    n = nn;
    ans = new int *[n + 3];
    for (int i = 0; i <= n + 2; i++)
        ans[i] = new int[n + 1];
    for (int i = 1; i <= n; i++)
        ans[i][0] = i;
}
// 析构函数，释放内存
calendar::~calendar()
{
    for (int i = 0; i < n + 1; i++)
        delete[] ans[i];
    delete[] ans;
}

// 返回答案字符串
std::string calendar::return_string()
{
    std::string res;
    if (!solve_finished)
    {
        solve(1, n);
        solve_finished = true;
    }
    int day = n % 2 == 0 ? n - 1 : n;
    for (int i = 1; i <= n; i++)
    {
        res += "第" + std::to_string(i) +"个人的每天比赛对手分别是: ";
        for (int j = 0; j <= day; j++)
        {
            res += std::to_string( static_cast<int> ( ans[i][j] ) );
            res += " ";
        }
        res += '\n';
    }
    return res;
}
// 输出到标准流 答案
void calendar::print_to_crt()
{
    if (!solve_finished)
    {
        solve(1, n);
        solve_finished = true;
    }
    //cout << "\t\t\t" << n << "人日程表" << endl;
    int day = n % 2 == 0 ? n - 1 : n;
    for (int i = 1; i <= n; i++)
    {
        for (int j = 0; j <= day; j++)
        {
            std::cout << ans[i][j] << " ";
        }
        std::cout << std::endl;
    }
    std::cout << "--------------" << std::endl;
}
// 解决问题
void calendar::solve(int start, int n)
{
    int temp;
    if (n == 2)//只有2人,直接安排赛程
    {
        ans[start][1] = ans[start + 1][0];
        ans[start + 1][1] = ans[start][0];
    }
    else
    {
        if (n % 2 == 1) //n为奇数
        {
            temp = ans[start + n][0];
            ans[start + n][0] = 0;
            solve(start, n + 1);
            ans[start + n][0] = temp;
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
                        if (ans[i][j] == 0)
                        {
                            ans[i][j] = ans[i + m][0];
                            ans[i + m][j] = ans[i][0];
                        }
                    }
                }
                for (int i = 1; i <= m; i++)
                {
                    for (int j = m + 1; j < n; j++)
                    {
                        int temp = (i + j - 1) % m + m + 1;
                        ans[start + i - 1][j] = ans[start + temp - 1][0];
                        ans[start + temp - 1][j] = ans[start + i - 1][0];
                    }
                }
            }
            else//m为偶数,安排第m天到第n-1天的赛程
            {
                for (int i = 1; i <= m; i++)
                {
                    for (int j = m; j <= n - 1; j++)
                    {
                        int temp = (i + j - 1) % m + m + 1;
                        ans[start + i - 1][j] = ans[start + temp - 1][0];
                        ans[start + temp - 1][j] = ans[start + i - 1][0];
                    }
                }
            }
        }
    }
}
