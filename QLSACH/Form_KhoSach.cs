using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSACH
{
    public partial class Form_KhoSach : Form
    {
        public Form_KhoSach()
        {
            InitializeComponent();
        }

        private void Form_KhoSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1_DanhMucSach.view_Sach' table. You can move, or remove it, as needed.
            this.view_SachTableAdapter.Fill(this.DataSet1_DanhMucSach.view_Sach);

            this.reportViewer1.RefreshReport();
        }
    }
}
