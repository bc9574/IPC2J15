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

namespace FormulariosPractica1
{
    public partial class MasLibros : Form
    {
        public MasLibros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source = localhost; Initial Catalog = BIBLIOTECA; Integrated Security = true");
            conectar.Open();
            DataTable dtDatos = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter("select * from Libro", conectar);
            ad.Fill(dtDatos);
            dataGridView1.DataSource = dtDatos;

            conectar.Close();
        }
    }
}
