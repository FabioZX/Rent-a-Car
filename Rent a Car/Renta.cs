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
using System.Net;
using System.Net.Mail;

namespace Inutil
{
    public partial class Renta : MetroFramework.Forms.MetroForm
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        Validacion v = new Validacion();
      
        public Inspeccion inspeccion;
        
        public Renta()
        {
            InitializeComponent();
        }
        public Renta(Inspeccion inspeccion)
        {
            InitializeComponent();
            this.inspeccion = inspeccion;
        }
        
        private void Renta_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zXDataSet.Vehiculos' table. You can move, or remove it, as needed.
            this.vehiculosTableAdapter.Fill(this.zXDataSet.Vehiculos);
            costoDiaTextBox.Text = "";
            cantidadDiasTextBox.Text = "";
            comentarioTextBox.Text = "";
            comisionTextBox.Text = "5";
            noRentaTextBox.Text = "";
            fechaRentaDateTimePicker.Text = "";
            fechaDevolucionDateTimePicker.Text = "";
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Inspeccion objInspeccion = new Inspeccion();
            this.Hide();
            objInspeccion.Show();
        }

        private void costoDiaTextBox_Validated_1(object sender, EventArgs e)
        {
            if (costoDiaTextBox.Text.Trim() == "")
            {
                Error.SetError(costoDiaTextBox, "Seleccione opcion");
                costoDiaTextBox.Focus();
            }
            else
            {
                Error.Clear();
            }
        }

        private void cantidadDiasTextBox_Validated_1(object sender, EventArgs e)
        {
            if (cantidadDiasTextBox.Text.Trim() == "")
            {
                Error.SetError(cantidadDiasTextBox, "Seleccione opcion");
                cantidadDiasTextBox.Focus();
            }
            else
            {
                Error.Clear();
            }
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Esta seguro de volver a la ventana anterior", "Retroceder", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Menu objMenu = new Menu();
                this.Hide();
                objMenu.Show();
            }
        }

        private void metroButton_Click_1(object sender, EventArgs e)
        {
            if (costoDiaTextBox.Text == "")
            {
                MessageBox.Show("Llene los campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cantidadDiasTextBox.Text == "")
            {
                MessageBox.Show("Llene los campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(DateTime.Today.AddDays (-1) > fechaDevolucionDateTimePicker.Value.Date)
            {
                MessageBox.Show("No se permite seleccionar una fechar anterior a la actual", "Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                int variableBit;
                conexion.ConnectionString = @"Data Source =.; Initial Catalog = ZX; Integrated Security = True";
                comando.Connection = conexion;

                comando.CommandText = "Insert INTO Vehiculos (NoChasis, NoMotor, NoPlaca, idtipovehiculo, TipoVehiculo, Marcas, idmarcas, Modelos, idmodelos, idcombustible, Combustible, idcliente, ClienteNombre, CedulaCliente, Correo, NoTarjeta, Limite, PersonaFisica, PersonaJuridica, idempleado, EmpleadoNombre, CedulaEmpleado, Tanda, Comision, idtransaccion, Ralladuras, cCombustible1, cCombustible2, cCombustible3, cCombustible4, Gomas, Gato, Roturas, eGomas1, eGomas2, eGomas3, eGomas4, FechaInspeccion, NoRenta, FechaRenta, FechaDevolucion, CostoDia, CantidadDias, Comentario)"
                                      + "Values (@NoChasis, @NoMotor, @NoPlaca, @idtipovehiculo, @TipoVehiculo, @Marcas, @idmarcas, @Modelos, @idmodelos, @idcombustible, @Combustible, @idcliente, @ClienteNombre, @CedulaCliente, @Correo, @NoTarjeta, @Limite, @PersonaFisica, @PersonaJuridica, @idempleado, @EmpleadoNombre, @CedulaEmpleado, @Tanda, @Comision, @idtransaccion, @Ralladuras, @cCombustible1, @cCombustible2, @cCombustible3, @cCombustible4, @Gomas, @Gato, @Roturas, @eGomas1, @eGomas2, @eGomas3, @eGomas4, @FechaInspeccion, @NoRenta, @FechaRenta, @FechaDevolucion, @CostoDia, @CantidadDias, @Comentario)";

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("NoChasis", inspeccion.ClienteEmpleado.Vehiculo.noChasisTextBox.Text);
                comando.Parameters.AddWithValue("NoMotor", inspeccion.ClienteEmpleado.Vehiculo.noMotorTextBox.Text);
                comando.Parameters.AddWithValue("NoPlaca", inspeccion.ClienteEmpleado.Vehiculo.noPlacaTextBox.Text);
                comando.Parameters.AddWithValue("idtipovehiculo", inspeccion.ClienteEmpleado.Vehiculo.idtipovehiculoTextBox.Text);
                comando.Parameters.AddWithValue("TipoVehiculo",inspeccion.ClienteEmpleado.Vehiculo.tipoVehiculoComboBox.Text);
                comando.Parameters.AddWithValue("Marcas", inspeccion.ClienteEmpleado.Vehiculo.marcasComboBox.Text);
                comando.Parameters.AddWithValue("idmarcas", inspeccion.ClienteEmpleado.Vehiculo.idmarcasTextBox.Text);
                comando.Parameters.AddWithValue("Modelos", inspeccion.ClienteEmpleado.Vehiculo.modelosComboBox.Text);
                comando.Parameters.AddWithValue("idmodelos", inspeccion.ClienteEmpleado.Vehiculo.idmodelosTextBox.Text);
                comando.Parameters.AddWithValue("idcombustible", inspeccion.ClienteEmpleado.Vehiculo.idcombustibleTextBox.Text);
                comando.Parameters.AddWithValue("Combustible", inspeccion.ClienteEmpleado.Vehiculo.combustibleComboBox.Text);

                comando.Parameters.AddWithValue("idcliente", inspeccion.ClienteEmpleado.idclienteTextBox.Text); 
                comando.Parameters.AddWithValue("ClienteNombre", inspeccion.ClienteEmpleado.clienteNombreTextBox.Text);
                comando.Parameters.AddWithValue("CedulaCliente", inspeccion.ClienteEmpleado.cedulaClienteMaskedTextBox.Text);
                comando.Parameters.AddWithValue("Correo", inspeccion.ClienteEmpleado.correoTextBox.Text);
                comando.Parameters.AddWithValue("NoTarjeta", inspeccion.ClienteEmpleado.noTarjetaMaskedTextBox.Text);
                comando.Parameters.AddWithValue("Limite", float.Parse(inspeccion.ClienteEmpleado.limiteTextBox.Text));
                if (inspeccion.ClienteEmpleado.personaFisicaMetroRadioButton.Checked) variableBit = 1;
                else variableBit = 0;
                comando.Parameters.AddWithValue("PersonaFisica", variableBit);
                if (inspeccion.ClienteEmpleado.personaJuridicaMetroRadioButton.Checked) variableBit = 1;
                else variableBit = 0;
                comando.Parameters.AddWithValue("PersonaJuridica", variableBit);
                comando.Parameters.AddWithValue("idempleado", inspeccion.ClienteEmpleado.idempleadoTextBox.Text);
                comando.Parameters.AddWithValue("EmpleadoNombre", inspeccion.ClienteEmpleado.empleadoNombreTextBox.Text);
                comando.Parameters.AddWithValue("CedulaEmpleado", inspeccion.ClienteEmpleado.cedulaEmpleadoMaskedTextBox.Text);
                comando.Parameters.AddWithValue("Tanda", inspeccion.ClienteEmpleado.tandaComboBox.Text);
                comando.Parameters.AddWithValue("Comision", float.Parse(inspeccion.ClienteEmpleado.comisionTextBox.Text));

                comando.Parameters.AddWithValue("idtransaccion", inspeccion.idtransaccionTextBox.Text);
                if (inspeccion.ralladurasMetroCheckBox.Checked) variableBit = 1;
                else variableBit = 0;
                comando.Parameters.AddWithValue("Ralladuras", variableBit);

                if (inspeccion.cCombustible1MetroRadioButton.Checked) variableBit = 1;
                else variableBit = 0;
                comando.Parameters.AddWithValue("cCombustible1", variableBit);

                if (inspeccion.cCombustible2MetroRadioButton.Checked) variableBit = 1;
                else variableBit = 0;
                comando.Parameters.AddWithValue("cCombustible2", variableBit);

                if (inspeccion.cCombustible3MetroRadioButton.Checked) variableBit = 1;
                else variableBit = 0;
                comando.Parameters.AddWithValue("cCombustible3", variableBit);

                if (inspeccion.cCombustible4MetroRadioButton.Checked) variableBit = 1;
                else variableBit = 0;
                comando.Parameters.AddWithValue("cCombustible4", variableBit);

                if (inspeccion.gomasMetroCheckBox.Checked) variableBit = 1;
                else variableBit = 0;
                comando.Parameters.AddWithValue("Gomas", variableBit);

                if (inspeccion.gomasMetroCheckBox.Checked) variableBit = 1;
                else variableBit = 0;
                comando.Parameters.AddWithValue("Gato", variableBit);

                if (inspeccion.roturasMetroCheckBox.Checked) variableBit = 1;
                else variableBit = 0;
                comando.Parameters.AddWithValue("Roturas", variableBit);

                if (inspeccion.eGomas1MetroCheckBox.Checked) variableBit = 1;
                else variableBit = 0;
                comando.Parameters.AddWithValue("eGomas1", variableBit);

                if (inspeccion.eGomas2MetroCheckBox.Checked) variableBit = 1;
                else variableBit = 0;
                comando.Parameters.AddWithValue("eGomas2", variableBit);

                if (inspeccion.eGomas3MetroCheckBox.Checked) variableBit = 1;
                else variableBit = 0;
                comando.Parameters.AddWithValue("eGomas3", variableBit);

                if (inspeccion.eGomas4MetroCheckBox.Checked) variableBit = 1;
                else variableBit = 0;
                comando.Parameters.AddWithValue("eGomas4", variableBit);

                comando.Parameters.AddWithValue("FechaInspeccion", DateTime.Parse(inspeccion.fechaInspeccionDateTimePicker.Text));

                comando.Parameters.AddWithValue("NoRenta", noRentaTextBox.Text);
                comando.Parameters.AddWithValue("FechaRenta", DateTime.Parse(fechaRentaDateTimePicker.Text));
                comando.Parameters.AddWithValue("FechaDevolucion", DateTime.Parse(fechaDevolucionDateTimePicker.Text));
                comando.Parameters.AddWithValue("CostoDia", int.Parse(costoDiaTextBox.Text));
                comando.Parameters.AddWithValue("cantidadDias", int.Parse(cantidadDiasTextBox.Text));
                comando.Parameters.AddWithValue("Comentario", comentarioTextBox.Text);

                try
                {
                    conexion.Open();
                    int NFilas = comando.ExecuteNonQuery();

                    if (NFilas > 0)
                    {

                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Hubo un error al intentar guardar los datos: " + ex);
                }
                finally
                {
                    conexion.Close();    //se cierra la conexion para liberar espacio en memoria
                    comando.Dispose();       //se limpian los comandos para poder hacer otra consulta
                }

                txtResultado.Text = (double.Parse(costoDiaTextBox.Text) * double.Parse(cantidadDiasTextBox.Text)).ToString();
                txtPor.Text = (double.Parse(comisionTextBox.Text) * double.Parse(txtResultado.Text) / 100).ToString();

                txtRecibo.Text = ("");
                txtRecibo.AppendText("=========================================\r\n");
                txtRecibo.AppendText("                                 Informacion\r\n");
                txtRecibo.AppendText("=========================================\r\n");
                txtRecibo.AppendText("Recibo de la renta\t\t\t" + "\r\n");
                txtRecibo.AppendText("ID Cliente: " + inspeccion.ClienteEmpleado.idclienteTextBox.Text + "\r\n");
                txtRecibo.AppendText("Cliente: " + inspeccion.ClienteEmpleado.clienteNombreTextBox.Text + "\r\n");
                txtRecibo.AppendText("Tipo Vehiculo: " + inspeccion.ClienteEmpleado.Vehiculo.tipoVehiculoComboBox.Text + "\r\n");
                txtRecibo.AppendText("Marca: " + inspeccion.ClienteEmpleado.Vehiculo.marcasComboBox.Text + "\r\n");
                txtRecibo.AppendText("Modelo: " + inspeccion.ClienteEmpleado.Vehiculo.modelosComboBox.Text + "\r\n");
                txtRecibo.AppendText("No.Chasis: " + inspeccion.ClienteEmpleado.Vehiculo.noChasisTextBox.Text + "\r\n");
                txtRecibo.AppendText("No.Motor: " + inspeccion.ClienteEmpleado.Vehiculo.noMotorTextBox.Text + "\r\n");
                txtRecibo.AppendText("No.Placa: " + inspeccion.ClienteEmpleado.Vehiculo.noPlacaTextBox.Text + "\r\n");
                txtRecibo.AppendText("Total a pagar: " + txtResultado.Text + "\r\n");
                txtRecibo.AppendText("=========================================\r\n");
                txtRecibo.AppendText("                Esta parte solo la ve el empleado\r\n");
                txtRecibo.AppendText("=========================================\r\n");
                txtRecibo.AppendText("Porcentaje: " + txtPor.Text + "\r\n");
            }
        }

        private void costoDiaTextBox_TextChanged(object sender, EventArgs e)
        {
           
            if (costoDiaTextBox.Text != "")
            {

                char[] letras = "ASDFGHJKLMNBVCXZQWERTYUIOP1234567890Ñ".ToCharArray();
                Random r = new Random();
                string randomString = "";
                for (int i = 0; i < 4; i++)
                {
                    randomString += letras[r.Next(0, 35)].ToString();
                    noRentaTextBox.Text = randomString;
                }
            }
           
        }

        private void costoDiaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Numeros(e);
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cantidadDiasTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Numeros(e);
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
