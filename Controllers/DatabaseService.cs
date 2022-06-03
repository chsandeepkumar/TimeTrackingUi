using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace TimeTracking_Ui.Controllers
{
    public class DatabaseService
    {
        private object userRegistration;
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
                    {userRegistration.RoleId})";

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

                sqlCommand.CommandText = $@"update UserRegistration set CreatedDateTime='{userRegistration.CreatedDateTime}'," +
                       $"UpdatedDateTime='{userRegistration.UpdatedDateTime}'," +
                         $"Name='{userRegistration.Name}'" +
                    $"EmailAddress='{userRegistration.EmailAddress}'," +
                    $"FirstName='{userRegistration.FirstName}'," +
                    $"LastName='{userRegistration.LastName}'," +
                    $"RoleId='{userRegistration.RoleId}'," +                
                  
                    $" where Id={userRegistration.Id}";

                var upddatedRecordCount = sqlCommand.ExecuteNonQuery();
                return upddatedRecordCount;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
