using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_MySQL
{
    // Esta clase representa a la conexión con la base de datos
    class DBConnection
    {
        // Instancia singleton al objeto DBConnection
        private static DBConnection instance = null;

        // Objetos necesarios para gestionar la conexión
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        private DBConnection ()
        {
            connection = new MySqlConnection();
        }

        // Método getInstance(): devuelve una única instancia
        // de conexión con la base de datos
        public static DBConnection getInstance ()
        {
            if (instance == null)
            {
                instance = new DBConnection();
            }

            return instance;
        }

        // Realiza la conexión con la base de datos
        public void connect()
        {
            try
            {
                // Se recupera la cadena de conexión de la base de datos
                connection.ConnectionString = Properties.Settings.Default.connectionString;
                
                // Se establece la conexión a la base de datos
                connection.Open();
            }
            catch (Exception e)
            {
                // Se ha producido una excepción al conectar con la bbdd
                MessageBox.Show("ERROR: " + e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error); 
                throw;
            }
        }

        // Cierra la conexión con la base de datos
        public void disconnect()
        {
            // Se cierra la conexión con la base de datos
            connection.Close();
        }

        // Ejecuta una sentencia select sobre la base de datos
        public UserEntity executeSelect(String statement)
        {
            // Se crea una entidad de usuario vacía
            UserEntity user = null;

            // Se crea el comando MySQL
            this.command = new MySqlCommand(statement, connection);

            try
            {
                // Se ejecuta el comando MySQL
                reader = this.command.ExecuteReader();

                // Se comprueba si el comando ha devuelto alguna fila
                while (reader.Read())
                {
                    // Se cargan los valores en la entidad
                    user = new UserEntity();
                    user.Id = int.Parse(reader[0].ToString());
                    user.Name = reader[1].ToString();
                    user.Surname = reader[2].ToString();
                    user.Timestamp = reader[3].ToString();
                }
                
                // Se cierra el lector
                reader.Close();
            }
            catch (Exception e)
            {
                // Se ha producido una excepción
                MessageBox.Show("ERROR: " + e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                throw;
            }

            // Se devuelve la entidad leída de la base de datos
            return user;
        }

        // Ejecuta una sentencia select para obtener todos los usuarios
        public List<UserEntity> executeSelectAll(String statement)
        {
            // Se crea una entidad de usuario vacía
            List<UserEntity> users = new List<UserEntity>();

            // Se crea el comando MySQL
            this.command = new MySqlCommand(statement, connection);

            try
            {
                // Se ejecuta el comando MySQL
                reader = this.command.ExecuteReader();

                // Se comprueba si el comando ha devuelto alguna fila
                while (reader.Read())
                {
                    // Se cargan los valores en la entidad
                    UserEntity user = new UserEntity();
                    user.Id = int.Parse(reader[0].ToString());
                    user.Name = reader[1].ToString();
                    user.Surname = reader[2].ToString();
                    user.Timestamp = reader[3].ToString();

                    // Se añade el usuario a la lista
                    users.Add(user);
                }

                // Se cierra el lector
                reader.Close();
            }
            catch (Exception e)
            {
                // Se ha producido una excepción
                MessageBox.Show("ERROR: " + e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                throw;
            }

            // Se devuelve la entidad leída de la base de datos
            return users;
        }

        // Ejecuta una sentencia insert sobre la base de datos
        public bool executeInsert(String statement)
        {
            // Se crea el comando MySQL
            this.command = new MySqlCommand(statement, connection);

            try
            {
                // Se ejecuta el comando MySQL
                reader = this.command.ExecuteReader();
                reader.Close();
                return true;
            }
            catch (Exception e)
            {
                // Se ha producido una excepción
                MessageBox.Show("ERROR: " + e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                throw;
            }
        }

        // Ejecuta una sentencia delete sobre la base de datos
        public bool executeDelete(String statement)
        {
            // Se crea el comando MySQL
            this.command = new MySqlCommand(statement, connection);

            try
            {
                // Se ejecuta el comando MySQL
                reader = this.command.ExecuteReader();
                reader.Close();
                return true;
            }
            catch (Exception e)
            {
                // Se ha producido una excepción
                MessageBox.Show("ERROR: " + e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                throw;
            }
        }

        // Ejecuta una sentencia update sobre la base de datos
        public bool executeUpdate(String statement)
        {
            // Se crea el comando MySQL
            this.command = new MySqlCommand(statement, connection);

            try
            {
                // Se ejecuta el comando MySQL
                int number = this.command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                // Se ha producido una excepción
                MessageBox.Show("ERROR: " + e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                throw;
            }
        }
    }
}
