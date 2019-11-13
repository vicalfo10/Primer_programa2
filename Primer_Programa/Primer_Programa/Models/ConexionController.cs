using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Primer_Programa.Models
{
    public class Conexion
    {
        SqlConnection CN = new SqlConnection();

        //public string CadenaConexion = @"Data Source=VICTOR_DBA\DESARROLLO;Database=t_prueba;User ID=desarrollo;Password=123";
        public string CadenaConexion = @"Data Source=CRI-D2856\SQLVICTOR;Database=prueba;User ID=sa;Password=123";

        public bool encontrar = false;
        public string mensaje = "";
        private void Conectar_BD()
        {
            CN.ConnectionString = CadenaConexion;
            CN.Open();
        }

        public void Desconectar_BD()
        {
            CN.Close();
        }

        public void Sql_Ejecuta_Instruccion(string sqlinstruccion)
        {
            Conectar_BD();
            SqlCommand comando = new SqlCommand(sqlinstruccion, CN);
            comando.ExecuteNonQuery();
            Desconectar_BD();
        }
        public void Llenar_Ds(DataSet ds, string sqlinstruccion)
        {
            Conectar_BD();
            SqlDataAdapter adaptador = new SqlDataAdapter(sqlinstruccion, CN);
            adaptador.Fill(ds);
            Desconectar_BD();
        }


        public Conexion(string CadenaConexion)
        {
            this.CadenaConexion = CadenaConexion;
        }

        public Conexion()
        {

        }
    }
}

/*create database prueba

go

use prueba

go

create table t_login
(
    cod_login integer identity (1,1) primary key,
    nombre    varchar(50),
	usuario char(8),
	clave int,
	estado int
)*/