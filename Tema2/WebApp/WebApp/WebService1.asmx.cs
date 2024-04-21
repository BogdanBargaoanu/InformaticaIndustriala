using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.RightsManagement;
using System.Web;
using System.Web.Services;

namespace WebApp
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\InformaticaIndustriala\\Tema2\\WebApp\\Client\\Database1.mdf;Integrated Security=True";

        #region get users
        [WebMethod]
        public List<User> GetUsers()
        {
            string connectionString = this.connectionString;
            var users = new List<User>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Users";
                SqlCommand command = new SqlCommand(sql, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var user = new User
                        {
                            id = reader.GetInt32(reader.GetOrdinal("id")),
                            username = reader.GetString(reader.GetOrdinal("username")),
                            password = reader.GetString(reader.GetOrdinal("password")),
                        };

                        users.Add(user);
                    }
                }
            }

            return users;
        }
        #endregion

        #region add user
        [WebMethod]
        public bool AddUser(string username, string password)
        {
            string connectionString = this.connectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO Users (username, password) VALUES (@username, @password)";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region get tasks
        [WebMethod]
        public List<Task> GetTasks()
        {
            string connectionString = this.connectionString;
            var tasks = new List<Task>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Tasks";
                SqlCommand command = new SqlCommand(sql, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var task = new Task
                        {
                            id = reader.GetInt32(reader.GetOrdinal("id")),
                            taskName = reader.GetString(reader.GetOrdinal("taskName")),
                            description = reader.GetString(reader.GetOrdinal("description")),
                            dueDate = reader.GetDateTime(reader.GetOrdinal("dueDate")),
                            idUser = reader.GetInt32(reader.GetOrdinal("idUser")),
                        };

                        tasks.Add(task);
                    }
                }
            }

            return tasks;
        }
        #endregion

        #region get tasks by user
        [WebMethod]
        public List<Task> GetTasksByUser(int idUser)
        {
            string connectionString = this.connectionString;
            var tasks = new List<Task>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Tasks WHERE idUser = @idUser";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue(@"idUser", idUser);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var task = new Task
                        {
                            id = reader.GetInt32(reader.GetOrdinal("id")),
                            taskName = reader.GetString(reader.GetOrdinal("taskName")),
                            description = reader.GetString(reader.GetOrdinal("description")),
                            dueDate = reader.GetDateTime(reader.GetOrdinal("dueDate")),
                            idUser = reader.GetInt32(reader.GetOrdinal("idUser")),
                        };

                        tasks.Add(task);
                    }
                }
            }

            return tasks;
        }
        #endregion

        #region add task
        [WebMethod]
        public bool AddTask(string taskName, string description, DateTime dueDate, int idUser)
        {
            string connectionString = this.connectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO Tasks (taskName, description, dueDate, idUser) VALUES (@taskName, @description, @dueDate, @idUser)";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@taskName", taskName);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@dueDate", dueDate);
                    command.Parameters.AddWithValue("@idUser", idUser);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region delete task
        [WebMethod]
        public bool DeleteTask(int id)
        {
            string connectionString = this.connectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM Tasks WHERE id = @id";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region update task
        [WebMethod]
        public bool UpdateTask(int id, string taskName, string description, DateTime dueDate)
        {
            string connectionString = this.connectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "UPDATE Tasks SET taskName = @taskName, description = @description, dueDate = @dueDate WHERE id = @id";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@taskName", taskName);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@dueDate", dueDate);
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
