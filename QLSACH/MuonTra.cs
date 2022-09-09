using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLTV;
using BUS_QLTV;

namespace QLSACH
{
    public partial class Mượn_Trả : Form
    {
        string Role;
        string Acc;
        BUS_Muon busmuon = new BUS_Muon();
        BUS_TRa bustra = new BUS_TRa();
        BUS_LOAISACH Ls = new BUS_LOAISACH();
        BUS_Sach S = new BUS_Sach();
        BUS_SV sv = new BUS_SV();
        DataTable QLMS;

        public Mượn_Trả()
        {
            InitializeComponent();
        }
        public Mượn_Trả(string role, string acc) : this()
        {
            Role = role;
            Acc = acc;
        }

        public void btnKetThuc_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen(Role);
            this.Hide();
            hs.ShowDialog();
        }

        public void lblTinhTrangTraSach_Click(object sender, EventArgs e)
        {

        }
        DataTable dtQLMuon;
        void Load_Tra()
        {
            DGVTra.DataSource = bustra.Get_LoadTra();
            this.DGVTra.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            this.DGVTra.DefaultCellStyle.ForeColor = Color.Black;
            cbtenSV.DataSource = sv.Get_Load();
            cbtenSV.DisplayMember = "HoTen";
        }
        void Load_QLMuon()
        {
            //dtQLMuon = busmuon._loadQLMuon("Select * from view_Muon");
            dtQLMuon = busmuon.Get_Load();
            DGVMuon.DataSource = dtQLMuon;
            this.DGVMuon.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            this.DGVMuon.DefaultCellStyle.ForeColor = Color.Black;
            cbChonMaSach.DataSource = S.Get_Load();
            cbChonMaSach.DisplayMember = "MaSach";
            //cbChonMaSach.ValueMember = "MaLoaiSach";
            cbMaDG.DataSource = sv.Get_Load();
            cbMaDG.DisplayMember = "HoTen";
            cbMaDG.ValueMember = "MaDocGia";

        }
        public void Mượn_Trả_Load(object sender, EventArgs e)
        {
            Load_QLMuon();
            Load_Tra();
            loading();
            //this.reportViewer1.RefreshReport();
        }
        void loading()
        {
            dtQLMuon = busmuon.Get_Load();
            DGVMuon.DataSource = dtQLMuon;
            if (DGVMuon.RowCount > 0)
            {
                cbMaDG.Text = DGVMuon.Rows[0].Cells[1].Value.ToString();
                txtMaSach.Text = DGVMuon.Rows[0].Cells[2].Value.ToString();
                txtSoLuong.Text = DGVMuon.Rows[0].Cells[3].Value.ToString();
                dtNgayMuon.Value = Convert.ToDateTime(DGVMuon.Rows[0].Cells[4].Value.ToString());
                dtNgayHenTra.Value = Convert.ToDateTime(DGVMuon.Rows[0].Cells[5].Value.ToString());
            }
        }

