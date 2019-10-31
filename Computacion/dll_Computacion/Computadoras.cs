using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_Computacion
{
    public class Computadoras:IOperaciones
    {
        private string _numSerie;
        private string _marca;
        private string _modelo;
        private string _tipo;
        private string _color;
        private string _tipoPantalla;
        private byte _pulgadasPantalla;
        private short _anchoPantalla;
        private short _altoPantalla;
        private string _ranuras;
        private short _bateria;
        private bool _unidadOptica;
        private bool _tecladoIluminado;
        private bool _detectorHuella;
        private float _peso;
        private string _sistemaOperativo;
        private string _versionSO;
        private string _id_procesador;
        private string _id_memoria;
        private string _id_tarjetaVideo;
        private string _id_discoDuro;

        public Computadoras() { 
            _numSerie="";
            _marca="";
            _modelo="";
            _tipo="";
            _color="";
            _tipoPantalla="";
            _pulgadasPantalla=0;
            _anchoPantalla=0;
            _altoPantalla=0;
            _ranuras="";
            _bateria=0;
            _unidadOptica=false;
            _tecladoIluminado=false;
            _detectorHuella=false;
            _peso=0;
            _sistemaOperativo="";
            _versionSO="";
            _id_procesador="";
            _id_memoria="";
            _id_tarjetaVideo="";
            _id_discoDuro="";
        }

        public string NumSerie
        {
            get { return _numSerie; }
            set { _numSerie = value; }
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
        
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }        

        public string TipoPantalla
        {
            get { return _tipoPantalla; }
            set { _tipoPantalla = value; }
        }
        
        public byte PulgadasPantalla
        {
            get { return _pulgadasPantalla; }
            set { _pulgadasPantalla = value; }
        }

        public short AnchoPantalla
        {
            get { return _anchoPantalla; }
            set { _anchoPantalla = value; }
        }
        
        public short AltoPantalla
        {
            get { return _altoPantalla; }
            set { _altoPantalla = value; }
        }
        
        public string Ranuras
        {
            get { return _ranuras; }
            set { _ranuras = value; }
        }
        
        public short Bateria
        {
            get { return _bateria; }
            set { _bateria = value; }
        }
        
        public bool UnidadOptica
        {
            get { return _unidadOptica; }
            set { _unidadOptica = value; }
        }
        
        public bool TecladoIluminado
        {
            get { return _tecladoIluminado; }
            set { _tecladoIluminado = value; }
        }
        
        public bool DetectorHuella
        {
            get { return _detectorHuella; }
            set { _detectorHuella = value; }
        }
        
        public float Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }
        
        public string SistemaOperativo
        {
            get { return _sistemaOperativo; }
            set { _sistemaOperativo = value; }
        }
        
        public string VersionSO
        {
            get { return _versionSO; }
            set { _versionSO = value; }
        }
        
        public string Id_procesador
        {
            get { return _id_procesador; }
            set { _id_procesador = value; }
        }
        
        public string Id_memoria
        {
            get { return _id_memoria; }
            set { _id_memoria = value; }
        }
        
        public string Id_tarjetaVideo
        {
            get { return _id_tarjetaVideo; }
            set { _id_tarjetaVideo = value; }
        }
        
        public string Id_discoDuro
        {
            get { return _id_discoDuro; }
            set { _id_discoDuro = value; }
        }
        
        public bool actualizar()
        {
            bool Resultado = false;
            SqlConnection cn = new SqlConnection(Conexion.cad);
            SqlCommand cmd = new SqlCommand("Computacion.usp_ActualizarComputadoras", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@numSerie", SqlDbType.VarChar,8).Value = _numSerie;
            cmd.Parameters.Add("@marca", SqlDbType.VarChar, 20).Value = _marca;
            cmd.Parameters.Add("@modelo", SqlDbType.VarChar,20).Value = _modelo;
            cmd.Parameters.Add("@tipo", SqlDbType.VarChar,10).Value = _tipo;
            cmd.Parameters.Add("@color", SqlDbType.VarChar,10).Value = _color;
            cmd.Parameters.Add("@tipoPantalla", SqlDbType.VarChar,5).Value = _tipoPantalla;
            cmd.Parameters.Add("@pulgadasPantalla", SqlDbType.TinyInt).Value = _pulgadasPantalla;
            cmd.Parameters.Add("@anchoPantalla", SqlDbType.SmallInt).Value = _anchoPantalla;
            cmd.Parameters.Add("@altoPantalla", SqlDbType.SmallInt).Value = _altoPantalla;
            cmd.Parameters.Add("@ranuras", SqlDbType.VarChar,200).Value = _ranuras;
            cmd.Parameters.Add("@bateria", SqlDbType.SmallInt).Value = _bateria;
            cmd.Parameters.Add("@unidadOptica", SqlDbType.Bit).Value = _unidadOptica;
            cmd.Parameters.Add("@tecladoIluminado", SqlDbType.Bit).Value = _tecladoIluminado;
            cmd.Parameters.Add("@detectorHuella", SqlDbType.Bit).Value = _detectorHuella;
            cmd.Parameters.Add("@peso", SqlDbType.Float).Value = _peso;
            cmd.Parameters.Add("@sistemaOperativo", SqlDbType.VarChar,10).Value = _sistemaOperativo;
            cmd.Parameters.Add("@versionSO", SqlDbType.VarChar,20).Value = _versionSO;
            cmd.Parameters.Add("@id_procesador", SqlDbType.VarChar,8).Value = _id_procesador;
            cmd.Parameters.Add("@id_memoria", SqlDbType.VarChar,8).Value = _id_memoria;
            cmd.Parameters.Add("@id_tarjetaVideo", SqlDbType.VarChar,8).Value = _id_tarjetaVideo;
            cmd.Parameters.Add("@id_discoDuro", SqlDbType.VarChar,8).Value = _id_discoDuro;
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
            SqlCommand cmd = new SqlCommand("Computacion.usp_AgregarComputadoras", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@numSerie", SqlDbType.VarChar, 8).Value = _numSerie;
            cmd.Parameters.Add("@marca", SqlDbType.VarChar, 20).Value = _marca;
            cmd.Parameters.Add("@modelo", SqlDbType.VarChar, 20).Value = _modelo;
            cmd.Parameters.Add("@tipo", SqlDbType.VarChar, 10).Value = _tipo;
            cmd.Parameters.Add("@color", SqlDbType.VarChar, 10).Value = _color;
            cmd.Parameters.Add("@tipoPantalla", SqlDbType.VarChar, 5).Value = _tipoPantalla;
            cmd.Parameters.Add("@pulgadasPantalla", SqlDbType.TinyInt).Value = _pulgadasPantalla;
            cmd.Parameters.Add("@anchoPantalla", SqlDbType.SmallInt).Value = _anchoPantalla;
            cmd.Parameters.Add("@altoPantalla", SqlDbType.SmallInt).Value = _altoPantalla;
            cmd.Parameters.Add("@ranuras", SqlDbType.VarChar, 200).Value = _ranuras;
            cmd.Parameters.Add("@bateria", SqlDbType.SmallInt).Value = _bateria;
            cmd.Parameters.Add("@unidadOptica", SqlDbType.Bit).Value = _unidadOptica;
            cmd.Parameters.Add("@tecladoIluminado", SqlDbType.Bit).Value = _tecladoIluminado;
            cmd.Parameters.Add("@detectorHuella", SqlDbType.Bit).Value = _detectorHuella;
            cmd.Parameters.Add("@peso", SqlDbType.Float).Value = _peso;
            cmd.Parameters.Add("@sistemaOperativo", SqlDbType.VarChar, 10).Value = _sistemaOperativo;
            cmd.Parameters.Add("@versionSO", SqlDbType.VarChar, 20).Value = _versionSO;
            cmd.Parameters.Add("@id_procesador", SqlDbType.VarChar, 8).Value = _id_procesador;
            cmd.Parameters.Add("@id_memoria", SqlDbType.VarChar, 8).Value = _id_memoria;
            cmd.Parameters.Add("@id_tarjetaVideo", SqlDbType.VarChar, 8).Value = _id_tarjetaVideo;
            cmd.Parameters.Add("@id_discoDuro", SqlDbType.VarChar, 8).Value = _id_discoDuro;
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
            SqlCommand cmd = new SqlCommand("Computacion.usp_BuscarxIdComputadoras", cn);
            cmd.Parameters.Add("@numSerie", SqlDbType.VarChar, 8).Value = _numSerie;
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
            SqlCommand cmd = new SqlCommand("Computacion.usp_ConsultarComputadoras", cn);
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
            SqlCommand cmd = new SqlCommand("Computacion.usp_EliminarComputadoras", cn);
            cmd.Parameters.Add("@numSerie", SqlDbType.VarChar, 8).Value = _numSerie;
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