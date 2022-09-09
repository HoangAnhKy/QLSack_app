
namespace QLSACH
{
    partial class Form_DSNo
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
            this.view_DSChuaTraSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_DSNo = new QLSACH.DataSet_DSNo();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.view_DSChuaTraSachTableAdapter = new QLSACH.DataSet_DSNoTableAdapters.view_DSChuaTraSachTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.view_DSChuaTraSachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_DSNo)).BeginInit();
            this.SuspendLayout();
            // 
            // view_DSChuaTraSachBindingSource
            // 
            this.view_DSChuaTraSachBindingSource.DataMember = "view_DSChuaTraSach";
            this.view_DSChuaTraSachBindingSource.DataSource = this.DataSet_DSNo;
            // 
            // DataSet_DSNo
            // 
            this.DataSet_DSNo.DataSetName = "DataSet_DSNo";
            this.DataSet_DSNo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.ForeColor = System.Drawing.SystemColors.Control;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.view_DSChuaTraSachBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLSACH.Report_DSNo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1225, 569);
            this.reportViewer1.TabIndex = 0;
            // 
            // view_DSChuaTraSachTableAdapter
            // 
            this.view_DSChuaTraSachTableAdapter.ClearBeforeFill = true;
            // 
            // Form_DSNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 569);
            this.Controls.Add(this.reportViewer1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form_DSNo";
            this.Text = "Form_DSNo";
            this.Load += new System.EventHandler(this.Form_DSNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_DSChuaTraSachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_DSNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource view_DSChuaTraSachBindingSource;
        private DataSet_DSNo DataSet_DSNo;
        private DataSet_DSNoTableAdapters.view_DSChuaTraSachTableAdapter view_DSChuaTraSachTableAdapter;
    }
}