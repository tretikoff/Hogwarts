using System;
using SQLite;

namespace SignUp
{
    [Table("User")]
    public class User
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public override bool Equals(object obj)
        {
            return obj is User user && (UserName == user.UserName && Password == user.Password);
        }
    }
}