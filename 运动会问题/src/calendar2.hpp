/*
Problem:�����ճ̱�
Author:QiZhao
Data:2018-09-30
Description:
Copyright  2018 QiZhao. All rights reserved.
*/

#include<iostream>
class calendar
{
    public:
        calendar(int nn);// ���캯�������ʵ�ֶ�̬��ά����
        ~calendar();// ��������
        void print_to_crt();// �������ʾ��
        void print_to_file();// TODO ������ļ�
    protected:
        void solve(int start,int n);
    private:
        bool solve_finished; //�Ƿ�solve��
        int n=0;//�����С
        int **ans;
};

calendar::calendar( int nn )
{
    solve_finished=false;
    n = nn;
    ans = new int *[n+3];
    for( int i = 0  ; i <= n + 2 ; i++)
        ans[i] = new int[n+1];
    for( int i = 1 ; i <= n ; i++)
        ans[i][0] = i ;
}

calendar::~calendar()
{
    for( int i = 0 ; i < n + 1 ; i++)
        delete[] ans[i];
    delete[] ans;
}

void calendar::print_to_crt()
{
    if( !solve_finished )
    {
        solve( 1,n);
        solve_finished = true;
    }
    //cout << "\t\t\t" << n << "���ճ̱�" << endl;
    int day=n%2==0?n-1:n;
    for(int i = 1; i <= n; i++)
    {
        for(int j = 0; j <= day; j++)
        {
            std::cout << ans[i][j] << " ";
        }
        std::cout << std::endl;
    }
    std::cout<<"--------------"<<std::endl;
}
void calendar::solve(int start, int n)
{
    int temp;
    if(n == 2)//ֻ��2��,ֱ�Ӱ�������
    {
        ans[start][1] = ans[start + 1][0];
        ans[start + 1][1] = ans[start][0];
    }
    else
    {
        if(n % 2 == 1) //nΪ����
        {
            temp = ans[start + n][0];
            ans[start + n][0] = 0;
            solve(start, n + 1);
            ans[start+n][0] = temp;
        }
        else//nΪż��
        {
            int m = n / 2;
            solve(start, m);
            solve(start + m, m);
            if(m % 2 == 1)//mΪ����,���ŵ�m+1�쵽��n-1�������
            {
                for(int i = start; i < start + m; i++)//�����������ֿյ�2��ѡ�ֱ���
                {
                    for(int j = 1; j <= m; j++)
                    {
                        if(ans[i][j] == 0)
                        {
                            ans[i][j] = ans[i + m][0];
                            ans[i + m][j] = ans[i][0];
                        }
                    }
                }
                for(int i = 1; i <= m; i++)
                {
                    for(int j = m + 1; j < n; j++)
                    {
                        int temp = (i + j - 1) % m + m + 1;
                        ans[start + i - 1][j] = ans[start + temp - 1][0];
                        ans[start + temp - 1][j] = ans[start + i - 1][0];
                    }
                }
            }
            else//mΪż��,���ŵ�m�쵽��n-1�������
            {
                for(int i = 1; i <= m; i++)
                {
                    for(int j = m; j <= n - 1; j++)
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

