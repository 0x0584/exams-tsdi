namespace App
{
    partial class Imprimer
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
            if (disposing && (components != null)) {
                components.Dispose( );
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
            this.components = new System.ComponentModel.Container( );
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource( );
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer( );
            this.ff2017_v11DataSet = new App.ff2017_v11DataSet( );
            this.UtilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UtilisateurTableAdapter = new App.ff2017_v11DataSetTableAdapters.UtilisateurTableAdapter( );
            ((System.ComponentModel.ISupportInitialize)(this.ff2017_v11DataSet)).BeginInit( );
            ((System.ComponentModel.ISupportInitialize)(this.UtilisateurBindingSource)).BeginInit( );
            this.SuspendLayout( );
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.UtilisateurBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "App.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(292, 266);
            this.reportViewer1.TabIndex = 0;
            // 
            // ff2017_v11DataSet
            // 
            this.ff2017_v11DataSet.DataSetName = "ff2017_v11DataSet";
            this.ff2017_v11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UtilisateurBindingSource
            // 
            this.UtilisateurBindingSource.DataMember = "Utilisateur";
            this.UtilisateurBindingSource.DataSource = this.ff2017_v11DataSet;
            // 
            // UtilisateurTableAdapter
            // 
            this.UtilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // Imprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Imprimer";
            this.Text = "Imprimer";
            this.Load += new System.EventHandler(this.Imprimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ff2017_v11DataSet)).EndInit( );
            ((System.ComponentModel.ISupportInitialize)(this.UtilisateurBindingSource)).EndInit( );
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource UtilisateurBindingSource;
        private ff2017_v11DataSet ff2017_v11DataSet;
        private ff2017_v11DataSetTableAdapters.UtilisateurTableAdapter UtilisateurTableAdapter;
    }
}