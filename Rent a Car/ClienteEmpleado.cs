using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inutil
{
    public partial class ClienteEmpleado : MetroFramework.Forms.MetroForm
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        Validacion v = new Validacion();
        public Vehiculo Vehiculo;
        public ClienteEmpleado()
        {
            InitializeComponent();
            
        }
        public ClienteEmpleado(Vehiculo Vehiculo)
        {
            InitializeComponent();
            this.Vehiculo = Vehiculo;
        }

        private void ClienteEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zXDataSet.Vehiculos' table. You can move, or remove it, as needed.
            this.vehiculosTableAdapter.Fill(this.zXDataSet.Vehiculos);
            clienteNombreTextBox.Text = "";
            correoTextBox.Text = "";
            cedulaClienteMaskedTextBox.Text = "";
            noTarjetaMaskedTextBox.Text = "";
            limiteTextBox.Text = "";
            personaFisicaMetroRadioButton.Checked = false;
            personaJuridicaMetroRadioButton.Checked = false;
            empleadoNombreTextBox.Text = "";
            cedulaEmpleadoMaskedTextBox.Text = "";
            tandaComboBox.Text = "";
            comisionTextBox.Text = "5";
            idclienteTextBox.Text = "";
            idempleadoTextBox.Text = "";
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Vehiculo objVehiculo = new Vehiculo();
            this.Hide();
            objVehiculo.Show();
        }

        private void clienteNombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Letras(e);
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cedulaClienteMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Numeros(e);
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void noTarjetaMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Numeros(e);
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void limiteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Numeros(e);
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void empleadoNombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Letras(e);
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void cedulaEmpleadoMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Numeros(e);
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tandaComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Letras(e);
            e.Handled = true;
            {
                MessageBox.Show("Solo se permiten la seleccion de opciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
                
        {
            if (clienteNombreTextBox.Text == "")
            {
                MessageBox.Show("Llene los campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (correoTextBox.Text == "")
            {
                MessageBox.Show("Llene los campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cedulaClienteMaskedTextBox.Text == "")
            {
                MessageBox.Show("Llene los campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(noTarjetaMaskedTextBox.Text == "")
            {
                MessageBox.Show("Llene los campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(limiteTextBox.Text == "")
            {
                MessageBox.Show("Llene los campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(empleadoNombreTextBox.Text == "")
            {
                MessageBox.Show("Llene los campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cedulaEmpleadoMaskedTextBox.Text == "")
            {
                MessageBox.Show("Llene los campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tandaComboBox.Text == "")
            {
                MessageBox.Show("Llene los campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!validaCedula(cedulaClienteMaskedTextBox.Text))
            { 
                MessageBox.Show("La cedula es incorrecta", "Cedula incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!validaCedula(cedulaEmpleadoMaskedTextBox.Text)) 
            {
                MessageBox.Show("La cedula es incorrecta", "Cedula incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
                if ((validaCedula(cedulaEmpleadoMaskedTextBox.Text)) && (validaCedula(cedulaClienteMaskedTextBox.Text)) && clienteNombreTextBox.Text != "" && correoTextBox.Text != "" && cedulaClienteMaskedTextBox.Text != "" && noTarjetaMaskedTextBox.Text != "" && limiteTextBox.Text != "" && empleadoNombreTextBox.Text != "" && cedulaEmpleadoMaskedTextBox.Text != "" && tandaComboBox.Text != "")
            {
                ClienteEmpleado ClienteEmpleado = new ClienteEmpleado();
                ClienteEmpleado = this;
                Inspeccion objInspeccion = new Inspeccion(ClienteEmpleado);
                this.Hide();
                objInspeccion.Show();
            }
            
        }

        public static bool validaCedula(string pCedula)
        {
            int vnTotal = 0;
            string vcCedula = pCedula.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }

            if (vnTotal % 10 == 0)
                return true;
            else
                return false;
        }

        private void clienteNombreTextBox_Validated(object sender, EventArgs e)
        {
            if (clienteNombreTextBox.Text.Trim() == "")
            {
                Error.SetError(clienteNombreTextBox, "Seleccione opcion");
                clienteNombreTextBox.Focus();
            }
            else
            {
                Error.Clear();
            }
        }

        private void correoTextBox_Validated(object sender, EventArgs e)
        {
            if (correoTextBox.Text.Trim() == "")
            {
                Error.SetError(correoTextBox, "Seleccione opcion");
                correoTextBox.Focus();
            }
            else
            {
                Error.Clear();
            }
        }

        private void cedulaClienteMaskedTextBox_Validated(object sender, EventArgs e)
        {
            if (cedulaClienteMaskedTextBox.Text.Trim() == "")
            {
                Error.SetError(cedulaClienteMaskedTextBox, "Seleccione opcion");
                cedulaClienteMaskedTextBox.Focus();
            }
            else
            {
                Error.Clear();
            }
        }

        private void noTarjetaMaskedTextBox_Validated(object sender, EventArgs e)
        {
            if (noTarjetaMaskedTextBox.Text.Trim() == "")
            {
                Error.SetError(noTarjetaMaskedTextBox, "Seleccione opcion");
                noTarjetaMaskedTextBox.Focus();
            }
            else
            {
                Error.Clear();
            }
        }

        private void limiteTextBox_Validated(object sender, EventArgs e)
        {
            if (limiteTextBox.Text.Trim() == "")
            {
                Error.SetError(limiteTextBox, "Seleccione opcion");
                limiteTextBox.Focus();
            }
            else
            {
                Error.Clear();
            }
        }

        private void empleadoNombreTextBox_Validated(object sender, EventArgs e)
        {
            if (empleadoNombreTextBox.Text.Trim() == "")
            {
                Error.SetError(empleadoNombreTextBox, "Seleccione opcion");
                empleadoNombreTextBox.Focus();
            }
            else
            {
                Error.Clear();
            }
        }

        private void cedulaEmpleadoMaskedTextBox_Validated(object sender, EventArgs e)
        {
            if (cedulaEmpleadoMaskedTextBox.Text.Trim() == "")
            {
                Error.SetError(cedulaEmpleadoMaskedTextBox, "Seleccione opcion");
                cedulaEmpleadoMaskedTextBox.Focus();
            }
            else
            {
                Error.Clear();
            }
        }

        private void tandaComboBox_Validated(object sender, EventArgs e)
        {
            if (tandaComboBox.Text.Trim() == "")
            {
                Error.SetError(tandaComboBox, "Seleccione opcion");
                tandaComboBox.Focus();
            }
            else
            {
                Error.Clear();
            }
        }

        private void comisionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Letras(e);
            v.Numeros(e);
            e.Handled = true;
            {
                MessageBox.Show("En este campo no se permite escribir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tandaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tandaComboBox.Text != "")
            {
                char[] letras = "QWERTYUIOPASDFGHJKLZXCVBNMÑ0123456789".ToCharArray();
                Random r = new Random();
                string randomString = "";
                for (int i = 0; i < 7; i++)
                {
                    randomString += letras[r.Next(0, 35)].ToString();
                    idclienteTextBox.Text = randomString;
                }
            }
            if (tandaComboBox.Text != "")
            {
                char[] letras = "ASDFGHJKLMNBVCXZQWERTYUIOP1234567890Ñ".ToCharArray();
                Random r = new Random();
                string randomString = "";
                for (int i = 0; i < 7; i++)
                {
                    randomString += letras[r.Next(0, 35)].ToString();
                    idempleadoTextBox.Text = randomString;
                }
            }
        }
    }
}
