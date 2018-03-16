using System;
using System.Collections.Generic;
using SQLite;
using System.IO;
using System.Linq;

namespace SignUp
{
    public class UserStorageService
    {
        private readonly SQLiteConnection _connection;
        private const string SqliteFilename = "users.db";

        public UserStorageService()
        {
            var databasePath = Path.Combine(Directory.GetCurrentDirectory(), SqliteFilename);
            _connection = new SQLiteConnection(databasePath);
            _connection.CreateTable<User>();
        }

        public int CreateUser(User user)
        {
            Console.WriteLine("Using");
            if (user.Id != 0)
            {
                _connection.Update(user);
                return user.Id;
            }
            else
            {
                return _connection.Insert(user);
            }
        }

        public int DeleteUser(int id)
        {
            return _connection.Delete<User>(id);
        }

        public IEnumerable<User> GetUsers()
        {
            return (from i in _connection.Table<User>() select i).ToList();
        }

        public User FindUserByName(string username)
        {
            var query = from user in _connection.Table<User>()
                where user.UserName == username
                select user;
            return query.First();
        }
    }
}