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
    public partial class InscribeLibro : Form
    {
        public InscribeLibro()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReferenciaWeb.ServicioWeb objeto = new ReferenciaWeb.ServicioWeb();
            MessageBox.Show(objeto.HelloWorld());
            objeto.NuevoLibro(TBnombre.Text, TBautor.Text, TBpaginas.Text, TBtema.Text, TBcantidad.Text);
            MessageBox.Show("Registro enviado!");
        }
    }
}
