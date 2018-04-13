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
using System.Configuration;
using System.Data.OleDb;
using System.ComponentModel;


namespace Inutil
{
    public partial class Devolucion : MetroFramework.Forms.MetroForm
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        Validacion v = new Validacion();


        public Devolucion() 
        {
            InitializeComponent();

        }

        private void Devolucion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zXDataSet.Vehiculos' table. You can move, or remove it, as needed.
            this.vehiculosTableAdapter.Fill(this.zXDataSet.Vehiculos);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Placa")

            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=ZX;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Vehiculos Where NoPlaca like '" + textBox1.Text + "%' ", sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
            }
            
            else if (comboBox1.Text == "Cedula")

            { 
            SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=ZX;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Vehiculos Where CedulaCliente like '" + textBox1.Text + "%' ", sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridView1.DataSource = dtbl; 
            }       
        }

        ZXDataSet db = new ZXDataSet();
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=ZX;Integrated Security=True");
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quiere devolver este vehiculo", "Devolucion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rows = dataGridView1.RowCount;
                for (int i = rows - 1; i >= 0; i--)
                {
                    if (dataGridView1.Rows[i].Selected)
                    {
                        conexion.ConnectionString = @"Data Source =.; Initial Catalog = ZX; Integrated Security = True";
                        comando.Connection = conexion;
                        comando.CommandText = "Delete TOP (1) PERCENT From Vehiculos";
                        vehiculosBindingSource.RemoveAt(dataGridView1.Rows[i].Index);  
                    }
                }
            }
            
            try
            {
                conexion.Open();
                int NFilas = comando.ExecuteNonQuery();

                if (NFilas > 0)
                {
                    MessageBox.Show("El vehiculo ha sido devuelto", "Devolucion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al intentar borrar los datos: " + ex);
            }
            finally
            {
                conexion.Close();    //se cierra la conexion para liberar espacio en memoria
                comando.Dispose();       //se limpian los comandos para poder hacer otra consulta
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

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Letras(e);
            e.Handled = true;
            {
                MessageBox.Show("Solo se permiten la seleccion de opciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
