
namespace QLSACH
{
    partial class Form_KhoSach
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
            this.view_SachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1_DanhMucSach = new QLSACH.DataSet1_DanhMucSach();
            this.view_SachTableAdapter = new QLSACH.DataSet1_DanhMucSachTableAdapters.view_SachTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.view_SachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1_DanhMucSach)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.view_SachBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLSACH.Report_DanhMucSach.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1290, 527);
            this.reportViewer1.TabIndex = 0;
            // 
            // view_SachBindingSource
            // 
            this.view_SachBindingSource.DataMember = "view_Sach";
            this.view_SachBindingSource.DataSource = this.DataSet1_DanhMucSach;
            // 
            // DataSet1_DanhMucSach
            // 
            this.DataSet1_DanhMucSach.DataSetName = "DataSet1_DanhMucSach";
            this.DataSet1_DanhMucSach.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_SachTableAdapter
            // 
            this.view_SachTableAdapter.ClearBeforeFill = true;
            // 
            // Form_KhoSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 527);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_KhoSach";
            this.Text = "Form_KhoSach";
            this.Load += new System.EventHandler(this.Form_KhoSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_SachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1_DanhMucSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource view_SachBindingSource;
        private DataSet1_DanhMucSach DataSet1_DanhMucSach;
        private DataSet1_DanhMucSachTableAdapters.view_SachTableAdapter view_SachTableAdapter;
    }
}