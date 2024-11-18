using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Sunny.UI;

namespace QuanLyBaiBaoKHCN.BienTapVien
{
    public partial class ThongKe : Form
    {
        QLTapChi_KHCNDataContext qltc = new QLTapChi_KHCNDataContext();

        public ThongKe()
        {
            InitializeComponent();
            Load_BarChart(DateTime.Now.Year, DateTime.Now.Month);
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {

        }

        void Load_BarChart(int selectedYear, int selectedMonth)
        {
            // Lấy dữ liệu bài viết trong năm đã chọn, nhóm theo tháng và trạng thái
            var baiVietThang = from bv in qltc.BaiViets
                               where bv.NgayGui.Value.Year == selectedYear && bv.NgayGui.Value.Month == selectedMonth
                               group bv by new { bv.NgayGui.Value.Month, bv.TrangThai } into g
                               select new
                               {
                                   Thang = g.Key.Month,        
                                   TrangThai = g.Key.TrangThai, 
                                   SoLuong = g.Count()          
                               };


            // Chuẩn bị dữ liệu cho biểu đồ
            UIBarOption option = new UIBarOption();
            option.Title = new UITitle();
            option.Title.Text = "Thống kê bài viết tháng " + selectedMonth + " năm " + selectedYear;
            option.Title.SubText = "";

            // Thiết lập Legend
            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Horizontal;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;
            option.Legend.AddData("Đã Đăng");
            option.Legend.AddData("Đã Gửi");

            var seriesDaDang = new UIBarSeries();
            seriesDaDang.Name = "Đã Đăng";

            var seriesDaGui = new UIBarSeries();
            seriesDaGui.Name = "Đã Gửi";

            // Thêm dữ liệu vào các series
            for (int i = 1; i <= 12; i++)
            {
                // Lấy số lượng bài viết đã đăng cho tháng i
                var baiVietDaDangThang = baiVietThang.FirstOrDefault(bv => bv.Thang == i && bv.TrangThai == "Đăng Bài");
                int soLuongDaDang = baiVietDaDangThang != null ? baiVietDaDangThang.SoLuong : 0;

                // Lấy số lượng bài viết đã gửi cho tháng i
                var baiVietDaGuiThang = baiVietThang.FirstOrDefault(bv => bv.Thang == i && bv.TrangThai != "Đăng Bài");
                int soLuongDaGui = baiVietDaGuiThang != null ? baiVietDaGuiThang.SoLuong : 0;

                // Thêm dữ liệu vào các series
                seriesDaDang.AddData(soLuongDaDang);
                seriesDaGui.AddData(soLuongDaGui);
            }

            option.Series.Add(seriesDaDang);
            option.Series.Add(seriesDaGui);

            // Thêm nhãn cho trục X (12 tháng)
            string[] thangLabels = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            foreach (var label in thangLabels)
            {
                option.XAxis.Data.Add(label);
            }

            // Thiết lập ToolTip và hiển thị biểu đồ
            option.ToolTip.Visible = true;
            option.YAxis.Scale = true;
            option.XAxis.Name = "Tháng";
            option.XAxis.AxisLabel.Angle = 0;

            option.YAxis.Name = "Số lượng";

            option.ToolTip.AxisPointer.Type = UIAxisPointerType.Shadow;
            option.ShowValue = true;

            BarChart_BaiViet.SetOption(option);
        }

        private void DatePicker_MY_BaiViet_ValueChanged(object sender, DateTime value)
        {
            int selectedYear = value.Year;
            int selectedMonth = value.Month;

            Load_BarChart(selectedYear, selectedMonth);

        }
    }
}
