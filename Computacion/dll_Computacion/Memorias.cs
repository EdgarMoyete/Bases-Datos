using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_Computacion
{
    public class Memorias:IOperaciones
    {
        private string _id_ram;
        private string _marca;
        private string _tipo;
        private byte _capacidad;
        private short _velocidad;

        public Memorias() {
            _id_ram = "";
            _marca = "";
            _tipo = "";
            _capacidad = 0;
            _velocidad = 0;
        }

        public string Id_ram
        {
            get { return _id_ram; }
            set { _id_ram = value; }
        }
        
        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        
        public byte Capacidad
        {
            get { return _capacidad; }
            set { _capacidad = value; }
        }
        
        public short Velocidad
        {
            get { return _velocidad; }
            set { _velocidad = value; }
        }
        
        public bool actualizar()
        {
            bool Resultado = false;
            SqlConnection cn = new SqlConnection(Conexion.cad);
            SqlCommand cmd = new SqlCommand("Computacion.usp_ActualizarMemorias", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_ram", SqlDbType.VarChar,8).Value = _id_ram;
            cmd.Parameters.Add("@marca", SqlDbType.VarChar, 20).Value = _marca;
            cmd.Parameters.Add("@tipo", SqlDbType.VarChar, 5).Value = _tipo;
            cmd.Parameters.Add("@capacidad", SqlDbType.TinyInt).Value = _capacidad;
            cmd.Parameters.Add("@velocidad", SqlDbType.SmallInt).Value = _velocidad;
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
            SqlCommand cmd = new SqlCommand("Computacion.usp_AgregarMemorias", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_ram", SqlDbType.VarChar, 8).Value = _id_ram;
            cmd.Parameters.Add("@marca", SqlDbType.VarChar, 20).Value = _marca;
            cmd.Parameters.Add("@tipo", SqlDbType.VarChar, 5).Value = _tipo;
            cmd.Parameters.Add("@capacidad", SqlDbType.TinyInt).Value = _capacidad;
            cmd.Parameters.Add("@velocidad", SqlDbType.SmallInt).Value = _velocidad;
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
            SqlCommand cmd = new SqlCommand("Computacion.usp_BuscarxIdMemorias", cn);
            cmd.Parameters.Add("@id_ram", SqlDbType.VarChar, 8).Value = _id_ram;
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
            SqlCommand cmd = new SqlCommand("Computacion.usp_ConsultarMemorias", cn);
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
            SqlCommand cmd = new SqlCommand("Computacion.usp_EliminarMemorias", cn);
            cmd.Parameters.Add("@id_ram", SqlDbType.VarChar, 8).Value = _id_ram;
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
