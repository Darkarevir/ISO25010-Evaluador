﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace ISO25010_Evaluador
{
    class mySqlConexion
    {
        MySqlConnection conexion = new MySqlConnection();
        MySqlCommand comandSQL = new MySqlCommand();
        MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
        MySqlDataReader dataReader;

        DataSet dataset = new DataSet();
        DataSet ds = new DataSet();
        public void conexionMyadmin()
        {
            String server = "localhost";
            String puerto = "3306";
            String usuario = "root";
            String password = "";
            String database = "iso25010";


            string cadena_conexion = "Server='" + server + "';" +
                "Port='" + puerto + "';" +
                "Database='" + database + "';" +
                "Uid='" + usuario + "';" +
                "Pwd='" + password + "';" +
                "; Convert Zero Datetime=True";
            conexion.ConnectionString = cadena_conexion;
            conexion.Open();
        }

        void executeSQL(string sql)
        {
            comandSQL.Connection = conexion;
            comandSQL.CommandText = sql;
            comandSQL.ExecuteNonQuery();
        }
    }
}