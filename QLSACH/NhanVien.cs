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
    public partial class Tác_Giả : Form
    {
        string Role;
        CurrencyManager cm;
        DataTable QLNV = new DataTable();
        BUS_Nhanvien Nv = new BUS_Nhanvien();
        public Tác_Giả()
        {
            InitializeComponent();
        }
        public Tác_Giả(string role):this()
        {
            Role = role;
        }
        
        void updateTable()
        {
            QLNV = Nv.Get_Load();
          
            cm = (CurrencyManager)this.BindingContext[QLNV];
        }
        void BD()
        {
            updateTable();
            txtMaNV.DataBindings.Add("Text", QLNV, "MaNhanVien");
            tbSDT.DataBindings.Add("Text", QLNV, "SDT");
            txtDiaChi.DataBindings.Add("Text", QLNV, "DiaChi");
            txtTenNV.DataBindings.Add("Text", QLNV, "HoTen");
            tbDate.DataBindings.Add("Text", QLNV, "Ngaysinh");
            if (Convert.ToByte(QLNV.Rows[cm.Position][2]) == 0)
            {
                radNam.PerformClick();
            }
            else
            {
                radNu.PerformClick();
            }
            DGWDanshsachNV.DataSource = QLNV;
        }
        void UBD()
        {
            cm.EndCurrentEdit();
            cm = (CurrencyManager)this.BindingContext[QLNV];
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", QLNV, "MaNhanVien");
            tbSDT.DataBindings.Clear();
            tbSDT.DataBindings.Add("Text", QLNV, "SDT");
            txtDiaChi.DataBindings.Clear(); 
            txtDiaChi.DataBindings.Add("Text", QLNV, "DiaChi");
            txtTenNV.DataBindings.Clear(); 
            txtTenNV.DataBindings.Add("Text", QLNV, "HoTen");
            tbDate.DataBindings.Clear();
            tbDate.DataBindings.Add("Text", QLNV, "Ngaysinh");
            if (Convert.ToByte(QLNV.Rows[cm.Position][2]) == 0)
            {
                radNam.PerformClick();
            }
            else
            {
                radNu.PerformClick();
            }
            DGWDanshsachNV.DataSource = QLNV;
        }

        void load()
        {
            DGWDanshsachNV.DataSource = Nv.Get_Load();
            this.DGWDanshsachNV.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            this.DGWDanshsachNV.DefaultCellStyle.ForeColor = Color.Black;
            updateTable();
            UBD();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen(Role);
            this.Hide();
            hs.ShowDialog();
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
            DTO_Log log = new DTO_Log(tbName.Text, tbPass.Text);
            DTO_Thongtin tt = new DTO_Thongtin(txtMaNV.Text, tbSDT.Text, check, txtDiaChi.Text, txtTenNV.Text, tbDate.Text);
            
            Nv.Get_add(log);
            
            string tkdn = tbName.Text;
            
            Nv.Get_AddNV(tt, tkdn);
            load();
        }

        private void Tác_Giả_Load(object sender, EventArgs e)
        {
            BD();
            load();
        }

        private void DGWDanshsachNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex != -1)
            {
         
                if (DGWDanshsachNV.Rows[e.RowIndex].Cells[2].Value.ToString() == "True")
                {
                     radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
                
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string check = "";
            if (radNam.Checked == true)
            {
                check = "True";
            }
            else if (radNu.Checked == true)
            {
                check = "False";
            }
            DTO_Thongtin tt = new DTO_Thongtin(txtMaNV.Text, tbSDT.Text, check, txtDiaChi.Text, txtTenNV.Text, tbDate.Text); string tkdn = tbName.Text;
            Nv.Get_UPNV(tt, tkdn);
            load();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã lưu file thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string masv = txtMaNV.Text;
                string acc = tbName.Text;
                Nv.Get_DELNV(masv);
                Nv.Get_DELTK(acc);
                load();
            }
        }
    }
}
