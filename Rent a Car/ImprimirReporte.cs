using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Inutil
{
    public partial class frmPrint : MetroFramework.Forms.MetroForm
    {
       
        public frmPrint ()   
        {
            InitializeComponent();
           
        }

       
        private void ImprimirReporte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ZXDataSet.Vehiculos' table. You can move, or remove it, as needed.
            this.VehiculosTableAdapter.Fill(this.ZXDataSet.Vehiculos);

            Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
               new Microsoft.Reporting.WinForms.ReportParameter("idvehiculo",ToString())
         
            };
                this.reportViewer1.LocalReport.SetParameters(rParams);
                this.reportViewer1.RefreshReport();  
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Esta seguro de volver a la ventana anterior", "Retroceder", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Menu objMenu = new Menu();
                this.Hide();
                objMenu.Show();

            }
        }
    }
}
