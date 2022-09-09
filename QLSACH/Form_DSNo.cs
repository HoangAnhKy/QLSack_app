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
    public partial class Form_DSNo : Form
    {
        public Form_DSNo()
        {
            InitializeComponent();
        }

        private void Form_DSNo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet_DSNo.view_DSChuaTraSach' table. You can move, or remove it, as needed.
            this.view_DSChuaTraSachTableAdapter.Fill(this.DataSet_DSNo.view_DSChuaTraSach);

            this.reportViewer1.RefreshReport();
        }
    }
}
