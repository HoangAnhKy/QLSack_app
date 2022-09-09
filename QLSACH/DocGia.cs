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
    public partial class Đọc_giả : Form
    {
        string Role;
        BUS_SV Sv = new BUS_SV();
        public Đọc_giả()
        {
            InitializeComponent();
        }
        public Đọc_giả(string role) : this()
        {
            Role = role;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen(Role);
            this.Hide();
            hs.ShowDialog();
        }
        void load()
        {
            DGVDG.DataSource = Sv.Get_Load();
            this.DGVDG.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            this.DGVDG.DefaultCellStyle.ForeColor = Color.Black;
            if(DGVDG.Rows.Count != 0)
            {
                txtMaDG.Text = DGVDG.Rows[0].Cells[0].Value.ToString();
                txtSDTDG.Text = DGVDG.Rows[0].Cells[1].Value.ToString();
                if (DGVDG.Rows[0].Cells[2].Value.ToString() == "True")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
                txtDiaChi.Text = DGVDG.Rows[0].Cells[3].Value.ToString();
                txtTenDG.Text = DGVDG.Rows[0].Cells[4].Value.ToString();
                tbDate.Text = DGVDG.Rows[0].Cells[5].Value.ToString();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string check = "";
            if (radNam.Checked == true)
            {
                check = "true";
            }
            else if (radNu.Checked == true)
            {
                check = "false";

            }
            DTO_Thongtin tt = new DTO_Thongtin(txtMaDG.Text, txtSDTDG.Text, check, txtDiaChi.Text, txtTenDG.Text, tbDate.Text);
            Sv.Get_add(tt);
            load();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã lưu file thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string check = "";
            if (radNam.Checked == true)
            {
                check = "true";
            }
            else if (radNu.Checked == true)
            {
                check = "false";

            }
            DTO_Thongtin tt = new DTO_Thongtin(txtMaDG.Text, txtSDTDG.Text, check, txtDiaChi.Text, txtTenDG.Text, tbDate.Text);
            Sv.Get_up(tt);
            load();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string masv = txtMaDG.Text;
                Sv.Get_del(masv);
                load();
            }
        }

        private void Đọc_giả_Load(object sender, EventArgs e)
        {
            load();

        }

        private void DGVDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtMaDG.Text = DGVDG.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtSDTDG.Text = DGVDG.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (DGVDG.Rows[e.RowIndex].Cells[2].Value.ToString() == "True")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
                txtDiaChi.Text = DGVDG.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTenDG.Text = DGVDG.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbDate.Text = DGVDG.Rows[e.RowIndex].Cells[5].Value.ToString();

            }
        }
    }
}
