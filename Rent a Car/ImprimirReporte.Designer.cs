namespace Inutil
{
    partial class frmPrint
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
            this.VehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ZXDataSet = new Inutil.ZXDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VehiculosTableAdapter = new Inutil.ZXDataSetTableAdapters.VehiculosTableAdapter();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZXDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // VehiculosBindingSource
            // 
            this.VehiculosBindingSource.DataMember = "Vehiculos";
            this.VehiculosBindingSource.DataSource = this.ZXDataSet;
            // 
            // ZXDataSet
            // 
            this.ZXDataSet.DataSetName = "ZXDataSet";
            this.ZXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VehiculosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inutil.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 86);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(945, 349);
            this.reportViewer1.TabIndex = 0;
            // 
            // VehiculosTableAdapter
            // 
            this.VehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(882, 441);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Inicio";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(976, 474);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "frmPrint";
            this.Text = "Imprimir Reporte";
            this.Load += new System.EventHandler(this.ImprimirReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZXDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VehiculosBindingSource;
        private ZXDataSet ZXDataSet;
        private ZXDataSetTableAdapters.VehiculosTableAdapter VehiculosTableAdapter;
        private MetroFramework.Controls.MetroButton btnBack;
    }
}