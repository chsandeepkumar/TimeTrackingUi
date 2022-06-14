using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using TimeTracking_Ui.Models;

namespace TimeTracking_Ui.Controllers
{
    public class DatabaseService
    {
        private object userRegistration;
        private object errorlabel;
        public const string DatabaseConnectionString = @"Server=JANGAMUMA\SQLEXPRESS;Database=TimeTracking-Ui;persist security info=True;Integrated Security=SSPI;";
        public int SaveUser(UserRegistration userRegistration)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = DatabaseConnectionString;

                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = $@"Insert into UserRegistration values 
                    ({userRegistration.Id},
                    '{userRegistration.CreatedDateTime}',
                    '{userRegistration.UpdatedDateTime}',
                    '{userRegistration.Name}',
                    '{userRegistration.EmailAddress}',
                    '{userRegistration.FirstName}',
                    '{userRegistration.LastName}',
                    {userRegistration.RoleId},
                     '{userRegistration.Password}')";

                var result = cmd.ExecuteNonQuery();
                return result;
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                return -1;
            }

        }
        public List<UserRegistration> GetUser(int id)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = DatabaseConnectionString;
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = $"select * from UserRegistration where Id={id}";

                SqlDataReader result = sqlCommand.ExecuteReader();
                List<UserRegistration> userreg = new List<UserRegistration>();
                while (result.Read())
                {
                    UserRegistration userRegistration = new UserRegistration();
                    userRegistration.Id = result.GetInt32(0);
                    userRegistration.CreatedDateTime = result.GetDateTime(1);
                    userRegistration.UpdatedDateTime = result.GetDateTime(2);
                    userRegistration.Name = result.GetString(3);
                    userRegistration.EmailAddress = result.GetString(4);
                    userRegistration.FirstName = result.GetString(5);
                    userRegistration.LastName = result.GetString(6);
                    userRegistration.RoleId = result.GetInt32(7);
                    userRegistration.Password = result.GetString(8);
                    userreg.Add(userRegistration);
                }
                result.Close();

                return userreg;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateUser(UserRegistration userRegistration)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = DatabaseConnectionString;
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                sqlCommand.CommandText = $@"update UserRegistration set Id = {userRegistration.Id},
                      CreatedDateTime='{userRegistration.CreatedDateTime}',
                       UpdatedDateTime='{userRegistration.UpdatedDateTime}',
                       Name='{userRegistration.Name}',
                    EmailAddress='{userRegistration.EmailAddress}',
                    FirstName='{userRegistration.FirstName}',
                    LastName='{userRegistration.LastName}',
                    RoleId={userRegistration.RoleId},          
                   Password='{userRegistration.Password}'
                     where Id={userRegistration.Id}";

                var Count = sqlCommand.ExecuteNonQuery();
                return Count;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DeleteUser(int id)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = DatabaseConnectionString;
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = $"Delete from UserRegistration where id='{id}'";

                var var = sqlCommand.ExecuteNonQuery();
                return var;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UserLogin(Login login)
        {
            try
            {
                SqlConnection sqlConnection = new()
                {
                    ConnectionString = DatabaseConnectionString
                };
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();

                cmd.CommandText = $"select * from UserRegistration where name='{login.Name}' AND Password='{login.Password}'";

                var result = cmd.ExecuteReader();

                UserRegistration userRegistration = new UserRegistration();

                if (result.Read())
                {
                    result.Close();
                    SqlCommand sqlcmd = sqlConnection.CreateCommand();
                    sqlcmd.CommandText = $"update UserRegistration set IsActive = 1, LoggedinCreatedDateTime = '{DateTime.Now}' where Name = '{login.Name}'";
                    var result1 = sqlcmd.ExecuteNonQuery();
                    if (result1 > 0)
                    {
                        return true;
                    }
                }

                return false;

            }
            catch (Exception exception)
            {
                throw exception;

            }
        }
        public bool UserRole(Role role)
        {
            try
            {
                SqlConnection sqlConnection = new()
                {
                    ConnectionString = DatabaseConnectionString
                };
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();

                cmd.CommandText = $"select * from UserRegistration where name='{role.Roleid}' AND Password='{role.RoleName}'";

                var result = cmd.ExecuteReader();

                UserRegistration userRegistration = new UserRegistration();
                return result.Read();
            }
            catch (Exception exception)
            {
                throw exception;

            }
        }
        public bool UserLogout(Logout logout)
        {


            SqlConnection sqlConnection = new()
            {
                ConnectionString = DatabaseConnectionString
            };
            sqlConnection.Open();
            SqlCommand sqlcmd = sqlConnection.CreateCommand();

            sqlcmd.CommandText = $"update UserRegistration set IsActive = 0, LoggedoutCreatedDateTime = '{DateTime.Now}' " +
                $"where Name = '{logout.Name}'";
            var result1 = sqlcmd.ExecuteNonQuery();
            if (result1 > 0)
            {
                return true;
            }


            return false;


        }
    }
}
