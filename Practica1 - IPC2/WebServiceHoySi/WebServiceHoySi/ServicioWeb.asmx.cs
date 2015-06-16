using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceHoySi
{
    /// <summary>
    /// Summary description for ServicioWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioWeb : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        
        [WebMethod]
        public void NuevoCliente(string nombre, string apellido, string direccion, string telefono, string dpi) {

            //string datosConexion = "Data Source = localhost;"
            //   + "Initial Catalog = BIBLIOTECA ; Integrated Security = true;";
            SqlConnection connnn = new SqlConnection("Data Source = localhost;"
               + "Initial Catalog = BIBLIOTECA ; Integrated Security = true;");
            SqlCommand consulta = new SqlCommand("INSERT INTO CLIENTE VALUES(@nombre, @apellido, @direccion, @telefono, @dpi, @reservas, @prestamos)", connnn);
            //SqlCommand consulta = new SqlCommand("insert into Cliente values ('daniel', 'ospina', 'colombia', '345346346', '5667687909980', 0, 0)", connnn);
            consulta.Parameters.AddWithValue("@apellido", apellido);
            consulta.Parameters.AddWithValue("@nombre", nombre);
            consulta.Parameters.AddWithValue("@direccion", direccion);
            consulta.Parameters.AddWithValue("@telefono", telefono);
            consulta.Parameters.AddWithValue("@dpi", dpi);
            consulta.Parameters.AddWithValue("@reservas", 0);
            consulta.Parameters.AddWithValue("@prestamos", 0);
            try
            {
                connnn.Open();
                consulta.ExecuteNonQuery();
                connnn.Close();
            }
            catch (SqlException ex)
            {
                connnn.Close();
                Console.WriteLine("Exception:");
                Console.WriteLine("{0}", ex.ToString());
            }
        
        }
        [WebMethod]
        public void NuevoLibro(string nombre, string autor, string paginas, string tema, string cantidad)
        {

            //string datosConexion = "Data Source = localhost;"
            //   + "Initial Catalog = BIBLIOTECA ; Integrated Security = true;";
            SqlConnection connn = new SqlConnection("Data Source = localhost;"
               + "Initial Catalog = BIBLIOTECA ; Integrated Security = true;");
            SqlCommand consulta = new SqlCommand("INSERT INTO LIBRO VALUES(@nombre, @autor, @paginas, @tema, @prestados, @reservas, @cantidad)", connn);
            //SqlCommand consulta = new SqlCommand("insert into Cliente values ('daniel', 'ospina', 'colombia', '345346346', '5667687909980', 0, 0)", connnn);
            consulta.Parameters.AddWithValue("@autor", autor);
            consulta.Parameters.AddWithValue("@nombre", nombre);
            consulta.Parameters.AddWithValue("@paginas", paginas);
            consulta.Parameters.AddWithValue("@tema", tema);
            consulta.Parameters.AddWithValue("@prestados", 0);
            consulta.Parameters.AddWithValue("@reservas", 0);
            consulta.Parameters.AddWithValue("@cantidad", cantidad);
            try
            {
                connn.Open();
                consulta.ExecuteNonQuery();
                connn.Close();
            }
            catch (SqlException ex)
            {
                connn.Close();
                Console.WriteLine("Exception:");
                Console.WriteLine("{0}", ex.ToString());
            }

        }
    }
}
