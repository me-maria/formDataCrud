﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.DirectoryServices;

namespace Projeto3Camadas.Code.DAL// Dal = Data Acess Layer = camada de acesso a dados
{
    internal class AcessoBancoDedados
    {
        private MySqlConnection conn;
        private DataTable data;
        private MySqlDataAdapter da;
        private MySqlDataReader dr;
        private MySqlCommandBuilder cb;

        private string server = "localhost";
        private string user = "root";
        private string Password = "";
        private string database = "bdFormCliente";

        public void Conectar()
        {
            if (conn != null)
                conn.Close();

            string connStr = string.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, user, Password, database);

            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void ExecutarComandoSQL(string comandoSql)
        {
            MySqlCommand comando = new MySqlCommand(comandoSql, conn);
            comando.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable RetDataTable(string sql)
        {
            data = new DataTable();
            da = new MySqlDataAdapter(sql, conn);
            cb = new MySqlCommandBuilder(da);
            da.Fill(data);

            return data;
        }
        public MySqlDataReader RetDataReader(string sql)
        {
            MySqlCommand comando = new MySqlCommand(sql, conn);
            MySqlDataReader dr = comando.ExecuteReader();
            dr.Read();
            return dr;
        }
    }
}
