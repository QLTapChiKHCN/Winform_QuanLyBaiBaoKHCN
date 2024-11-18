using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaiBaoKHCN.TongBienTap
{
    public partial class DuyetPhanBien : Form
    {
        QLTapChi_KHCNDataContext qltc = new QLTapChi_KHCNDataContext();
        public DuyetPhanBien()
        {
            InitializeComponent();
            load_combobox_BanDau();
        }

        #region Load các thể loại combobox
        void load_combobox_BanDau()
        {
            cbo_NgonNgu();
            cbo_ChuyenMuc();
            cbo_HocHam();
            cbo_HocVi();
            cbo_ChuyenNganh();
            cbo_DonVi();
            cbo_QuocGia();
            cbo_TrangThaiBaiViet();
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

        void cbo_HocHam()
        {
            var HocHam = from hh in qltc.HocHams select hh;
            cboHocHam.DataSource = HocHam;
            cboHocHam.DisplayMember = "TenHocHam";
            cboHocHam.ValueMember = "MaHocHam";
        }

        void cbo_HocVi()
        {
            var HocVi = from hv in qltc.HocVis select hv;
            cboHocVi.DataSource = HocVi;
            cboHocVi.DisplayMember = "TenHocVi";
            cboHocVi.ValueMember = "MaHocVi";
        }

        void cbo_ChuyenNganh()
        {
            var ChuyenNganh = from cn in qltc.ChuyenNganhs select cn;
            cboChuyenNganh.DataSource = ChuyenNganh;
            cboChuyenNganh.DisplayMember = "TenChuyenNganh";
            cboChuyenNganh.ValueMember = "MaChuyenNganh";
        }

        void cbo_DonVi()
        {
            var DonVi = from dv in qltc.DonVis select dv;
            cboDonVi.DataSource = DonVi;
            cboDonVi.DisplayMember = "TenDonVi";
            cboDonVi.ValueMember = "MaDonVi";
        }

        void cbo_QuocGia()
        {
            var QuocGia = from qg in qltc.QuocGias select qg;
            cboQuocGia.DataSource = QuocGia;
            cboQuocGia.DisplayMember = "TenQG";
            cboQuocGia.ValueMember = "MaQG";
        }
        class TrangThaiItem
        {
            public string MaTrangThai { get; set; }
            public string TenTrangThai { get; set; }
        }
        void cbo_TrangThaiBaiViet()
        {
            var TrangThai = new List<TrangThaiItem>
                                {
                                    new TrangThaiItem { MaTrangThai = "1", TenTrangThai = "Chờ Xét Duyệt" },
                                    new TrangThaiItem { MaTrangThai = "2", TenTrangThai = "Đang Xét Duyệt" },
                                    new TrangThaiItem { MaTrangThai = "3", TenTrangThai = "Đã Duyệt" },
                                    new TrangThaiItem { MaTrangThai = "4", TenTrangThai = "Chỉnh Sửa" },
                                    new TrangThaiItem { MaTrangThai = "5", TenTrangThai = "Chờ Phản Biện" },
                                    new TrangThaiItem { MaTrangThai = "6", TenTrangThai = "Đang Phản Biện" },
                                    new TrangThaiItem { MaTrangThai = "7", TenTrangThai = "Từ Chối" },
                                    new TrangThaiItem { MaTrangThai = "8", TenTrangThai = "Đăng Bài" }
                                };

            cboTrangThaiBaiBao.DataSource = TrangThai;
            cboTrangThaiBaiBao.DisplayMember = "TenTrangThai";
            cboTrangThaiBaiBao.ValueMember = "MaTrangThai";
        }



        #endregion

    }
}
