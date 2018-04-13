using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inutil
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        { 
            InitializeComponent();
            Thread t = new Thread(new ThreadStart(Startform));
            t.Start();
            Thread.Sleep(3200);
            t.Abort();
        }
        
        private void Startform()
        {
            Application.Run(new Carga());
        }

        private void btnLogin_Click(object sender, EventArgs e)
    {
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=ZX;Integrated Security=True");
                string query = "Select * From Login where Username = '" + txtUsername.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    
                    Menu objMenu = new Menu();
                    this.Hide();
                    objMenu.Show();
                }
                

                else

                {
                   MessageBox.Show( "Nombre de usuario o contraseña incorrectas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }   
}
