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
    public partial class Vehiculo : MetroFramework.Forms.MetroForm
    {
        List<Modelos> listaModelos = new List<Modelos>();
        Validacion v = new Validacion();
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        
        public Vehiculo()
        {
            InitializeComponent();
            
            listaModelos.Add(new Modelos() { nombre = "CIVIC", marca = "HONDA" });
            listaModelos.Add(new Modelos() { nombre = "FIESTA", marca = "FORD" });
            listaModelos.Add(new Modelos() { nombre = "ACCENT", marca = "HYUNDIA" });
            listaModelos.Add(new Modelos() { nombre = "COROLLA", marca = "TOYOTA" });
            listaModelos.Add(new Modelos() { nombre = "FOCUS", marca = "FORD" });
            listaModelos.Add(new Modelos() { nombre = "GOLF", marca = "VOLKSWAGAN" });
            listaModelos.Add(new Modelos() { nombre = "PRIUS", marca = "TOYOTA" });
            listaModelos.Add(new Modelos() { nombre = "CRUZE", marca = "CHEVROLET" });
            listaModelos.Add(new Modelos() { nombre = "LEGACY", marca = "CHEVROLET" });
            listaModelos.Add(new Modelos() { nombre = "AVENGER", marca = "DODGE" });
            listaModelos.Add(new Modelos() { nombre = "ACCORD", marca = "HONDA" });
            listaModelos.Add(new Modelos() { nombre = "TAURUS", marca = "FORD" });
            listaModelos.Add(new Modelos() { nombre = "IMPALA", marca = "CHEVROLET" });
            listaModelos.Add(new Modelos() { nombre = "WAYFARER", marca = "FORD" });
            listaModelos.Add(new Modelos() { nombre = "MKZ", marca = "LINCOLN" });//dd
            listaModelos.Add(new Modelos() { nombre = "GENESIS", marca = "HYUNDAI" });
            listaModelos.Add(new Modelos() { nombre = "TLX", marca = "ACURA" });
            listaModelos.Add(new Modelos() { nombre = "AVALON", marca = "TOYOTA" });
            listaModelos.Add(new Modelos() { nombre = "ESCAPE", marca = "FORD" });
            listaModelos.Add(new Modelos() { nombre = "EQUINOX", marca = "CHEVROLET" });
            listaModelos.Add(new Modelos() { nombre = "PATHFINDER", marca = "PATHFINDER" });
            listaModelos.Add(new Modelos() { nombre = "GLA", marca = "MERCEDEZ BENZ" });
        }

        private void Vehiculo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zXDataSet.Vehiculos' table. You can move, or remove it, as needed.
            this.vehiculosTableAdapter.Fill(this.zXDataSet.Vehiculos);
            tipoVehiculoComboBox.Text = "";
            marcasComboBox.Text = "";
            modelosComboBox.Text = "";
            combustibleComboBox.Text = "";
            noChasisTextBox.Text = "";
            noMotorTextBox.Text = "";
            noPlacaTextBox.Text = "";
            idtipovehiculoTextBox.Text = "";
            idmarcasTextBox.Text = "";
            idmodelosTextBox.Text = "";
            idcombustibleTextBox.Text = "";
            pictureBox1.Image = null;
        }

        private void marcasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (marcasComboBox.SelectedItem.ToString() == "HONDA")
            {
                pictureBox1.Image = imageList1.Images[0];
            }

            if (marcasComboBox.SelectedItem.ToString() == "FORD")
            {
                pictureBox1.Image = imageList1.Images[1];
            }

            if (marcasComboBox.SelectedItem.ToString() == "HYUNDAI")
            {
                pictureBox1.Image = imageList1.Images[2];
            }

            if (marcasComboBox.SelectedItem.ToString() == "TOYOTA")
            {
                pictureBox1.Image = imageList1.Images[3];
            }

            if (marcasComboBox.SelectedItem.ToString() == "VOLKSWAGAN")
            {
                pictureBox1.Image = imageList1.Images[4];
            }

            if (marcasComboBox.SelectedItem.ToString() == "CHEVROLET")
            {
                pictureBox1.Image = imageList1.Images[5];
            }

            if (marcasComboBox.SelectedItem.ToString() == "SUBARU")
            {
                pictureBox1.Image = imageList1.Images[6];
            }

            if (marcasComboBox.SelectedItem.ToString() == "DODGE")
            {
                pictureBox1.Image = imageList1.Images[7];
            }

            if (marcasComboBox.SelectedItem.ToString() == "CHRYSLER")
            {
                pictureBox1.Image = imageList1.Images[8];
            }

            if (marcasComboBox.SelectedItem.ToString() == "LINCOLN")
            {
                pictureBox1.Image = imageList1.Images[9];
            }

            if (marcasComboBox.SelectedItem.ToString() == "ACURA")
            {
                pictureBox1.Image = imageList1.Images[10];
            }

            if (marcasComboBox.SelectedItem.ToString() == "NISSAN")
            {
                pictureBox1.Image = imageList1.Images[11];
            }

            if (marcasComboBox.SelectedItem.ToString() == "MERCEDEZ BENZ")
            {
                pictureBox1.Image = imageList1.Images[12];
            }

            var marcaActual = marcasComboBox.Text;

            var ab = (from a in listaModelos
                      where a.marca == marcaActual
                      orderby a.nombre
                      select new { marca = a.marca, nombre = a.nombre }).ToList();

            if (!ab.Any())
            {
                modelosComboBox.DataSource = null;
                modelosComboBox.Text = "No hay modelos";

            }
            else
            {
                modelosComboBox.Text = "";
                modelosComboBox.DataSource = ab;
                modelosComboBox.DisplayMember = "nombre";
                modelosComboBox.ValueMember = "marca";
            }

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

        private void tipoVehiculoComboBox_Validated(object sender, EventArgs e)
        {
            if (tipoVehiculoComboBox.Text.Trim() == "")
            {
                Error.SetError(tipoVehiculoComboBox, "Seleccione opcion");
                tipoVehiculoComboBox.Focus();
            }
            else
            {
                Error.Clear();
            }
        }

        private void marcasComboBox_Validated(object sender, EventArgs e)
        {
            if (marcasComboBox.Text.Trim() == "")
            {
                Error.SetError(marcasComboBox, "Seleccione opcion");
                marcasComboBox.Focus();
            }
            else
            {
                Error.Clear();
            }
        }

        private void combustibleComboBox_Validated(object sender, EventArgs e)
        {
            if (combustibleComboBox.Text.Trim() == "")
            {
                Error.SetError(combustibleComboBox, "Seleccione opcion");
                combustibleComboBox.Focus();
            }
            else
            {
                Error.Clear();
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (tipoVehiculoComboBox.Text == "")
            {
              
                MessageBox.Show("Llene los campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (marcasComboBox.Text == "")
            {
                MessageBox.Show("Llene los campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (combustibleComboBox.Text == "")
            {
                MessageBox.Show("Llene los campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (modelosComboBox.Text == "No hay modelos")
            {
                MessageBox.Show("No hay modelo disponible para la marca seleccionada", "Modelo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            if (tipoVehiculoComboBox.Text != "" && marcasComboBox.Text !="" && modelosComboBox.Text != "No hay modelos" && combustibleComboBox.Text !="")
            {
                
                Vehiculo Vehiculo = new Vehiculo();
                Vehiculo = this;
                ClienteEmpleado objClienteEmpleado = new ClienteEmpleado(Vehiculo);
                this.Hide();
                objClienteEmpleado.Show();
            }
            }
        private void tipoVehiculoComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Letras(e);
            e.Handled = true;
            {
                MessageBox.Show("Solo se permiten la seleccion de opciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void marcasComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Letras(e);
            e.Handled = true;
            {
                MessageBox.Show("Solo se permiten la seleccion de opciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modelosComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Letras(e);
            e.Handled = true;
            {
                MessageBox.Show("Solo se permiten la seleccion de opciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void combustibleComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Letras(e);
            e.Handled = true;
            {
                MessageBox.Show("Solo se permiten la seleccion de opciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tipoVehiculoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipoVehiculoComboBox.SelectedItem.ToString() != "")
            {
                char[] letras = "QWERTYUIOPASDFGHJKLZXCVBNMÑ0123456789".ToCharArray();
                Random r = new Random();
                string randomString = "";
                for (int i = 0; i < 17; i++)
                {
                    randomString += letras[r.Next(0, 35)].ToString();
                    noChasisTextBox.Text = randomString;
                }
                
            }
             if (tipoVehiculoComboBox.SelectedItem.ToString() != "")
            {
                char[] letras = "MNBVCXZASDFGHJKLPOIUYTREWQÑ0123456789".ToCharArray();
                Random r = new Random();
                string randomString = "";
                for (int i = 0; i < 13; i++)
                {
                    randomString += letras[r.Next(0, 35)].ToString();
                    noMotorTextBox.Text = randomString;
                }
            }
             if (tipoVehiculoComboBox.SelectedItem.ToString() != "")
            {
                char[] letras = "MZNXBCVLAKSJDFHGPQOWIEURYT0123456789".ToCharArray();
                Random r = new Random();
                string randomString = "";
                for (int i = 0; i < 7; i++)
                {
                    randomString += letras[r.Next(0, 35)].ToString();
                    noPlacaTextBox.Text = randomString;
                }
            }
             if (tipoVehiculoComboBox.SelectedItem.ToString() != "")
            {
                char[] letras = "ASDFGHJKLMNBVCXZQWERTYUIOP1234567890Ñ".ToCharArray();
                Random r = new Random();
                string randomString = "";
                for (int i = 0; i < 4; i++)
                {
                    randomString += letras[r.Next(0, 35)].ToString();
                    idtipovehiculoTextBox.Text = randomString;
                }
            }
             if (tipoVehiculoComboBox.SelectedItem.ToString() != "")
            {
                char[] letras = "PLMNKOIJBVHUYGCXFTRDZÑSEWAQ1234567809".ToCharArray();
                Random r = new Random();
                string randomString = "";
                for (int i = 0; i < 4; i++)
                {
                    randomString += letras[r.Next(0, 35)].ToString();
                    idmarcasTextBox.Text= randomString;
                }
            }
             if (tipoVehiculoComboBox.SelectedItem.ToString() != "")
            {
                char[] letras = "QAZXSWEDCVFRTGBNHYUJMKIOLP9874561230".ToCharArray();
                Random r = new Random();
                string randomString = "";
                for (int i = 0; i < 4; i++)
                {
                    randomString += letras[r.Next(0, 35)].ToString();
                    idmodelosTextBox.Text = randomString;
                }
            }
            if (tipoVehiculoComboBox.SelectedItem.ToString() != "")
            {
                char[] letras = "POIUYTREWQASDFGHJKLÑMNBVCXZ6541239870".ToCharArray();
                Random r = new Random();
                string randomString = "";
                for (int i = 0; i < 4; i++)
                {
                    randomString += letras[r.Next(0, 35)].ToString();
                    idcombustibleTextBox.Text = randomString;
                }
            }
        }
    }
}
