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

        public UserEntity getFirstUser ()
        {
            // Devuelve el primer usuario de la tabla (select)
            return this.model.getFirstUser();
        }

        public List<UserEntity> getAllUsers()
        {
            // Se devuelven todos los usuarios de la tabla (select all)
            return this.model.getAllUsers();
        }

        public UserEntity getPreviousUser(String id)
        {
            // Se devuelve el usuario anterior
            return this.model.getPreviousUser(id);
        }

        public UserEntity getNextUser(String id)
        {
            // Se devuelve el usuario siguiente
            return this.model.getNextUser(id);
        }

        public UserEntity getLastUser()
        {
            // Se devuelve el último usuario de la tabla
            return this.model.getLastUser();
        }

        public bool addUser(UserEntity user)
        {
            // Se añade el usuario a la base de datos
            return this.model.addUser(user);
        }

        public bool deleteUser(String id)
        {
            // Se añade el usuario a la base de datos
            return this.model.deleteUser(id);
        }

        public bool updateUser(UserEntity user)
        {
            // Se actualiza el usuario en la base de datos
            return this.model.updateUser(user);
        }
    }
}
