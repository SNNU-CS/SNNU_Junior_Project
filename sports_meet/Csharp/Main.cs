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
    public partial class Main : CCSkinMain
    {
        private calendar cal;
        public Main()
        {
            InitializeComponent();
            label3.Text = "";
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            int n = ListBoxSelect.Items.Count;
            if (n == 0)
            {
                MessageBoxEx.Show("请至少选择一项!", "错误", MessageBoxButtons.OK);
                return;
            }
            cal = new calendar(n);
            //cal.print_to_crt();
            //生成Dictionary
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            for (int i = 1; i <= n; i++)
            {
                myDictionary.Add(i, ListBoxSelect.Items[i - 1].ToString());
            }
            string[,] ret = cal.return_string();
            DataTable table = new DataTable();
            table.Columns.Add("选手");
            int day = cal.getDay();
            label3.Text = "比赛时长:" + day.ToString()+"天";
            for (int i = 1; i <= day; i++)
            {
                string temp = "第" + i.ToString() + "天";
                table.Columns.Add(temp);
            }
            for (int i = 1; i <= n; i++)
            {
                DataRow row = table.NewRow();
                row[0] = myDictionary[i];
                for (int j = 1; j <= day; j++)
                {
                    int temp = Convert.ToInt32(ret[i, j]);
                    row[j] = temp == 0 ? "无" : myDictionary[temp];
                }
                table.Rows.Add(row);
            }
            DataGridView1.DataSource = table;
        }

        private void CheckedListBoxAllDep_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string text = CheckedListBoxAllDep.Items[e.Index].ToString();
            if (e.NewValue == CheckState.Checked)
            {
                int index = ListBoxSelect.Items.IndexOf(text);
                if (index == -1)
                {
                    ListBoxSelect.Items.Add(text);
                }
            }
            else
            {
                ListBoxSelect.Items.Remove(text);
            }
        }

        private void BtnSelectAll_Click(object sender, EventArgs e)
        {
            int n = CheckedListBoxAllDep.Items.Count;
            int CheckedCount = CheckedListBoxAllDep.CheckedItems.Count;
            if (CheckedCount < n)
            {
                for (int i = 0; i < n; i++)
                {
                    CheckedListBoxAllDep.SetItemCheckState(i, CheckState.Checked);
                }
            }
            else
            {
                // ListBoxSelect.Items.Clear();
                for (int i = 0; i < n; i++)
                {
                    CheckedListBoxAllDep.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        private void BtnSelectRest_Click(object sender, EventArgs e)
        {
            int n = CheckedListBoxAllDep.Items.Count;
            for (int i = 0; i < n; i++)
            {
                if (CheckedListBoxAllDep.GetItemCheckState(i) == CheckState.Checked)
                {
                    CheckedListBoxAllDep.SetItemCheckState(i, CheckState.Unchecked);
                }
                else
                {
                    CheckedListBoxAllDep.SetItemCheckState(i, CheckState.Checked);

                }
            }
        }

    }
}
