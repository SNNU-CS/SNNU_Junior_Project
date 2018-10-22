using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
using System.Text.RegularExpressions;

namespace Csharp
{
    public partial class Form1 : CCSkinMain
    {
        private calendar cal;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            string input = TextBoxNum.Text.ToString();
            if (Judge(input) == false)
            {
                MessageBox.Show("选手");
                return;
            }
            int n = Convert.ToInt32(input);
            cal = new calendar(n);
            cal.print_to_crt();
            string[,] ret = cal.return_string();
            DataTable table = new DataTable();
            table.Columns.Add("选手");
            int day = cal.getDay();
            for (int i = 1; i <=day; i++)
            {
                string temp = "第" + i.ToString() + "天";
                table.Columns.Add(temp);
            }
            for (int i = 1; i <= n; i++)
            {
                DataRow row = table.NewRow();
                row[0] = i.ToString();
                for (int j = 1; j <= day; j++)
                {
                    row[j] = ret[i, j];
                }
                table.Rows.Add(row);
            }
            DataGridView1.DataSource = table;
        }

        private bool Judge(string str)
        {
            return Regex.IsMatch(str, @"^\d*[.]?\d*$");
        }
    }
}
