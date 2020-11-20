using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MySQL
{
    public class UserEntity
    {
        private int id;
        private String name;
        private String surname;
        private String timestamp;

        public UserEntity()
        {

        }

        public UserEntity(int id, String name, String surname, String timestamp)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Timestamp = timestamp;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Timestamp { get => timestamp; set => timestamp = value; }


        public string toString ()
        {
            return Id + " - " + Name + " - " + Surname + " - " + Timestamp;
        }
    }
}
