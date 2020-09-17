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

namespace SistemaDeViajes
{
    public partial class IniciaSesion : Form
    {
        string connectionString = "Server=ESAU-DESKTOP\\SQLEXPRESS;Database=Viajes;Trusted_connection=true";
        //string connectionString = "Server = JULIO\\SQLEXPRESS; Database = Viajes; Trusted_connection = true";
        //string connectionString = "server=LAPTOP-CJSHI7R9\\SQLEXPRESS; Database=Biblioteca; trusted_connection=true";

        SqlConnection connectionSQL;
        public IniciaSesion()
        {
            
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIniciaSesion_Click(object sender, EventArgs e)
        {
            try
            {
                connectionSQL = new SqlConnection(connectionString);
                connectionSQL.Open();
                Hide();
                Inicio inicio = new Inicio(connectionSQL);
                inicio.Show();
            }
            catch (Exception err)
            {
                MessageBox.Show("Hubo un problema con la conexion", err.Message);
                throw err;
            }
        }
    }
}
