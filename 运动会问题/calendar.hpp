// Xie Keyi
// 41612244

// 为方便build，所以使用hpp
//TODO 重构可考虑把int全部换成自定义类型(如size_t)


/*
 * API约定: 二维数组a[i][j]表示第i个选手第j天所遇到的对手
*/

#include<iostream>
class calendar
{
	public:
		calendar( int _n ); // 构造函数，间接实现动态二维数组
		~calendar(); // 析构
		void print_to_crt(); // 输出到显示器
		void print_to_file(); // TODO 输出到文件
	protected:
		void solve(int left_top_x , int left_top_y , int sizex , int sizey );
	private:
		bool solve_finished = false ; //是否被solve过
		int n = 0 ; //数组大小
		int **a;
};


calendar::calendar( int _n )
{
	n = _n;
	a = new int *[n+1];
	for( int i = 0  ; i < n + 1 ; i++)
		a[i] = new int[n+1];
	for( int i = 1 ; i <= n ; i++)
		a[i][1] = i ;
}

calendar::~calendar()
{
	for( int i = 0 ; i < n + 1 ; i++)
		delete[] a[i];
	delete[] a;
}
void calendar::solve( int left_top_x , int left_top_y , int sizex  , int sizey)
{
	int size = sizex * sizey;
	//TODO 只有非2^n会出现的情况。
	if( size < 3 )
		return ;
	// 当有4个元素的时候，左上角的给右下角，左下角的给右上角
	else if( size == 4 )
	{
		a[left_top_x+1][left_top_y+1] = a[left_top_x][left_top_y];
		a[left_top_x][left_top_y+1] = a[left_top_x+1][left_top_y];
		return ;
	}
	else
	{
		//分治
		solve( left_top_x , left_top_y , sizex / 2 , sizey / 2  ); // 先处理左上角
		solve( left_top_x + (sizex / 2 ) , left_top_y , sizex / 2 , sizey / 2  );//处理左下角
		// 左下角的复制到右上角
		for( int i = 0 ; i < sizex / 2 ; i++)
			for( int j = 0 ; j < sizey / 2 ; j++)
				a[left_top_x+i][left_top_y+sizey/2+j] = a[i+left_top_x+sizex/2][j+left_top_y];
		// 左上角的复制到右下角
		for( int i = 0 ; i < sizex / 2 ; i++)
			for( int j = 0 ; j < sizey / 2 ; j++)
				a[left_top_x+sizex/2+i][left_top_y+sizey/2+j] = a[i+left_top_x][j+left_top_y];
		return ;
	}
}
void calendar::print_to_crt()
{
	if( !solve_finished )
	{
		solve( 1 , 1 , n  , n  );
		solve_finished = true;
	}
	for( int i = 1 ; i <= n ; i++)
	{
		for( int j = 1 ; j <= n ; j++)
			std::cout << a[i][j] << ' ';
		std::cout << std::endl ;
	}
}


