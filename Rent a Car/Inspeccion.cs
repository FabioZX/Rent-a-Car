using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inutil
{
    public partial class Inspeccion : MetroFramework.Forms.MetroForm
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        public ClienteEmpleado ClienteEmpleado;

        public Inspeccion()
        {
            InitializeComponent();
           
        }
        public Inspeccion( ClienteEmpleado ClienteEmpleado)
        {
            InitializeComponent();
            this.ClienteEmpleado = ClienteEmpleado;
        }

        private void Inspeccion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zXDataSet.Vehiculos' table. You can move, or remove it, as needed.
            this.vehiculosTableAdapter.Fill(this.zXDataSet.Vehiculos);
            ralladurasMetroCheckBox.Checked = false;
            cCombustible1MetroRadioButton.Checked = false;
            cCombustible2MetroRadioButton.Checked = false;
            cCombustible3MetroRadioButton.Checked = false;
            cCombustible4MetroRadioButton.Checked = false;
            gomasMetroCheckBox.Checked = false;
            gatoMetroCheckBox.Checked = false;
            roturasMetroCheckBox.Checked = false;
            eGomas1MetroCheckBox.Checked = false;
            eGomas2MetroCheckBox.Checked = false;
            eGomas3MetroCheckBox.Checked = false;
            eGomas4MetroCheckBox.Checked = false;
            idtransaccionTextBox.Text = "";
            fechaInspeccionDateTimePicker.Text = "";

        }

        private void eGomas3MetroCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ClienteEmpleado objClienteEmpleado = new ClienteEmpleado();
            this.Hide();
            objClienteEmpleado.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ralladurasMetroCheckBox.Checked == false) 
            {
                MessageBox.Show("Llene los campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (gomasMetroCheckBox.Checked == false)
            {
                MessageBox.Show("Llene los campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (gatoMetroCheckBox.Checked == false)
            {
                MessageBox.Show("Llene los campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (roturasMetroCheckBox.Checked == false)
            {
                MessageBox.Show("Llene los campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (eGomas1MetroCheckBox.Checked == false)
            {
                MessageBox.Show("Llene los campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (eGomas2MetroCheckBox.Checked == false)
            {
                MessageBox.Show("Llene los campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (eGomas3MetroCheckBox.Checked == false)
            {
                MessageBox.Show("Llene los campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (eGomas4MetroCheckBox.Checked == false)
            {
                MessageBox.Show("Llene los campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (ralladurasMetroCheckBox.Checked == true && gomasMetroCheckBox.Checked == true && gatoMetroCheckBox.Checked == true && roturasMetroCheckBox.Checked == true)
            {
                Inspeccion inspeccion = new Inspeccion();
                inspeccion = this;
                Renta objRenta = new Renta(inspeccion);
                this.Hide();
                objRenta.Show();
            }
            
        }

        private void ralladurasMetroCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ralladurasMetroCheckBox.Checked == true)
            {
                char[] letras = "ASDFGHJKLMNBVCXZQWERTYUIOP1234567890Ñ".ToCharArray();
                Random r = new Random();
                string randomString = "";
                for (int i = 0; i < 4; i++)
                {
                    randomString += letras[r.Next(0, 35)].ToString();
                    idtransaccionTextBox.Text = randomString;
                }
            }
        }
    }
}
