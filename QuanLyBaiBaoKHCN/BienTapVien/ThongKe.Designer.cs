
namespace QuanLyBaiBaoKHCN.BienTapVien
{
    partial class ThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BarChart_BaiViet = new Sunny.UI.UIBarChart();
            this.DatePicker_MY_BaiViet = new Sunny.UI.UIDatePicker();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uiTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage1);
            this.uiTabControl1.Controls.Add(this.tabPage2);
            this.uiTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl1.Location = new System.Drawing.Point(0, 0);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(1291, 791);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.TabIndex = 0;
            this.uiTabControl1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BarChart_BaiViet);
            this.tabPage1.Controls.Add(this.DatePicker_MY_BaiViet);
            this.tabPage1.Controls.Add(this.uiLabel1);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1291, 751);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bài viết";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BarChart_BaiViet
            // 
            this.BarChart_BaiViet.ChartStyleType = Sunny.UI.UIChartStyleType.Default;
            this.BarChart_BaiViet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarChart_BaiViet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarChart_BaiViet.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.BarChart_BaiViet.Location = new System.Drawing.Point(0, 10);
            this.BarChart_BaiViet.MinimumSize = new System.Drawing.Size(1, 1);
            this.BarChart_BaiViet.Name = "BarChart_BaiViet";
            this.BarChart_BaiViet.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BarChart_BaiViet.Size = new System.Drawing.Size(1291, 741);
            this.BarChart_BaiViet.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.BarChart_BaiViet.TabIndex = 2;
            this.BarChart_BaiViet.Text = "uiBarChart1";
            // 
            // DatePicker_MY_BaiViet
            // 
            this.DatePicker_MY_BaiViet.DateYearMonthFormat = "MM-yyyy";
            this.DatePicker_MY_BaiViet.FillColor = System.Drawing.Color.White;
            this.DatePicker_MY_BaiViet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DatePicker_MY_BaiViet.Location = new System.Drawing.Point(188, 10);
            this.DatePicker_MY_BaiViet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DatePicker_MY_BaiViet.MaxLength = 7;
            this.DatePicker_MY_BaiViet.MinimumSize = new System.Drawing.Size(63, 0);
            this.DatePicker_MY_BaiViet.Name = "DatePicker_MY_BaiViet";
            this.DatePicker_MY_BaiViet.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.DatePicker_MY_BaiViet.ShowType = Sunny.UI.UIDateType.YearMonth;
            this.DatePicker_MY_BaiViet.Size = new System.Drawing.Size(150, 29);
            this.DatePicker_MY_BaiViet.SymbolDropDown = 61555;
            this.DatePicker_MY_BaiViet.SymbolNormal = 61555;
            this.DatePicker_MY_BaiViet.SymbolSize = 24;
            this.DatePicker_MY_BaiViet.TabIndex = 1;
            this.DatePicker_MY_BaiViet.Text = "11-2024";
            this.DatePicker_MY_BaiViet.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.DatePicker_MY_BaiViet.Value = new System.DateTime(2024, 11, 1, 0, 0, 0, 0);
            this.DatePicker_MY_BaiViet.Watermark = "";
            this.DatePicker_MY_BaiViet.ValueChanged += new Sunny.UI.UIDatePicker.OnDateTimeChanged(this.DatePicker_MY_BaiViet_ValueChanged);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(12, 10);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(181, 29);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Chọn mốc thời gian";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 60);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ThongKe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1291, 791);
            this.Controls.Add(this.uiTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Sunny.UI.UIBarChart BarChart_BaiViet;
        private Sunny.UI.UIDatePicker DatePicker_MY_BaiViet;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}