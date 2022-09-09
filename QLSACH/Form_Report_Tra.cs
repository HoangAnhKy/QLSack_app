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
    public partial class Form_Report_Tra : Form
    {
        public Form_Report_Tra()
        {
            InitializeComponent();
        }

        private void Form_Report_Tra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet_Tra.view_Tra_Report' table. You can move, or remove it, as needed.
            this.view_Tra_ReportTableAdapter.Fill(this.DataSet_Tra.view_Tra_Report);

            this.reportViewer1.RefreshReport();
        }
    }
}