        public void btnMuonMoi_Click(object sender, EventArgs e)
        {
            try
            {
                Random r = new Random();
                string mamuon = (r.Next(1000000, 9999999).ToString());
                DataTable msach = S.Get_ma(txtMaSach.Text);
                DataTable tb = busmuon.Get_MaNV(Acc);
                string manv = tb.Rows[0][0].ToString();

                DTO_Muon m = new DTO_Muon(mamuon, cbMaDG.SelectedValue.ToString(), msach.Rows[0][0].ToString(), txtSoLuong.Text, dtNgayMuon.Value.ToString("yyyyMMdd"), dtNgayHenTra.Value.ToString("yyyyMMdd"), manv);
                busmuon.Get_add(m);
                Load_QLMuon();
                MessageBox.Show("Dữ Liệu đã Được Thêm!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Lỗi Dữ Liệu!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Load_QLMuon();
            txtMaSach.Text = "";
            txtSoLuong.Text = "";
            lblMaLoai.Text = "";
            lblMaSach.Text = "";
            lblSoLuong.Text = "";
            lblMaTG.Text = "";
            MessageBox.Show("Làm mới thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Load_Tra();
        }

        public void btnThoat_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen(Role);
            this.Hide();
            hs.ShowDialog();
        }
        int xd;
        public void button3_Click(object sender, EventArgs e)
        {
            string ten = cbMaDG.Text;

            foreach (DataGridViewRow item in this.DGVMuon.SelectedRows)
            {
                xd = item.Index;
            }

            string mamuon = DGVMuon.Rows[xd].Cells[0].Value.ToString();

            try
            {
                //DataTable tb = bustra.Get_code(ten);
                Random r = new Random();
                DataTable msach = S.Get_ma(txtMaSach.Text);

                DataTable tbrole = busmuon.Get_MaNV(Acc);
                DataTable nowdate = bustra.Get_date();
                DataTable sl = S.Get_sltang(txtSoLuong.Text, msach.Rows[0][0].ToString());
                S.Get_sl2(sl.Rows[0][0].ToString(), msach.Rows[0][0].ToString());
                // string mamuon = tb.Rows[0][0].ToString();

                string matra = (r.Next(1000, 9999).ToString());

                string manv = tbrole.Rows[0][0].ToString();

                string Nowdate = DateTime.Now.ToString("yyyyMMdd");//nowdate.Rows[0][0].ToString();


                DTO_Tra tr = new DTO_Tra(matra, Nowdate, manv, mamuon);

                bustra.Get_addtra(tr);
                Load_Tra();
                MessageBox.Show("Dữ Liệu đã Được Thêm!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Lỗi Dữ Liệu!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void btnLuu_Click(object sender, EventArgs e)
        {
            Form_DSNo frm = new Form_DSNo();
            frm.ShowDialog();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            DGVMuon.DataSource = busmuon.Get_Tim(cbMaDG.Text);
            if (DGVMuon.RowCount > 1)
            {
                MessageBox.Show("Đã tìm thấy!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể tìm thấy!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void btnTraSach_Click(object sender, EventArgs e)
        {
            string ten = cbtenSV.Text;
            DGVTra.DataSource = bustra.Get_Tim(ten);
        }
        

        public void DGVMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                cbMaDG.Text = DGVMuon.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMaSach.Text = DGVMuon.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSoLuong.Text = DGVMuon.Rows[e.RowIndex].Cells[3].Value.ToString();
                dtNgayMuon.Value = Convert.ToDateTime(DGVMuon.Rows[e.RowIndex].Cells[4].Value.ToString());
                dtNgayHenTra.Value = Convert.ToDateTime(DGVMuon.Rows[e.RowIndex].Cells[5].Value.ToString());
            }
        }

        public void cbChonMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string values = cbChonMaSach.Text;
            try
            {
                if (!string.IsNullOrEmpty(values))
                {
                    DataTable dt = S.Get_finds(values);
                    lblMaSach.Text = dt.Rows[0][1].ToString();
                    lblMaLoai.Text = dt.Rows[0][2].ToString();
                    lblSoLuong.Text = dt.Rows[0][3].ToString();
                    lblMaTG.Text = dt.Rows[0][4].ToString(); ;
                }
            }
            catch
            {

                lblMaLoai.Text = "";
                lblMaSach.Text = "";
                lblSoLuong.Text = "";
                lblMaTG.Text = "";
            }
        }

        public void DGVTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                cbtenSV.Text = DGVTra.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMaSach_TraSach.Text = DGVTra.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSoLuong_TraSach.Text = DGVTra.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtNgayMuon_TraSach.Value = Convert.ToDateTime(DGVTra.Rows[e.RowIndex].Cells[3].Value.ToString());
                dtNgayHenTra_TraSach.Value = Convert.ToDateTime(DGVTra.Rows[e.RowIndex].Cells[4].Value.ToString());
                dtNgayTra.Value = Convert.ToDateTime(DGVTra.Rows[e.RowIndex].Cells[5].Value.ToString());
            }
        }
    }
}
