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
    public partial class HomeScreen : Form
    {
        string role;
        string acc;
        BUS_Sach S = new BUS_Sach();
        public HomeScreen()
        {
            InitializeComponent();
        }
        public HomeScreen (string Role): this()
        {
            role = Role;     
        }
        public HomeScreen(string Role,string Acc) : this()
        {
            role = Role;
            acc = Acc;
        }
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuanLyDocGia_Click(object sender, EventArgs e)
        {
            if( role == "staff")
            {
                Đọc_giả Dg = new Đọc_giả(role);
                this.Hide();
                Dg.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đây là công việc của nhân viên!!! Bạn hãy đăng nhập bằng tài khoản nhân viên để tiếp tục.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DangNhap dn = new DangNhap();
                this.Hide();
                dn.ShowDialog();
            }
            
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (role == "staff")
            {
                Cập_Nhật cn = new Cập_Nhật(role);
                this.Hide();
                cn.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đây là công việc của nhân viên!!! Bạn hãy đăng nhập bằng tài khoản nhân viên để tiếp tục.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DangNhap dn = new DangNhap();
                dn.ShowDialog();
            }

        }

        private void btnQuanLyTacGia_Click(object sender, EventArgs e)
        {
            if (role == "master")
            {
                Tác_Giả tg = new Tác_Giả(role);
                this.Hide();
                tg.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đây là công việc của ADMIN!!! Bạn hãy đăng nhập bằng tài khoản ADMIN ( kỳ hoặc dương ) để tiếp tục.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DangNhap dn = new DangNhap();
                this.Hide();
                dn.ShowDialog();
            }

        }
        private void HomeScreen_Load(object sender, EventArgs e)
        {
            load();
        }
        BindingManagerBase BMB;
        DataTable DTQLS;
        void load()
        {
            DTQLS = S.Get_Load();
            DGVLOAD.DataSource = DTQLS;
            this.DGVLOAD.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            this.DGVLOAD.DefaultCellStyle.ForeColor = Color.Black;
            TxtMa.DataBindings.Add("Text", DTQLS, "MaSach");
            TxtTen.DataBindings.Add("Text", DTQLS, "TenSach");
            TxtMLoai.DataBindings.Add("Text", DTQLS, "TheLoai");
            TxtSL.DataBindings.Add("Text", DTQLS, "SoLuong");
            Txtmatg.DataBindings.Add("Text", DTQLS, "TenTacgia");
            BMB = this.BindingContext[DTQLS];
            RownNum();
        }
        void RownNum()
        {
            int _row = BMB.Position + 1;
            counter.Text = _row.ToString() + "/" + BMB.Count.ToString();
        }
        private void btnQuanLyMuonTra_Click(object sender, EventArgs e)
        {
            if (role == "staff")
            {
                Mượn_Trả mt = new Mượn_Trả(role, acc);
                this.Hide();
                mt.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đây là công việc của nhân viên!!! Bạn hãy đăng nhập bằng tài khoản nhân viên để tiếp tục.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DangNhap dn = new DangNhap();
                this.Hide();
                dn.ShowDialog();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            DGVLOAD.DataSource = S.Get_Load();
        }
        bool Check()
        {
            if (string.IsNullOrWhiteSpace(txtTimSach.Text))
            {
                MessageBox.Show("Mời bạn nhập Thông Tin!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTimSach.Focus();
                return false;
            }
            return true;
        }
        private void txtTimSach_TextChanged(object sender, EventArgs e)
        {
            string values = txtTimSach.Text;
            if (!string.IsNullOrEmpty(values))
            {
                DataTable dt = S.Get_find(values);
                DGVLOAD.DataSource = dt;
            }
            else
            {
                DGVLOAD.DataSource = S.Get_Load();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (Check()) 
            {
                string keywork = txtTimSach.Text;
                if (radTenTG.Checked == true)
                {
                    DGVLOAD.DataSource = S.Get_SearchTG(keywork);
                }
                else if (radTensach.Checked == true)
                {

                    DGVLOAD.DataSource = S.Get_SearchSach(keywork);
                }
                else
                {
                    MessageBox.Show("Vui Lòng chọn tìm theo Tên Sách Hay Tên Tác Giả!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                this.DGVLOAD.DefaultCellStyle.Font = new Font("Times New Roman", 14);
                this.DGVLOAD.DefaultCellStyle.ForeColor = Color.Black; 
            }
        }

        private void giúpĐỡToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liên hệ San để Được Giúp Đỡ ", "ziswec ( San Cà Lê )", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Hide();
            dn.ShowDialog();
        }

        

        private void quảnLýHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngKíToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (BMB.Position + 1 >= BMB.Count)
            {
                MessageBox.Show("Đã đạt đến giới hạn!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                BMB.Position += 1;
                RownNum();
            }
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if(BMB.Position-1 < 0)
            {
                MessageBox.Show("Đã đạt đến giới hạn!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                BMB.Position -= 1;
                RownNum();
            }     
        }

        private void danhMụcSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (role == "master")
            {
                Form_KhoSach frm = new Form_KhoSach();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đây là công việc của ADMIN!!! Bạn hãy đăng nhập bằng tài khoản ADMIN ( kỳ hoặc dương ) để tiếp tục.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DangNhap dn = new DangNhap();
                this.Hide();
                dn.ShowDialog();
            }
            
        }

        private void danhĐộcGiảTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (role == "master")
            {
                Form_Report_Tra frm = new Form_Report_Tra();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đây là công việc của ADMIN!!! Bạn hãy đăng nhập bằng tài khoản ADMIN ( kỳ hoặc dương ) để tiếp tục.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DangNhap dn = new DangNhap();
                this.Hide();
                dn.ShowDialog();
            }
            
        }

        private void danhSáchĐộcGiảMượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (role == "master")
            {
                Form_ReportMuon frm = new Form_ReportMuon();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đây là công việc của ADMIN!!! Bạn hãy đăng nhập bằng tài khoản ADMIN ( kỳ hoặc dương ) để tiếp tục.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DangNhap dn = new DangNhap();
                this.Hide();
                dn.ShowDialog();
            }
            
        }
    }
}
