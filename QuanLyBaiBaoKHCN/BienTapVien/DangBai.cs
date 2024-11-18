using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaiBaoKHCN.BienTapVien
{
    public partial class DangBai : Form
    {
        QLTapChi_KHCNDataContext qltc = new QLTapChi_KHCNDataContext();
        public DangBai()
        {
            InitializeComponent();
            load_combobox_BanDau();
        }

        void load_combobox_BanDau()
        {
            cbo_NgonNgu();
            cbo_ChuyenMuc();
            cbo_MaTapChi();
            cbo_BaiViet();
        }

        void cbo_NgonNgu()
        {
            var NgonNgu = from ngonngu in qltc.NgonNgus select ngonngu;
            cboNgonNgu.DataSource = NgonNgu;
            cboNgonNgu.DisplayMember = "TenNgonNgu";
            cboNgonNgu.ValueMember = "MaNgonNgu";
        }

        void cbo_ChuyenMuc()
        {
            var ChuyenMuc = from cm in qltc.ChuyenMucs select cm;
            cboChuyenMuc.DataSource = ChuyenMuc;
            cboChuyenMuc.DisplayMember = "TenChuyenMuc";
            cboChuyenMuc.ValueMember = "MaChuyenMuc";
        }

        void cbo_MaTapChi()
        {
            var TapChi = from tc in qltc.SoTapChis select tc;
            cboSoTapChi.DataSource = TapChi;
            cboSoTapChi.DisplayMember = "MaSoTC";
            cboSoTapChi.ValueMember = "MaSoTC";
        }

        void cbo_BaiViet()
        {
            var BaiViet = from bb in qltc.BaiViets select bb;
            cboBaiViet.DataSource = BaiViet;
            cboBaiViet.DisplayMember = "MaBaiBao";
            cboBaiViet.ValueMember = "MaBaiBao";
        }
    }
}
