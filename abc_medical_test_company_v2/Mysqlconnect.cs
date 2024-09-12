using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
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

        // Initialize connection details
        private void Initialize()
        {
            server = "localhost";
            database = "test1.2"; // This is the database we will check
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

        // Check if MySQL is installed by verifying the 'mysql' command is recognized
        public bool IsMySQLInstalled()
        {
            try
            {
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "mysql",
                        Arguments = "--version",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                    }
                };
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                return output.Contains("mysql");
            }
            catch (Exception)
            {
                MessageBox.Show("MySQL is not installed. Please install MySQL 8.0.");
                return false;
            }
        }

        // Check if MySQL bin folder is in the system's PATH environment variable
        public bool IsMySQLPathInEnvironment()
        {
            string pathVariable = Environment.GetEnvironmentVariable("PATH");
            return pathVariable != null && pathVariable.Contains("MySQL");
        }

        // Open connection to the database
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

        // Close connection to the database
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

        // Check if the specified database exists
        public bool IsDatabaseCreated()
        {
            try
            {
                using (var cmd = new MySqlCommand($"SHOW DATABASES LIKE '{database}';", connection))
                {
                    OpenConnection();
                    object result = cmd.ExecuteScalar();
                    CloseConnection();
                    return result != null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking database: '" + ex.Message + "'");
                return false;
            }
        }

        // Execute SQL setup file if the database is not found
        public void ExecuteSetupSQL(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string script = File.ReadAllText(filePath);
                    MySqlCommand command = new MySqlCommand(script, connection);
                    OpenConnection();
                    command.ExecuteNonQuery();
                    CloseConnection();
                    MessageBox.Show("Database setup completed successfully.");
                }
                else
                {
                    MessageBox.Show("setup.sql file not found in the solution items.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing SQL setup: '" + ex.Message + "'");
            }
        }

        // Insert data into the database
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

        // Update data in the database
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

        // Delete data from the database
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

        // Select data from the database
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
