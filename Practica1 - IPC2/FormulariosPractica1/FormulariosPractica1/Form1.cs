using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosPractica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            ReferenciaWeb.ServicioWeb objeto = new ReferenciaWeb.ServicioWeb();
            MessageBox.Show(objeto.HelloWorld());
            objeto.NuevoCliente(TBnombre.Text, TBapellido.Text, TBdireccion.Text, TBtelefono.Text, TBdpi.Text);
            MessageBox.Show("Sus datos han sido enviados!");




        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InscribeLibro miform = new InscribeLibro();
            miform.Show();


        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConsultarLibros miform = new ConsultarLibros();
            miform.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MasLibros miform = new MasLibros();
            miform.Show();
        }
    }
}
