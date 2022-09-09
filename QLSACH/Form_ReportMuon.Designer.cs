
namespace QLSACH
{
    partial class Form_ReportMuon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet_Muon = new QLSACH.DataSet_Muon();
            this.view_Muon_reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_Muon_reportTableAdapter = new QLSACH.DataSet_MuonTableAdapters.view_Muon_reportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Muon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Muon_reportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.view_Muon_reportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLSACH.Report_Muon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1389, 492);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet_Muon
            // 
            this.DataSet_Muon.DataSetName = "DataSet_Muon";
            this.DataSet_Muon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_Muon_reportBindingSource
            // 
            this.view_Muon_reportBindingSource.DataMember = "view_Muon_report";
            this.view_Muon_reportBindingSource.DataSource = this.DataSet_Muon;
            // 
            // view_Muon_reportTableAdapter
            // 
            this.view_Muon_reportTableAdapter.ClearBeforeFill = true;
            // 
            // Form_ReportMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 492);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_ReportMuon";
            this.Text = "Form_ReportMuon";
            this.Load += new System.EventHandler(this.Form_ReportMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Muon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Muon_reportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource view_Muon_reportBindingSource;
        private DataSet_Muon DataSet_Muon;
        private DataSet_MuonTableAdapters.view_Muon_reportTableAdapter view_Muon_reportTableAdapter;
    }
}