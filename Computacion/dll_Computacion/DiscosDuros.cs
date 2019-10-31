using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_Computacion
{
    public class DiscosDuros:IOperaciones
    {
        private string _id_discosDuros;
        private string _marca;
        private string _modelo;
        private string _tipo;
        private short _capacidad;
        private short _velocidad;

        public DiscosDuros() {
            _id_discosDuros = "";
            _marca = "";
            _modelo = "";
            _tipo = "";
            _capacidad = 0;
            _velocidad = 0;
        }

        public string Id_discosDuros
        {
            get { return _id_discosDuros; }
            set { _id_discosDuros = value; }
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
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public short Capacidad
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
            SqlCommand cmd = new SqlCommand("Computacion.usp_ActualizarDiscosDuros", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_discoDuro", SqlDbType.VarChar, 8).Value = _id_discosDuros;
            cmd.Parameters.Add("@marca", SqlDbType.VarChar,20).Value = _marca;
            cmd.Parameters.Add("@modelo", SqlDbType.VarChar,10).Value = _modelo;
            cmd.Parameters.Add("@tipo", SqlDbType.VarChar,3).Value = _tipo;
            cmd.Parameters.Add("@capacidad", SqlDbType.SmallInt).Value = _capacidad;
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
            SqlCommand cmd = new SqlCommand("Computacion.usp_AgregarDiscosDuros", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_discoDuro", SqlDbType.VarChar, 8).Value = _id_discosDuros;
            cmd.Parameters.Add("@marca", SqlDbType.VarChar, 20).Value = _marca;
            cmd.Parameters.Add("@modelo", SqlDbType.VarChar, 10).Value = _modelo;
            cmd.Parameters.Add("@tipo", SqlDbType.VarChar, 3).Value = _tipo;
            cmd.Parameters.Add("@capacidad", SqlDbType.SmallInt).Value = _capacidad;
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
            SqlCommand cmd = new SqlCommand("Computacion.usp_BuscarxIdDiscosDuros", cn);
            cmd.Parameters.Add("@id_discoDuro", SqlDbType.VarChar, 8).Value = _id_discosDuros;
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
            SqlCommand cmd = new SqlCommand("Computacion.usp_ConsultarDiscosDuros", cn);
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
            SqlCommand cmd = new SqlCommand("Computacion.usp_EliminarDiscosDuros", cn);
            cmd.Parameters.Add("@id_discoDuro", SqlDbType.VarChar, 8).Value = _id_discosDuros;
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