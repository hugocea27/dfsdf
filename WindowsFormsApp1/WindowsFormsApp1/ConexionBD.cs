using System.Data;
using Npgsql;
namespace WindowsFormsApp1
{
    public static class ConexionBD
    {

        private static string CadenaConexion = 
            "Server=localhost;Port=5434;User Id=postgres;Password=uca;Database=POOPacialFinal";
        
        public static DataTable query(string sql)
        {
            NpgsqlConnection conn = new NpgsqlConnection(CadenaConexion);
            DataSet ds = new DataSet();
            
            conn.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            da.Fill(ds);
            conn.Close();
            
            return ds.Tables[0];
        }

        public static void nonQuery(string sql)
        {
            NpgsqlConnection conn = new NpgsqlConnection(CadenaConexion);
            
            conn.Open();
            NpgsqlCommand nc = new NpgsqlCommand(sql, conn);
            nc.ExecuteNonQuery();
            conn.Close();
        }
    }
}