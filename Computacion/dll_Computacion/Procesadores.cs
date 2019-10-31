using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_Computacion
{
    public class Procesadores:IOperaciones
    {
        private string _id_cpu;
        private string _marca;
        private string _modelo;
        private float _frecuencia;
        private float _turboBoost;
        private byte _nucleos;
        private byte _subnucleos;
        private byte _cache;

        public Procesadores() {
            _id_cpu = "";
            _marca = "";
            _modelo = "";
            _frecuencia = 0;
            _turboBoost = 0;
            _nucleos = 0;
            _subnucleos = 0;
            _cache = 0;
        }

        public string Id_cpu
        {
            get { return _id_cpu; }
            set { _id_cpu = value; }
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
        
        public float Frecuencia
        {
            get { return _frecuencia; }
            set { _frecuencia = value; }
        }
        
        public float TurboBoost
        {
            get { return _turboBoost; }
            set { _turboBoost = value; }
        }
        
        public byte Nucleos
        {
            get { return _nucleos; }
            set { _nucleos = value; }
        }
        
        public byte Subnucleos
        {
            get { return _subnucleos; }
            set { _subnucleos = value; }
        }
        
        public byte Cache
        {
            get { return _cache; }
            set { _cache = value; }
        }
        
        public bool actualizar()
        {
            bool Resultado = false;
            SqlConnection cn = new SqlConnection(Conexion.cad);
            SqlCommand cmd = new SqlCommand("Computacion.usp_ActualizarProcesadores", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_cpu", SqlDbType.VarChar,8).Value = _id_cpu;
            cmd.Parameters.Add("@marca", SqlDbType.VarChar, 20).Value = _marca;
            cmd.Parameters.Add("@modelo", SqlDbType.VarChar, 20).Value = _modelo;
            cmd.Parameters.Add("@frecuencia", SqlDbType.Float).Value = _frecuencia;
            cmd.Parameters.Add("@turboBoost", SqlDbType.Float).Value = _turboBoost;
            cmd.Parameters.Add("@nucleos", SqlDbType.TinyInt).Value = _nucleos;
            cmd.Parameters.Add("@subnucleos", SqlDbType.TinyInt).Value = _subnucleos;
            cmd.Parameters.Add("@cache", SqlDbType.TinyInt).Value = _cache;
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
            SqlCommand cmd = new SqlCommand("Computacion.usp_AgregarProcesadores", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_cpu", SqlDbType.VarChar, 8).Value = _id_cpu;
            cmd.Parameters.Add("@marca", SqlDbType.VarChar, 20).Value = _marca;
            cmd.Parameters.Add("@modelo", SqlDbType.VarChar, 20).Value = _modelo;
            cmd.Parameters.Add("@frecuencia", SqlDbType.Float).Value = _frecuencia;
            cmd.Parameters.Add("@turboBoost", SqlDbType.Float).Value = _turboBoost;
            cmd.Parameters.Add("@nucleos", SqlDbType.TinyInt).Value = _nucleos;
            cmd.Parameters.Add("@subnucleos", SqlDbType.TinyInt).Value = _subnucleos;
            cmd.Parameters.Add("@cache", SqlDbType.TinyInt).Value = _cache;
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
            SqlCommand cmd = new SqlCommand("Computacion.usp_BuscarxIdProcesadores", cn);
            cmd.Parameters.Add("@id_cpu", SqlDbType.VarChar, 8).Value = _id_cpu;
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
            SqlCommand cmd = new SqlCommand("Computacion.usp_ConsultarProcesadores", cn);
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
            SqlCommand cmd = new SqlCommand("Computacion.usp_EliminarProcesadores", cn);
            cmd.Parameters.Add("@id_cpu", SqlDbType.VarChar, 8).Value = _id_cpu;
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