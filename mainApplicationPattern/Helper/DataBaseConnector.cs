using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mainApplicationPattern.Helper
{
    class DataBaseConnector
    {
        private DataTable _dataTable;
        private MySqlConnectionStringBuilder _connectionString;

        public DataBaseConnector()
        {
            _dataTable = new DataTable();
            _connectionString = new MySqlConnectionStringBuilder();
            _connectionString.Port = 3306;
        }
        #region ConnectionString
        public string Server
        {
            get { return _connectionString.Server; }
            set { _connectionString.Server = value; }
        }
        public string Database
        {
            get { return _connectionString.Database; }
            set { _connectionString.Database = value; }
        }
        public string UserID
        {
            get { return _connectionString.UserID; }
            set { _connectionString.UserID = value; }
        }
        public string Password
        {
            get { return _connectionString.Password; }
            set { _connectionString.Password = value; }
        }
        #endregion

        public DataTable SelectCommand(string query)
        {
            using (var connection = new MySqlConnection())
            {
                connection.ConnectionString = _connectionString.ConnectionString;
                var command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    using (var dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                            _dataTable.Load(dataReader);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            return _dataTable;
        }
        public void InsertCommand(string query)
        {
            using (var connection = new MySqlConnection())
            {
                connection.ConnectionString = _connectionString.ConnectionString;
                var command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }
    }
}
