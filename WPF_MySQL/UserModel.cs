using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MySQL
{
    class UserModel
    {
        private DBConnection connection;

        public UserModel ()
        {
            // Obtiene una instancia del objeto de conexión a la bbdd
            this.connection = DBConnection.getInstance();

            // Inicia la conexión a la bbdd
            this.connection.connect();
        }

        // Devuelve el primer usuario de la tabla
        public UserEntity getFirstUser ()
        {
            // Se crea un objeto usuario vacío
            UserEntity user = null;

            // Se ejecuta la consulta para obtener el primer registro
            String statement = "SELECT * FROM `dummy`.`user` WHERE 1 LIMIT 1";
            user = this.connection.executeSelect(statement);

            // Se devuelve el primer registro de la base de datos
            return user;
        }

        // Devuelve todos los usuarios de la tabla
        public List<UserEntity> getAllUsers()
        {
            // Se crea una lista de usuarios vacía
            List<UserEntity> users = new List<UserEntity>();

            // Se ejecuta la consulta para obtener todos los registros
            String statement = "SELECT * FROM `dummy`.`user`";
            users = this.connection.executeSelectAll(statement);

            // Se devuelven todos los registros de la base de datos
            return users;
        }

        // Devuelve el usuario anterior
        public UserEntity getPreviousUser(String id)
        {
            // Se crea un objeto usuario vacío
            UserEntity user = null;

            // Se ejecuta la consulta para obtener el registro anterior a id
            String statement = "select * from `dummy`.`user` where id = (select max(id) from `dummy`.`user` where id < " + id + ")";
            user = this.connection.executeSelect(statement);

            // Se devuelve el registro anterior al actual (id)
            return user;
        }

        // Devuelve el siguiente usuario
        public UserEntity getNextUser(String id)
        {
            // Se crea un objeto usuario vacío
            UserEntity user = null;

            // Se ejecuta la consulta para obtener el registro siguiente a id
            String statement = "select * from `dummy`.`user` where id = (select min(id) from `dummy`.`user` where id > " + id + ")";
            user = this.connection.executeSelect(statement);

            // Se devuelve el registro siguiente al actual (id)
            return user;
        }

        public UserEntity getLastUser()
        {
            // Se crea un objeto usuario vacío
            UserEntity user = null;

            // Se ejecuta la consulta para obtener el último usuario de la tabla
            String statement = "select * from `dummy`.`user` where id = (select max(id) from `dummy`.`user`)";
            user = this.connection.executeSelect(statement);

            // Se devuelve el último usuario de la tabla
            return user;
        }

        public bool addUser(UserEntity user)
        {
            // Se ejecuta la consulta para obtener el primer registro
            String statement = "INSERT INTO `dummy`.`user` (name, surname, timestamp) VALUES ('" + user.Name + "', '" + user.Surname + "', current_timestamp());";
            return this.connection.executeInsert(statement);
        }

        public bool deleteUser(String id)
        {
            // Se ejecuta la consulta para borrar el registro
            String statement = "DELETE FROM `dummy`.`user` WHERE id = " + id + ";";
            return this.connection.executeDelete(statement);
        }

        public bool updateUser(UserEntity user)
        {
            // Se ejecuta la consulta para actualizar el registro
            String statement = "UPDATE `dummy`.`user` SET Name = '" + user.Name + "' WHERE id = " + user.Id + ";";
            bool operation1 = this.connection.executeUpdate(statement);

            statement = "UPDATE `dummy`.`user` SET Surname = '" + user.Surname + "' WHERE id = " + user.Id + ";";
            bool operation2 = this.connection.executeUpdate(statement);

            if (operation1 || operation2)
                return true;
            else 
                return false;
        }
    }
}
