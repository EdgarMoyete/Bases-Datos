using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_Escuela
{
    public class Calificaciones:IOperaciones
    {
        public bool actualizar()
        {
            bool Resultado = false;
            SqlConnection cn = new SqlConnection(Conexion.cad);
            SqlCommand cmd = new SqlCommand("", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Resultado = true;
                }
                cn.Close();
                cn.Dispose();
            }
            catch (Exception ex)
            {

                throw (new Exception(ex.Message));
            }
            return Resultado;
        }

        public bool agregar()
        {
            bool resultado = false;
            SqlConnection cn = new SqlConnection(Conexion.cad);
            SqlCommand cmd = new SqlCommand("", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    resultado = true;
                }
                cn.Close();
                cn.Dispose();
            }
            catch (Exception ex)
            {

                throw (new Exception(ex.Message));
            }
            return resultado;
        }

        public System.Data.DataTable buscarxId()
        {
            DataTable Resultado = new DataTable();
            SqlConnection cn = new SqlConnection(Conexion.cad);
            SqlCommand cmd = new SqlCommand("", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cn.Open();
                Resultado.Load(cmd.ExecuteReader());
                cn.Close();
                cn.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Resultado;
        }

        public System.Data.DataTable consultar()
        {
            DataTable Resultado = new DataTable();
            SqlConnection cn = new SqlConnection(Conexion.cad);
            SqlCommand cmd = new SqlCommand("Estudiantes.usp_ConsultarCalificaciones", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cn.Open();
                Resultado.Load(cmd.ExecuteReader());
                cn.Close();
                cn.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return Resultado;
        }

        public bool eliminar()
        {
            bool Resultado = false;
            SqlConnection cn = new SqlConnection(Conexion.cad);
            SqlCommand cmd = new SqlCommand("", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Resultado = true;
                }
                cn.Close();
                cn.Dispose();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return Resultado;
        }
    }
}
