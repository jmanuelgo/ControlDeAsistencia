using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ControlDeAsistencia.Logica;
using System.Windows.Forms;

namespace ControlDeAsistencia.Datos
{
    public class Dcargos
    {
        public bool insertar_Cargo(Lcargos parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_Cargo", CONEXIONMAESTRA.conectar);//alterar base de datos
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cargos", parametros.Cargo);
                cmd.Parameters.AddWithValue("@SueldoPorHora", parametros.SueldoPorHora);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
        public bool editar_Cargos(Lcargos parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editar_Cargos", CONEXIONMAESTRA.conectar);//alterar base de datos
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", parametros.Id_cargo);
                cmd.Parameters.AddWithValue("@Cargos", parametros.Cargo);
                cmd.Parameters.AddWithValue("@SueldoPorHora", parametros.SueldoPorHora);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
        public void buscarCargos(ref DataTable dt, string buscador)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("buscarCargos", CONEXIONMAESTRA.conectar);//mostrar base de datos
                da.SelectCommand.CommandType = CommandType.StoredProcedure;//para mandar un comando
                da.SelectCommand.Parameters.AddWithValue("@buscador", buscador);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
    }
}
