namespace Csharp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridView1 = new CCWin.SkinControl.SkinDataGridView();
            this.TextBoxNum = new CCWin.SkinControl.SkinTextBox();
            this.BtnOk = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DataGridView1.ColumnFont = null;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DataGridView1.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataGridView1.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridView1.Location = new System.Drawing.Point(53, 113);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridView1.RowTemplate.Height = 23;
            this.DataGridView1.Size = new System.Drawing.Size(948, 506);
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.TitleBack = null;
            this.DataGridView1.TitleBackColorBegin = System.Drawing.Color.White;
            this.DataGridView1.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // TextBoxNum
            // 
            this.TextBoxNum.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxNum.DownBack = null;
            this.TextBoxNum.Icon = null;
            this.TextBoxNum.IconIsButton = false;
            this.TextBoxNum.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.TextBoxNum.IsPasswordChat = '\0';
            this.TextBoxNum.IsSystemPasswordChar = false;
            this.TextBoxNum.Lines = new string[0];
            this.TextBoxNum.Location = new System.Drawing.Point(54, 59);
            this.TextBoxNum.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxNum.MaxLength = 32767;
            this.TextBoxNum.MinimumSize = new System.Drawing.Size(28, 28);
            this.TextBoxNum.MouseBack = null;
            this.TextBoxNum.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.TextBoxNum.Multiline = true;
            this.TextBoxNum.Name = "TextBoxNum";
            this.TextBoxNum.NormlBack = null;
            this.TextBoxNum.Padding = new System.Windows.Forms.Padding(5);
            this.TextBoxNum.ReadOnly = false;
            this.TextBoxNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxNum.Size = new System.Drawing.Size(226, 33);
            // 
            // 
            // 
            this.TextBoxNum.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxNum.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxNum.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.TextBoxNum.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.TextBoxNum.SkinTxt.Multiline = true;
            this.TextBoxNum.SkinTxt.Name = "BaseText";
            this.TextBoxNum.SkinTxt.Size = new System.Drawing.Size(216, 23);
            this.TextBoxNum.SkinTxt.TabIndex = 0;
            this.TextBoxNum.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextBoxNum.SkinTxt.WaterText = "请输入人数:";
            this.TextBoxNum.TabIndex = 1;
            this.TextBoxNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxNum.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextBoxNum.WaterText = "请输入人数:";
            this.TextBoxNum.WordWrap = true;
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.Transparent;
            this.BtnOk.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BtnOk.DownBack = null;
            this.BtnOk.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOk.Location = new System.Drawing.Point(300, 64);
            this.BtnOk.MouseBack = null;
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.NormlBack = null;
            this.BtnOk.Size = new System.Drawing.Size(73, 28);
            this.BtnOk.TabIndex = 2;
            this.BtnOk.Text = "确认";
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("华文行楷", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(504, 640);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(520, 26);
            this.skinLabel1.TabIndex = 3;
            this.skinLabel1.Text = "小组成员:谢可毅、赵旗、许渊、王文鑫、孙浩";
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 684);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.TextBoxNum);
            this.Controls.Add(this.DataGridView1);
            this.Name = "Form1";
            this.Text = "比赛日程表";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinDataGridView DataGridView1;
        private CCWin.SkinControl.SkinTextBox TextBoxNum;
        private CCWin.SkinControl.SkinButton BtnOk;
        private CCWin.SkinControl.SkinLabel skinLabel1;
    }
}

