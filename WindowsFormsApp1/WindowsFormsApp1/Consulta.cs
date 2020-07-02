using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class Consulta
    {
        public static int obtenerDepartemento(string usuario, string contra)
         {
             try
             {
                 string query =
                     $"select id_departamento from usuario where id_usuario = '{usuario}' and contra = '{contra}'";
                 var dt = ConexionBD.query(query);
                 var dr = dt.Rows[0];
                 return Convert.ToInt16(dr[0]);
             }
             catch (Exception)
             {
                 return 0;
             }
         }
    }
}