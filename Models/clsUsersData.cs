using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SW_ConsultingAttendenceApp_FirstTrial_.Models
{
    public static class clsUsersData
    {




        public static string _connectionString = "Data Source=DESKTOP-9OCPFRQ;Initial Catalog=AttendanceAppDB;Integrated Security=True;Encrypt=False";


        // Method to get a list of users
        public static List<clsUser> GetUsers()
        {
            var users = new List<clsUser>();
            string query = "SELECT UserID, UserName, Email FROM Users";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var user = new clsUser
                                {
                                    UserID = reader.GetInt32(0), // Assuming UserID is an integer
                                    Firstname = reader.GetString(1),
                                    Lastname = reader.GetString(2),
                                    Email = reader.GetString(3),
                                    PhoneNumber = reader.GetString(4),
                                    Username = reader.GetString(5),
                                    Password = reader.GetString(6),
                                    RoleID = reader.GetInt32(8),
                                };
                                users.Add(user);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions (log them, rethrow them, etc.)
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            return users;
        }

        // Method to update a user's details
        public static bool UpdateUser(clsUser user)
        {
            string query = "UPDATE Users SET Firstname = @Firstname," +
                "Lastname = @Lastname, Age = @Age, Email = @Email," +
                "Phone = @Phone, DepartmentID = @DepartmentID WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Firstname", user.Firstname);
                        command.Parameters.AddWithValue("@Lastname", user.Lastname);
                        command.Parameters.AddWithValue("@Age", user.Age);
                        command.Parameters.AddWithValue("@Email", user.Email);
                        command.Parameters.AddWithValue("@Phone", user.PhoneNumber);
                        command.Parameters.AddWithValue("@DepartmentID", user.DepartmentID);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions (log them, rethrow them, etc.)
                    Console.WriteLine("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }


        public static bool DeleteUser(int userID)
        {
            string query = "DELETE FROM Users WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; // Returns true if a row was deleted
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions (log them, rethrow them, etc.)
                    Console.WriteLine("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }
    }

}


