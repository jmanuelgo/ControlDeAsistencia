using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ControlDeAsistencia.Datos
{
    public class CONEXIONMAESTRA
    {
        public static string conexion = @"Data source=DESKTOP-FF9M074\SQLEXPRESS;Initial Catalog=Ce Registro;Integrated Segurity=true";
        public static SqlConnection conectar = new SqlConnection(conexion);
        public static void abrir() {
            if (conectar.State == ConnectionState.Closed) {
                conectar.Open();
            }
        }
        public static void cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
