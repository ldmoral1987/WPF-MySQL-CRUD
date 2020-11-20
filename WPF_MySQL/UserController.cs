using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MySQL
{
    class UserController
    {
        private UserModel model;

        public UserController (UserModel model)
        {
            this.model = model;
        }

        // Obtiene el primer usuario de la tabla
        public UserEntity getFirstUser ()
        {
            // Devuelve el primer usuario de la tabla (select)
            return this.model.getFirstUser();
        }

        // Obtiene todos los usuarios de la tabla
        public List<UserEntity> getAllUsers()
        {
            // Se devuelven todos los usuarios de la tabla (select all)
            return this.model.getAllUsers();
        }

        // Obtiene el usuario anterior
        public UserEntity getPreviousUser(String id)
        {
            // Se devuelve el usuario anterior
            return this.model.getPreviousUser(id);
        }

        // Obtiene el usuario siguiente
        public UserEntity getNextUser(String id)
        {
            // Se devuelve el usuario siguiente
            return this.model.getNextUser(id);
        }

        // Obtiene el último usuario de la tabla
        public UserEntity getLastUser()
        {
            // Se devuelve el último usuario de la tabla
            return this.model.getLastUser();
        }

        // Añade un usuario a la tabla
        public bool addUser(UserEntity user)
        {
            // Se añade el usuario a la base de datos
            return this.model.addUser(user);
        }

        // Borra un usuario de la tabla
        public bool deleteUser(String id)
        {
            // Se añade el usuario a la base de datos
            return this.model.deleteUser(id);
        }

        // Actualiza un usuario de la tabla
        public bool updateUser(UserEntity user)
        {
            // Se actualiza el usuario en la base de datos
            return this.model.updateUser(user);
        }

        // Cierra la conexión con la base de datos
        public void disconnect()
        {
            // Se cierra la conexión de la base de datos
            this.model.disconnect();
        }
    }
}
