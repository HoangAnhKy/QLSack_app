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
    public partial class DangNhap : Form
    {
        BUS_Log lg = new BUS_Log();
        public DangNhap()
        {
            InitializeComponent();
        }
        public bool check()
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Mời bạn nhập Tài khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbpass.Text))
            {
                MessageBox.Show("Mời bạn nhập Mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbpass.Focus();
                return false;
            }
            return true;
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen();
            this.Hide();
            hs.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check())
            {
                DTO_Log log = new DTO_Log(tbName.Text, tbpass.Text);
                DataTable tb = lg.Get_role(log);
                string role;
                string acc;
                try
                {
                    role = tb.Rows[0][0].ToString();
                    acc = tbName.Text;
                    if (role == "master" || role == "staff" || role == "client")
                    {
                        MessageBox.Show("Login Succesfully!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HomeScreen hs = new HomeScreen(role,acc);
                        this.Hide();
                        hs.ShowDialog();
                    }
                    else 
                    {
                        MessageBox.Show("Login Failed!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Chưa có tài khoản!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
