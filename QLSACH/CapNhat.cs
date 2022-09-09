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
    public partial class Cập_Nhật : Form
    {
        string Role;
        DataTable QLTG;
        DataTable QLLS;
        DataTable QLS;
        public Cập_Nhật()
        {
            InitializeComponent();
        }
        BUS_LOAISACH Ls = new BUS_LOAISACH();
        BUS_Sach S = new BUS_Sach();
        BUS_TG Tg = new BUS_TG();
        public Cập_Nhật(string role): this()
        {
            Role = role;
        }
        void LoadALL()
        {
            LoadTG();
            LoadLS();
            LoadS(); 
        }
        private void Cập_Nhật_Load(object sender, EventArgs e)
        {
            LoadALL();
            bdTG();
            bdS();
        }

        private void btnThoatLoaiSach_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen(Role);
            this.Hide();
            hs.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen(Role);
            this.Hide();
            hs.ShowDialog();
        }

        private void btThoatTG_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen(Role);
            this.Hide();
            hs.ShowDialog();
        }
        void LoadTG()
        {
            DGVTacGia.DataSource = Tg.Get_Load();
            this.DGVTacGia.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            this.DGVTacGia.DefaultCellStyle.ForeColor = Color.Black;
        }
        void bdTG()
        {
            QLTG = Tg.Get_Load();
            DGVTacGia.DataSource = QLTG;
            this.DGVTacGia.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            this.DGVTacGia.DefaultCellStyle.ForeColor = Color.Black;
            txtMaTG.DataBindings.Add("Text", QLTG, "MaTacGia");
            txtTenTG.DataBindings.Add("Text", QLTG, "TenTacgia");
            txtDiaChiTG.DataBindings.Add("Text", QLTG, "DiaChi");
        }       
        void bdS()
        {
            QLS = S.Get_Load();
            DGVSach.DataSource = QLS;
            this.DGVSach.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            this.DGVSach.DefaultCellStyle.ForeColor = Color.Black;
            txtMaSach.DataBindings.Add("Text", QLS, "MaSach");
            txtTenSach.DataBindings.Add("Text", QLS, "TenSach");
            cbMaLoai.DataBindings.Add("Text", QLS, "TheLoai");
            txtSoLuong.DataBindings.Add("Text", QLS, "SoLuong");
            cbTenTG.DataBindings.Add("Text", QLS, "TenTacgia");

        }
        private void BTthemTG_Click(object sender, EventArgs e)
        {
            DTO_TacGia tg = new DTO_TacGia(txtMaTG.Text, txtTenTG.Text, txtDiaChiTG.Text);
            Tg.Get_add(tg);
            LoadALL();
        }

        private void BtLuuTG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã lưu file thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btCapNhatTG_Click(object sender, EventArgs e)
        {
            DTO_TacGia tg = new DTO_TacGia(txtMaTG.Text, txtTenTG.Text, txtDiaChiTG.Text);
            Tg.Get_UP(tg);
            LoadALL();
        }

        private void btXoaTG_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string matg = txtMaTG.Text;
                Tg.Get_DEL(matg);
                LoadALL();
                MessageBox.Show("Bạn Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void DGVTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtMaTG.Text = DGVTacGia.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDiaChiTG.Text = DGVTacGia.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTenTG.Text = DGVTacGia.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
        void LoadLS()
        {
            DGVLoaiSach.DataSource = Ls.Get_Load();
            this.DGVLoaiSach.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            this.DGVLoaiSach.DefaultCellStyle.ForeColor = Color.Black;   
            if(DGVLoaiSach.Rows.Count != -1)
            {
                txtTenLoaiSach.Text = DGVLoaiSach.Rows[0].Cells[1].Value.ToString();
                txtMaLoaiSach.Text = DGVLoaiSach.Rows[0].Cells[0].Value.ToString();
            }
        }
        private void btnThemLoaiSach_Click(object sender, EventArgs e)
        {
            DTO_LoaiSach ls = new DTO_LoaiSach(txtMaLoaiSach.Text, txtTenLoaiSach.Text);
            Ls.Get_add(ls);
            LoadALL();
        }

        private void btnLuuLoaiSach_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã lưu file thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSuaLoaiSach_Click(object sender, EventArgs e)
        {
            DTO_LoaiSach ls = new DTO_LoaiSach(txtMaLoaiSach.Text, txtTenLoaiSach.Text);
            Ls.Get_UP(ls);
            LoadALL();
        }

        private void btnXoaLoaiSach_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string mals = txtMaLoaiSach.Text;
                Ls.Get_DEL(mals);
                LoadALL();
                MessageBox.Show("Bạn Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        void LoadS()
        {
            DGVSach.DataSource = S.Get_Load();
            this.DGVSach.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            this.DGVSach.DefaultCellStyle.ForeColor = Color.Black;
            cbMaLoai.DataSource = Ls.Get_Load();
            cbMaLoai.DisplayMember = "TheLoai";
            cbMaLoai.ValueMember = "MaLoaiSach";
            cbTenTG.DataSource = Tg.Get_Load();
            cbTenTG.DisplayMember = "TenTacgia";
            cbTenTG.ValueMember = "MaTacGia";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_Sach s = new DTO_Sach(txtMaSach.Text, txtTenSach.Text, cbMaLoai.SelectedValue.ToString(), txtSoLuong.Text, cbTenTG.SelectedValue.ToString());
            S.Get_add(s);
            LoadALL();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DTO_Sach s = new DTO_Sach(txtMaSach.Text, txtTenSach.Text, cbMaLoai.Text, txtSoLuong.Text, cbTenTG.Text);
            S.Get_add(s);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_Sach s = new DTO_Sach(txtMaSach.Text, txtTenSach.Text, cbMaLoai.SelectedValue.ToString(), txtSoLuong.Text, cbTenTG.SelectedValue.ToString());
            S.Get_UP(s);
            LoadALL();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string mas = txtMaSach.Text;
                S.Get_DEL(mas);
                LoadALL();
                MessageBox.Show("Bạn Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void DGVSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtMaSach.Text = DGVSach.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenSach.Text = DGVSach.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbMaLoai.Text = DGVSach.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbTenTG.Text = DGVSach.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSoLuong.Text = DGVSach.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void DGVLoaiSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtTenLoaiSach.Text = DGVLoaiSach.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMaLoaiSach.Text = DGVLoaiSach.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
    }
}
