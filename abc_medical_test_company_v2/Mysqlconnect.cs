using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    class Mysqlconnect
    {
        private MySqlConnection connection;
        public DataTable dtable;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Mysqlconnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "test1.2";
            uid = "root";
            password = "1234";

            var connectionString = new MySqlConnectionStringBuilder
            {
                Server = server,
                Database = database,
                UserID = uid,
                Password = password,
            }.ToString();

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;

                    default:
                        MessageBox.Show("Error: '" + ex.Message + "'");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error closing connection: " + ex.Message);
                return false;
            }
        }

       
        public void Insert(string query)
        {
            if (this.OpenConnection())
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Database Error: '" + ex.Message + "'");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: '" + ex.Message + "'");
                    }
                    finally
                    {
                        this.CloseConnection();
                    }
                }
            }
        }

        public void Update(string query)
        {
            if (this.OpenConnection())
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Database Error: '" + ex.Message + "'");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: '" + ex.Message + "'");
                    }
                    finally
                    {
                        this.CloseConnection();
                    }
                }
            }
        }

        public void Delete(string query)
        {
            if (this.OpenConnection())
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Database Error: '" + ex.Message + "'");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: '" + ex.Message + "'");
                    }
                    finally
                    {
                        this.CloseConnection();
                    }
                }
            }
        }

        public void Select(string query)
        {
            if (this.OpenConnection())
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        using (var dataReader = cmd.ExecuteReader())
                        {
                            dtable = new DataTable();
                            dtable.Load(dataReader);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Database Error: '" + ex.Message + "'");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: '" + ex.Message + "'");
                    }
                    finally
                    {
                        this.CloseConnection();
                    }
                }
            }
        }

        // Backup and Restore methods can be implemented as needed
        public void Backup()
        {
            // Implementation here
        }

        public void Restore()
        {
            // Implementation here
        }
    }
}
