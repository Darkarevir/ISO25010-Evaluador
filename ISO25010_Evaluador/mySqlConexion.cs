using System;
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
        public mySqlConexion()
        {
            String server = "127.0.0.1";
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

        public DataSet get_caracteristicas()
        {
            dataset.Clear();
            comandSQL.Connection = conexion;
            comandSQL.CommandText = "SELECT * FROM caracteristicas";

            dataAdapter.SelectCommand = comandSQL;
            dataAdapter.Fill(dataset, "caracteristicas");

            return dataset;
        }

        public DataSet getSubCarta(int id_C) {

            DataSet dso = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter();
            dso.Clear();
            comandSQL.Connection = conexion;
            comandSQL.CommandText = "SELECT * from sub_caracteristicas WHERE id_c = '" + id_C+"' ";

            da.SelectCommand = comandSQL;
            da.Fill(dso, "sub_caracteristicas");

            return dso;
        }

        public void insertHu(int idsc, string nombre, Boolean cumple, string valor)
        {
            string sql = "INSERT INTO hu(id_sc, nombre, cumple, valor) VALUES(?idsc, ?nombre, ?cumple, ?valor)";

            comandSQL.Parameters.Clear();
            comandSQL.Parameters.AddWithValue("?idsc", idsc);
            comandSQL.Parameters.AddWithValue("?nombre", nombre);
            comandSQL.Parameters.AddWithValue("?cumple", cumple);
            comandSQL.Parameters.AddWithValue("?valor", valor);

            executeSQL(sql);
        }

        public void deletehu (int idsc)
        {
            string sql = "DELETE FROM hu WHERE id_sc=?idsc";

            comandSQL.Parameters.Clear();
            comandSQL.Parameters.AddWithValue("?idsc", idsc);

            executeSQL(sql);
        }
    }
}
