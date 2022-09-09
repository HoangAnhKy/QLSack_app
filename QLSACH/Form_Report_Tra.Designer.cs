
namespace QLSACH
{
    partial class Form_Report_Tra
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
            this.DataSet_Tra = new QLSACH.DataSet_Tra();
            this.view_Tra_ReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_Tra_ReportTableAdapter = new QLSACH.DataSet_TraTableAdapters.view_Tra_ReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Tra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Tra_ReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.view_Tra_ReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLSACH.Report_Tra.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1311, 535);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet_Tra
            // 
            this.DataSet_Tra.DataSetName = "DataSet_Tra";
            this.DataSet_Tra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_Tra_ReportBindingSource
            // 
            this.view_Tra_ReportBindingSource.DataMember = "view_Tra_Report";
            this.view_Tra_ReportBindingSource.DataSource = this.DataSet_Tra;
            // 
            // view_Tra_ReportTableAdapter
            // 
            this.view_Tra_ReportTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Report_Tra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 535);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_Report_Tra";
            this.Text = "Form_Report_Tra";
            this.Load += new System.EventHandler(this.Form_Report_Tra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Tra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Tra_ReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource view_Tra_ReportBindingSource;
        private DataSet_Tra DataSet_Tra;
        private DataSet_TraTableAdapters.view_Tra_ReportTableAdapter view_Tra_ReportTableAdapter;
    }
}