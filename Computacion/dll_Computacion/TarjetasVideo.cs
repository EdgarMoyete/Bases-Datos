using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_Computacion
{
    public class TarjetasVideo:IOperaciones
    {
        private string _id_gpu;
        private string _marca;
        private string _modelo;
        private short _capacidad;
        private short _frecuencia;
        private short _frecuenciaMaxima;

        public TarjetasVideo() {
            _id_gpu = "";
            _marca = "";
            _modelo = "";
            _capacidad = 0;
            _frecuencia = 0;
            _frecuenciaMaxima = 0;
        }

        public string Id_gpu
        {
            get { return _id_gpu; }
            set { _id_gpu = value; }
        }
        
        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        
        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        
        public short Capacidad
        {
            get { return _capacidad; }
            set { _capacidad = value; }
        }
        
        public short Frecuencia
        {
            get { return _frecuencia; }
            set { _frecuencia = value; }
        }
        
        public short FrecuenciaMaxima
        {
            get { return _frecuenciaMaxima; }
            set { _frecuenciaMaxima = value; }
        }
        
        public bool actualizar()
        {
            bool Resultado = false;
            SqlConnection cn = new SqlConnection(Conexion.cad);
            SqlCommand cmd = new SqlCommand("Computacion.usp_ActualizarTarjetasVideo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_gpu", SqlDbType.VarChar,8).Value = _id_gpu;
            cmd.Parameters.Add("@marca", SqlDbType.VarChar,20).Value = _marca;
            cmd.Parameters.Add("@modelo", SqlDbType.VarChar,10).Value = _modelo;
            cmd.Parameters.Add("@capacidad", SqlDbType.SmallInt).Value = _capacidad;
            cmd.Parameters.Add("@frecuencia", SqlDbType.SmallInt).Value = _frecuencia;
            cmd.Parameters.Add("@frecuenciaMaxima", SqlDbType.SmallInt).Value = _frecuenciaMaxima;
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
            SqlCommand cmd = new SqlCommand("Computacion.usp_AgregarTarjetasVideo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_gpu", SqlDbType.VarChar, 8).Value = _id_gpu;
            cmd.Parameters.Add("@marca", SqlDbType.VarChar, 20).Value = _marca;
            cmd.Parameters.Add("@modelo", SqlDbType.VarChar, 10).Value = _modelo;
            cmd.Parameters.Add("@capacidad", SqlDbType.SmallInt).Value = _capacidad;
            cmd.Parameters.Add("@frecuencia", SqlDbType.SmallInt).Value = _frecuencia;
            cmd.Parameters.Add("@frecuenciaMaxima", SqlDbType.SmallInt).Value = _frecuenciaMaxima;
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
            SqlCommand cmd = new SqlCommand("Computacion.usp_BuscarxIdTarjetasVideo", cn);
            cmd.Parameters.Add("@id_gpu", SqlDbType.VarChar, 8).Value = _id_gpu;
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
            SqlCommand cmd = new SqlCommand("Computacion.usp_ConsultarTarjetasVideo", cn);
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
            SqlCommand cmd = new SqlCommand("Computacion.usp_EliminarTarjetasVideo", cn);
            cmd.Parameters.Add("@id_gpu", SqlDbType.VarChar, 8).Value = _id_gpu;
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