using Dapper;
using Inventory.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.Models
{
    public class Session
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public long Start { set; get; }
        public long End { set; get; }
        public string Username { set; get; }

        private MySqlConnection connection;

        public Session()
        { }

        public Session(string name, long start, long end, string username)
        {
            Name = name;
            Start = start;
            End = end;
            Username = username;
            connection = new DBConnection().GetConnection();
        }

        public int insertSession()
        {
            string query = 
                $"INSERT INTO `sessions`(`Name`, `Start`, `End`, `Username`) " +
                $"VALUES ('{Name}','{Start}','{End}','{Username}')";
            return connection.Execute(query);
        }

        public int updateSession()
        {
            string query = $"UPDATE `sessions` SET `Name`='{Name}',`Start`='{Start}',`End`='{End}',`Username`='{Username}' WHERE `Id`='{Id}'";
            return connection.Execute(query);
        }

        public static Session getSessionById(int id)
        {
            MySqlConnection connection = new DBConnection().GetConnection();
            try
            {
                return connection.QueryFirst<Session>($"SELECT * FROM sessions where Id='{id}'");
            }
            catch (InvalidOperationException ex)
            {
                return null;
            }
        }

        public static List<Session> GetAllSessions()
        {
            MySqlConnection connection = new DBConnection().GetConnection();
            string query = "SELECT * FROM sessions";
            return connection.Query<Session>(query).ToList();
        }

        public static int DeleteSession(Session session)
        {
            MySqlConnection connection = new DBConnection().GetConnection();
            string query = $"DELETE FROM sessions WHERE Id={session.Id}";
            return connection.Execute(query);
        }
    }
}

