using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inutil
{
    public partial class Menu : MetroFramework.Forms.MetroForm
    {
       
        public Menu()
        {
            InitializeComponent();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Esta seguro de cerrar la aplicacion", "Cerrar Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
               
            }
        }
        
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Vehiculo objVehiculo = new Vehiculo();
            this.Hide();
            objVehiculo.Show();
        }
        
        private void metroButton2_Click(object sender, EventArgs e)
        {
            Devolucion objDevolucion = new Devolucion();    
            this.Hide();
            objDevolucion.Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            frmPrint objfrmPrint = new frmPrint();
            this.Hide();
            objfrmPrint.Show(); 
        }

        
    }
}
