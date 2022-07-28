using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace MedicPagos
{
    class Conexion
    {
        public static string RutaBDMedicPagos = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=BaseMedicPagos;Integrated Security=True";
        public void ConectarBaseDeDatos(ref SqlConnection conectorBD)
        {
            conectorBD = new SqlConnection(RutaBDMedicPagos);
            conectorBD.Open();
        }

        public DataSet DevolverValor(string consulta)
        {
            DataSet ds = new DataSet();
            SqlConnection cnMedicPagos = new SqlConnection();
            cnMedicPagos.ConnectionString = RutaBDMedicPagos;
            cnMedicPagos.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cnMedicPagos);
            adaptador.Fill(ds, "Medicos");
            return ds;

        }

        public DataTable devuelveTabla(string consulta)
        {
            DataSet ds = new DataSet();
            SqlConnection cnMedicPagos = new SqlConnection();
            cnMedicPagos.ConnectionString = RutaBDMedicPagos;
            cnMedicPagos.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cnMedicPagos);
            adaptador.Fill(ds, "Medicos");
            return ds.Tables["Medicos"];
        }
    }
}
