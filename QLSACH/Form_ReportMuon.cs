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
    public partial class Form_ReportMuon : Form
    {
        public Form_ReportMuon()
        {
            InitializeComponent();
        }

        private void Form_ReportMuon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet_Muon.view_Muon_report' table. You can move, or remove it, as needed.
            this.view_Muon_reportTableAdapter.Fill(this.DataSet_Muon.view_Muon_report);

            this.reportViewer1.RefreshReport();
        }
    }
}
