using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SW_ConsultingAttendenceApp_FirstTrial_.Models
{
    public static class clsUsersData
    {




        public static string _connectionString = "Data Source=DESKTOP-9OCPFRQ;Initial Catalog=AttendanceAppDB;Integrated Security=True;Encrypt=False";


        // Method to get a list of users
        public static List<clsUser> GetUsers()
        {
            var users = new List<clsUser>();
             string query = "SELECT UserID, Firstname, Lastname, Age, Email, Phone, Username, Password, RoleID, DepartmentID FROM Users";

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
                                    UserID = reader.GetInt32(0),
                                    Firstname = reader.GetString(1),
                                    Lastname = reader.GetString(2),
                                    Age = reader.GetInt32(3),
                                    Email = reader.GetString(4),
                                    Phone = reader.GetString(5),
                                    Username = reader.IsDBNull(6) ? null : reader.GetString(6),
                                    Password = reader.IsDBNull(7) ? null : reader.GetString(7),
                                    RoleID = reader.GetInt32(8),
                                    DepartmentID = reader.GetInt32(9)
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
        //public static bool UpdateUser(clsUser user)
        //{
        //    string query = "UPDATE Users SET Firstname = @Firstname," +
        //        "Lastname = @Lastname, Age = @Age, Email = @Email," +
        //        "Phone = @Phone, Username = @Username, Password = @Password, DepartmentID = @DepartmentID WHERE UserID = @UserID";

        //    using (SqlConnection connection = new SqlConnection(_connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();

        //            using (SqlCommand command = new SqlCommand(query, connection))
        //            {
        //                command.Parameters.AddWithValue("@UserID", user.UserID);
        //                command.Parameters.AddWithValue("@Firstname", user.Firstname);
        //                command.Parameters.AddWithValue("@Lastname", user.Lastname);
        //                command.Parameters.AddWithValue("@Age", user.Age);
        //                command.Parameters.AddWithValue("@Email", user.Email);
        //                command.Parameters.AddWithValue("@Username", user.Username);
        //                command.Parameters.AddWithValue("@Password", user.Password);
        //                command.Parameters.AddWithValue("@Phone", user.Phone);
        //                command.Parameters.AddWithValue("@DepartmentID", user.DepartmentID);
        //                int rowsAffected = command.ExecuteNonQuery();
        //                return rowsAffected > 0;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            // Handle exceptions (log them, rethrow them, etc.)
        //            MessageBox.Show ("An error occurred: " + ex.Message);
        //            return false;
        //        }
        //    }
        //}

        public static bool UpdateUser(clsUser user, bool skipUsername = false, bool skipPassword = false)
        {
            // Build the base query
            string query = "UPDATE Users SET Firstname = @Firstname, " +
                "Lastname = @Lastname, Age = @Age, Email = @Email, " +
                "Phone = @Phone, DepartmentID = @DepartmentID";

            // Add optional fields
            if (!skipUsername)
            {
                query += ", Username = @Username";
            }
            if (!skipPassword)
            {
                query += ", Password = @Password";
            }

            // Complete the query
            query += " WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", user.UserID);
                        command.Parameters.AddWithValue("@Firstname", user.Firstname);
                        command.Parameters.AddWithValue("@Lastname", user.Lastname);
                        command.Parameters.AddWithValue("@Age", user.Age);
                        command.Parameters.AddWithValue("@Email", user.Email);
                        command.Parameters.AddWithValue("@Phone", user.Phone);
                        command.Parameters.AddWithValue("@DepartmentID", user.DepartmentID);

                        if (!skipUsername)
                        {
                            command.Parameters.AddWithValue("@Username", user.Username);
                        }
                        if (!skipPassword)
                        {
                            command.Parameters.AddWithValue("@Password", user.Password);
                        }

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions (log them, rethrow them, etc.)
                    MessageBox.Show("An error occurred: " + ex.Message);
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
        public static bool AddUser(clsUser NewUser)
        {
            string query = "INSERT INTO Users (Firstname, Lastname, Age, Email, Phone, RoleID, DepartmentID) " +
                "VALUES (@Firstname, @Lastname, @Age, @Email, @Phone, @RoleID, @DepartmentID)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Firstname", NewUser.Firstname);
                        command.Parameters.AddWithValue("@Lastname", NewUser.Lastname);
                        command.Parameters.AddWithValue("@Age", NewUser.Age);
                        command.Parameters.AddWithValue("@Email", NewUser.Email);
                        command.Parameters.AddWithValue("@Phone", NewUser.Phone);
                        command.Parameters.AddWithValue("@RoleID", 2);
                        command.Parameters.AddWithValue("@DepartmentID", NewUser.DepartmentID);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; // Returns true if a row was inserted
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
        public static clsUser GetUserByUsernameAndPassword(string username, string password)
        {
            clsUser user = null;

            string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    user = new clsUser
                    {
                        UserID = Convert.ToInt32(reader["UserID"]),
                        Firstname = reader["Firstname"].ToString(),
                        Lastname = reader["Lastname"].ToString(),
                        Age = Convert.ToInt32(reader["Age"].ToString()),
                        Email = reader["Email"].ToString(),
                        Username = reader["Username"].ToString(),
                        RoleID = Convert.ToInt32(reader["RoleID"]),
                        DepartmentID = Convert.ToInt32(reader["DepartmentID"])
                    };
                }

                reader.Close();
            }

            return user;
        }
        public static clsUser GetUserByEmail(string email)
        {
            clsUser user = null;

            string query = "SELECT * FROM Users WHERE Email = @Email";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    user = new clsUser
                    {
                        UserID = Convert.ToInt32(reader["UserID"]),
                        Firstname = reader["Firstname"].ToString(),
                        Lastname = reader["Lastname"].ToString(),
                        Age = Convert.ToInt32(reader["Age"].ToString()),
                        Email = reader["Email"].ToString(),
                        Username = reader["Username"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        RoleID = Convert.ToInt32(reader["RoleID"]),
                        DepartmentID = Convert.ToInt32(reader["DepartmentID"])
                    };
                }

                reader.Close();
            }

            return user;
        }
        public static clsUser GetUserByFullName(string firstname, string lastname)
        {
            clsUser user = null;

            string query = "SELECT * FROM Users WHERE Firstname = @Firstname AND Lastname = @Lastname";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Firstname", firstname);
                command.Parameters.AddWithValue("@Lastname", lastname);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    user = new clsUser
                    {
                        UserID = Convert.ToInt32(reader["UserID"]),
                        Firstname = reader["Firstname"].ToString(),
                        Lastname = reader["Lastname"].ToString(),
                        Age = Convert.ToInt32(reader["Age"]),
                        Phone = reader["Phone"].ToString(),
                        Email = reader["Email"].ToString(),
                        Username = reader["Username"].ToString(),
                        RoleID = Convert.ToInt32(reader["RoleID"]),
                        DepartmentID = Convert.ToInt32(reader["DepartmentID"])
                    };

                }

                reader.Close();
            }

            return user;
        }

        public static clsUser GetUserByID(int userID)
        {
            clsUser user = null;
            string query = "SELECT UserID, Firstname, Lastname, Age, Email, Phone, Username, Password, DepartmentID, RoleID FROM Users WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new clsUser
                                {
                                    UserID = reader.GetInt32(0),
                                    Firstname = reader.GetString(1),
                                    Lastname = reader.GetString(2),
                                    Age = reader.GetInt32(3),
                                    Email = reader.GetString(4),
                                    Phone = reader.GetString(5),
                                    Username = reader.IsDBNull(6) ? null : reader.GetString(6),
                                    Password = reader.IsDBNull(7) ? null : reader.GetString(7),
                                    DepartmentID = reader.GetInt32(8),
                                    RoleID = reader.GetInt32(9)
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            return user;
        }

        public static int GetNumberOfEmployees()
        {
            int NumberOfEmployees = 0;
            string query = "SELECT Count(UserID) FROM Users WHERE RoleID = 2";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Execute the query and get the count
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int count))
                        {
                            NumberOfEmployees = count;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
            return NumberOfEmployees;
        }

        public static int GetActiveEmployeeCount()
        {
            int activeCount = 0;

            string query = @"
        SELECT COUNT(DISTINCT a.UserID)
        FROM Attendances a
        JOIN Users u ON a.UserID = u.UserID
        WHERE (a.MorningCheckIn IS NOT NULL OR a.EveningCheckIn IS NOT NULL)
          --AND a.Request IS NULL
          AND a.Date = @TodayDate";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TodayDate", DateTime.Today.Date);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int count))
                        {
                            activeCount = count;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            return activeCount;
        }
        public static int GetAbsentEmployeeCount()
        {
            int absentCount = 0;

            string query = @"
        SELECT COUNT(u.UserID)
        FROM Users u
        LEFT JOIN Attendances a ON u.UserID = a.UserID AND a.Date = @TodayDate
        WHERE u.RoleID = 2
          AND (a.MorningCheckIn IS NULL AND a.EveningCheckIn IS NULL)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TodayDate", DateTime.Today.Date);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int count))
                        {
                            absentCount = count;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            return absentCount;
        }

        public static bool SaveMorningCheckIn(int userId, DateTime date, DateTime morningCheckIn)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if the UserID exists in the Users table
                    string userCheckQuery = "SELECT COUNT(*) FROM Users WHERE UserID = @UserID";
                    using (SqlCommand userCheckCommand = new SqlCommand(userCheckQuery, connection))
                    {
                        userCheckCommand.Parameters.AddWithValue("@UserID", userId);
                        int userCount = (int)userCheckCommand.ExecuteScalar();

                        if (userCount == 0)
                        {
                            throw new Exception("UserID does not exist in the Users table.");
                        }
                    }

                    // Check if the attendance record exists
                    string checkQuery = "SELECT COUNT(*) FROM Attendances WHERE UserID = @UserID AND Date = @Date";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@UserID", userId);
                        checkCommand.Parameters.AddWithValue("@Date", date.Date);

                        int recordCount = (int)checkCommand.ExecuteScalar();

                        if (recordCount > 0)
                        {
                            // Update the existing record
                            string updateQuery = "UPDATE Attendances SET MorningCheckIn = @MorningCheckIn, Request = @Request WHERE UserID = @UserID AND Date = @Date";
                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@UserID", userId);
                                updateCommand.Parameters.AddWithValue("@Date", date.Date);
                                updateCommand.Parameters.AddWithValue("@MorningCheckIn", morningCheckIn);
                                updateCommand.Parameters.AddWithValue("@Request", 0); // Set Request to 0

                                int rowsAffected = updateCommand.ExecuteNonQuery();
                                return rowsAffected > 0;
                            }
                        }
                        else
                        {
                            // Insert a new record
                            string insertQuery = "INSERT INTO Attendances (UserID, Date, MorningCheckIn, Request) VALUES (@UserID, @Date, @MorningCheckIn, @Request)";
                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@UserID", userId);
                                insertCommand.Parameters.AddWithValue("@Date", date.Date);
                                insertCommand.Parameters.AddWithValue("@MorningCheckIn", morningCheckIn);
                                insertCommand.Parameters.AddWithValue("@Request", 0); // Set Request to 0

                                int rowsAffected = insertCommand.ExecuteNonQuery();
                                return rowsAffected > 0;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }


        public static bool SaveMorningCheckOut(int userId, DateTime date, DateTime morningCheckOut)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if the UserID exists in the Users table
                    string userCheckQuery = "SELECT COUNT(*) FROM Users WHERE UserID = @UserID";
                    using (SqlCommand userCheckCommand = new SqlCommand(userCheckQuery, connection))
                    {
                        userCheckCommand.Parameters.AddWithValue("@UserID", userId);

                        int userCount = (int)userCheckCommand.ExecuteScalar();

                        if (userCount == 0)
                        {
                            throw new Exception("UserID does not exist in the Users table.");
                        }
                    }

                    // Check if the attendance record exists
                    string checkQuery = "SELECT COUNT(*) FROM Attendances WHERE UserID = @UserID AND Date = @Date";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@UserID", userId);
                        checkCommand.Parameters.AddWithValue("@Date", date.Date);

                        int recordCount = (int)checkCommand.ExecuteScalar();

                        if (recordCount > 0)
                        {
                            // Update the existing record
                            string updateQuery = "UPDATE Attendances SET MorningCheckOut = @MorningCheckOut WHERE UserID = @UserID AND Date = @Date";
                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@UserID", userId);
                                updateCommand.Parameters.AddWithValue("@Date", date.Date);
                                updateCommand.Parameters.AddWithValue("@MorningCheckOut", morningCheckOut);
                             //   updateCommand.Parameters.AddWithValue("@Request", 0); // Set Request to 0

                                int rowsAffected = updateCommand.ExecuteNonQuery();
                                return rowsAffected > 0;
                            }
                        }
                        else
                        {
                            // Insert a new record
                            string insertQuery = "INSERT INTO Attendances (UserID, Date, MorningCheckOut) VALUES (@UserID, @Date, @MorningCheckOut)";
                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@UserID", userId);
                                insertCommand.Parameters.AddWithValue("@Date", date.Date);
                                insertCommand.Parameters.AddWithValue("@MorningCheckOut", morningCheckOut);
                             //   insertCommand.Parameters.AddWithValue("@Request", 0); // Set Request to 0

                                int rowsAffected = insertCommand.ExecuteNonQuery();
                                return rowsAffected > 0;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }
        public static bool SaveEveningCheckIn(int userId, DateTime date, DateTime eveningCheckIn)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if the UserID exists in the Users table
                    string userCheckQuery = "SELECT COUNT(*) FROM Users WHERE UserID = @UserID";
                    using (SqlCommand userCheckCommand = new SqlCommand(userCheckQuery, connection))
                    {
                        userCheckCommand.Parameters.AddWithValue("@UserID", userId);

                        int userCount = (int)userCheckCommand.ExecuteScalar();

                        if (userCount == 0)
                        {
                            throw new Exception("UserID does not exist in the Users table.");
                        }
                    }

                    // Check if the attendance record exists
                    string checkQuery = "SELECT COUNT(*) FROM Attendances WHERE UserID = @UserID AND Date = @Date";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@UserID", userId);
                        checkCommand.Parameters.AddWithValue("@Date", date.Date);

                        int recordCount = (int)checkCommand.ExecuteScalar();

                        if (recordCount > 0)
                        {
                            // Update the existing record
                            string updateQuery = "UPDATE Attendances SET EveningCheckIn = @EveningCheckIn WHERE UserID = @UserID AND Date = @Date";
                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@UserID", userId);
                                updateCommand.Parameters.AddWithValue("@Date", date.Date);
                                updateCommand.Parameters.AddWithValue("@EveningCheckIn", eveningCheckIn);
                              //  updateCommand.Parameters.AddWithValue("@Request", 0); // Set Request to 0

                                int rowsAffected = updateCommand.ExecuteNonQuery();
                                return rowsAffected > 0;
                            }
                        }
                        else
                        {
                            // Insert a new record
                            string insertQuery = "INSERT INTO Attendances (UserID, Date, EveningCheckIn) VALUES (@UserID, @Date, @EveningCheckIn)";
                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@UserID", userId);
                                insertCommand.Parameters.AddWithValue("@Date", date.Date);
                                insertCommand.Parameters.AddWithValue("@EveningCheckIn", eveningCheckIn);
                             //   insertCommand.Parameters.AddWithValue("@Request", 0); // Set Request to 0

                                int rowsAffected = insertCommand.ExecuteNonQuery();
                                return rowsAffected > 0;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }

        public static bool SaveEveningCheckOut(int userId, DateTime date, DateTime eveningCheckOut)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if the UserID exists in the Users table
                    string userCheckQuery = "SELECT COUNT(*) FROM Users WHERE UserID = @UserID";
                    using (SqlCommand userCheckCommand = new SqlCommand(userCheckQuery, connection))
                    {
                        userCheckCommand.Parameters.AddWithValue("@UserID", userId);

                        int userCount = (int)userCheckCommand.ExecuteScalar();

                        if (userCount == 0)
                        {
                            throw new Exception("UserID does not exist in the Users table.");
                        }
                    }

                    // Check if the attendance record exists
                    string checkQuery = "SELECT COUNT(*) FROM Attendances WHERE UserID = @UserID AND Date = @Date";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@UserID", userId);
                        checkCommand.Parameters.AddWithValue("@Date", date.Date);

                        int recordCount = (int)checkCommand.ExecuteScalar();

                        if (recordCount > 0)
                        {
                            // Update the existing record
                            string updateQuery = "UPDATE Attendances SET EveningCheckOut = @EveningCheckOut WHERE UserID = @UserID AND Date = @Date";
                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@UserID", userId);
                                updateCommand.Parameters.AddWithValue("@Date", date.Date);
                                updateCommand.Parameters.AddWithValue("@EveningCheckOut", eveningCheckOut);
                             //   updateCommand.Parameters.AddWithValue("@Request", 0); // Set Request to 0

                                int rowsAffected = updateCommand.ExecuteNonQuery();
                                return rowsAffected > 0;
                            }
                        }
                        else
                        {
                            // Insert a new record
                            string insertQuery = "INSERT INTO Attendances (UserID, Date, EveningCheckOut) VALUES (@UserID, @Date, @EveningCheckOut)";
                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@UserID", userId);
                                insertCommand.Parameters.AddWithValue("@Date", date.Date);
                                insertCommand.Parameters.AddWithValue("@EveningCheckOut", eveningCheckOut);
                             //   insertCommand.Parameters.AddWithValue("@Request", 0); // Set Request to 0

                                int rowsAffected = insertCommand.ExecuteNonQuery();
                                return rowsAffected > 0;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }
        public static void LoadAllAttendanceEvents(int userId, DateTime date, out DateTime? morningCheckIn, out DateTime? morningCheckOut, out DateTime? eveningCheckIn, out DateTime? eveningCheckOut)
        {
            // Initialize output parameters to null
            morningCheckIn = null;
            morningCheckOut = null;
            eveningCheckIn = null;
            eveningCheckOut = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL query to retrieve all attendance times for a specific user and date
                    string query = "SELECT MorningCheckIn, MorningCheckOut, EveningCheckIn, EveningCheckOut FROM Attendances WHERE UserID = @UserID AND Date = @Date";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        command.Parameters.AddWithValue("@Date", date.Date);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve all attendance times, allowing for nulls
                                morningCheckIn = reader["MorningCheckIn"] as DateTime?;
                                morningCheckOut = reader["MorningCheckOut"] as DateTime?;
                                eveningCheckIn = reader["EveningCheckIn"] as DateTime?;
                                eveningCheckOut = reader["EveningCheckOut"] as DateTime?;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading attendance: " + ex.Message);
                }
            }
        }
        public static DataTable GetEmployeeAttendance()
        {
            DataTable dataTable = new DataTable();

            string query = @"
        SELECT 
            u.Firstname, 
            u.Lastname, 
            a.MorningCheckIn,
            a.Request
        FROM 
            Users u
        INNER JOIN 
            Attendances a ON u.UserID = a.UserID
        WHERE 
            u.RoleID = 2 
            AND CONVERT(date, a.Date) = CONVERT(date, GETDATE())"; // Assuming RoleID = 2 is for employees

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return dataTable;
        }


        public static void UpdateRequestStatus(string firstname, string lastname, int requestStatus)
        {
            string query = @"
        UPDATE 
            Attendances
        SET 
            Request = @Request
        WHERE 
            UserID = (SELECT UserID FROM Users WHERE Firstname = @Firstname AND Lastname = @Lastname)
        AND 
            Date = CAST(GETDATE() AS DATE)"; // Update only for today's date

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Request", requestStatus);
                        command.Parameters.AddWithValue("@Firstname", firstname);
                        command.Parameters.AddWithValue("@Lastname", lastname);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        public static bool GetCheckInRequestStatus(int userId, DateTime date)
        {
            string query = @"
            SELECT Request
            FROM Attendances
            WHERE UserID = @UserID AND Date = @Date";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        command.Parameters.AddWithValue("@Date", date.Date);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            return (bool)result;
                        }
                        else
                        {
                            // Handle the case where no record is found
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }
        //        public static DataTable LoadUserAttendanceReport(int userId, string reportType, DateTime? startDate = null, DateTime? endDate = null)
        //        {
        //            DataTable dataTable = new DataTable();

        //            // Determine the date range based on the report type
        //            DateTime reportStartDate;
        //            DateTime reportEndDate;

        //            switch (reportType.ToLower())
        //            {
        //                case "daily":
        //                    reportStartDate = DateTime.Today;
        //                    reportEndDate = DateTime.Today;
        //                    break;
        //                case "weekly":
        //                    reportStartDate = DateTime.Today.AddDays(-((int)DateTime.Today.DayOfWeek + 7)); // Last week
        //                    reportEndDate = DateTime.Today.AddDays(-((int)DateTime.Today.DayOfWeek + 1));   // End of last week
        //                    break;
        //                case "monthly":
        //                    reportStartDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month - 1, 1); // First day of last month
        //                    reportEndDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddDays(-1); // Last day of last month
        //                    break;
        //                case "range":
        //                    if (startDate.HasValue && endDate.HasValue)
        //                    {
        //                        reportStartDate = startDate.Value;
        //                        reportEndDate = endDate.Value;
        //                    }
        //                    else
        //                    {
        //                        throw new ArgumentException("Start date and end date must be provided for a date range report.");
        //                    }
        //                    break;
        //                default:
        //                    throw new ArgumentException("Invalid report type specified.");
        //            }

        //            // SQL Query to fetch user attendance data within the specified date range, excluding weekends and holidays
        //            string query = @"SELECT 
        //    u.Firstname, 
        //    u.Lastname, 
        //    a.Date,
        //    a.MorningCheckIn,
        //    a.EveningCheckOut,
        //    DATEDIFF(HOUR, a.MorningCheckIn, a.MorningCheckOut) + DATEDIFF(HOUR, a.EveningCheckIn, a.EveningCheckOut) AS TotalHoursWorked
        //FROM 
        //    Users u
        //INNER JOIN 
        //    Attendances a ON u.UserID = a.UserID
        //LEFT JOIN 
        //    Holidays h ON a.Date = h.HolidayDate
        //WHERE 
        //    u.UserID = @UserID AND
        //    a.Date BETWEEN @StartDate AND @EndDate AND
        //    DATENAME(WEEKDAY, a.Date) NOT IN ('Saturday', 'Sunday') AND
        //    h.HolidayDate IS NULL
        //ORDER BY 
        //    a.Date;
        //";

        //            using (SqlConnection connection = new SqlConnection(_connectionString))
        //            {
        //                try
        //                {
        //                    connection.Open();
        //                    using (SqlCommand command = new SqlCommand(query, connection))
        //                    {
        //                        command.Parameters.AddWithValue("@UserID", userId);
        //                        command.Parameters.AddWithValue("@StartDate", reportStartDate);
        //                        command.Parameters.AddWithValue("@EndDate", reportEndDate);

        //                        SqlDataAdapter adapter = new SqlDataAdapter(command);
        //                        adapter.Fill(dataTable);
        //                    }
        //                }
        //                catch (Exception ex)
        //                {
        //                    // Log or handle the exception as appropriate
        //                    MessageBox.Show("An error occurred: " + ex.Message);
        //                }
        //            }

        //            return dataTable;
        //        }

        //    public static DataTable LoadUserAttendanceReport(int userId, string reportType, DateTime? startDate = null, DateTime? endDate = null)
        //    {
        //        DataTable dataTable = new DataTable();

        //        // Determine the date range based on the report type
        //        DateTime reportStartDate;
        //        DateTime reportEndDate;

        //        switch (reportType.ToLower())
        //        {
        //            case "daily":
        //                reportStartDate = DateTime.Today;
        //                reportEndDate = DateTime.Today;
        //                break;
        //            case "weekly":
        //                reportStartDate = DateTime.Today.AddDays(-((int)DateTime.Today.DayOfWeek + 6)); // Last Monday
        //                reportEndDate = reportStartDate.AddDays(6); // End of that week (Sunday)
        //                break;
        //            case "monthly":
        //                reportStartDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-1); // First day of last month
        //                reportEndDate = reportStartDate.AddMonths(1).AddDays(-1); // Last day of last month
        //                break;
        //            case "range":
        //                if (startDate.HasValue && endDate.HasValue)
        //                {
        //                    reportStartDate = startDate.Value;
        //                    reportEndDate = endDate.Value;
        //                }
        //                else
        //                {
        //                    throw new ArgumentException("Start date and end date must be provided for a date range report.");
        //                }
        //                break;
        //            default:
        //                throw new ArgumentException("Invalid report type specified.");
        //        }

        //        // SQL Query to fetch user attendance data within the specified date range, excluding weekends and holidays
        //        string query = @"SELECT 
        //    u.Firstname, 
        //    u.Lastname, 
        //    a.Date,
        //    a.MorningCheckIn,
        //    a.EveningCheckOut,
        //    DATEDIFF(MINUTE, a.MorningCheckIn, a.MorningCheckOut) / 60.0 + 
        //    DATEDIFF(MINUTE, a.EveningCheckIn, a.EveningCheckOut) / 60.0 AS TotalHoursWorked
        //FROM 
        //    Users u
        //INNER JOIN 
        //    Attendances a ON u.UserID = a.UserID
        //LEFT JOIN 
        //    Holidays h ON a.Date = h.HolidayDate
        //WHERE 
        //    u.UserID = @UserID AND
        //    a.Date BETWEEN @StartDate AND @EndDate AND
        //    DATEPART(WEEKDAY, a.Date) NOT IN (1, 7) AND
        //    h.HolidayDate IS NULL
        //ORDER BY 
        //    a.Date;
        //";

        //        using (SqlConnection connection = new SqlConnection(_connectionString))
        //        {
        //            try
        //            {
        //                connection.Open();
        //                using (SqlCommand command = new SqlCommand(query, connection))
        //                {
        //                    command.Parameters.AddWithValue("@UserID", userId);
        //                    command.Parameters.AddWithValue("@StartDate", reportStartDate);
        //                    command.Parameters.AddWithValue("@EndDate", reportEndDate);

        //                    SqlDataAdapter adapter = new SqlDataAdapter(command);
        //                    adapter.Fill(dataTable);
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                // Log or handle the exception as appropriate
        //                MessageBox.Show("An error occurred: " + ex.Message);
        //            }
        //        }

        //        return dataTable;
        //    }

        public static DataTable LoadUserAttendanceReport(int userId, string reportType, DateTime? startDate = null, DateTime? endDate = null)
        {
            DataTable dataTable = new DataTable();

            // Determine the date range based on the report type
            DateTime reportStartDate;
            DateTime reportEndDate;

            switch (reportType.ToLower())
            {
                case "daily":
                    reportStartDate = DateTime.Today;
                    reportEndDate = DateTime.Today;
                    break;
                case "weekly":
                    reportStartDate = DateTime.Today.AddDays(-((int)DateTime.Today.DayOfWeek + 6)); // Last Monday
                    reportEndDate = reportStartDate.AddDays(6); // End of that week (Sunday)
                    break;
                case "monthly":
                    reportStartDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-1); // First day of last month
                    reportEndDate = reportStartDate.AddMonths(1).AddDays(-1); // Last day of last month
                    break;
                case "range":
                    if (startDate.HasValue && endDate.HasValue)
                    {
                        reportStartDate = startDate.Value;
                        reportEndDate = endDate.Value;
                    }
                    else
                    {
                        throw new ArgumentException("Start date and end date must be provided for a date range report.");
                    }
                    break;
                default:
                    throw new ArgumentException("Invalid report type specified.");
            }

            string query = @"WITH DateRange AS (
        SELECT CAST(@StartDate AS DATE) AS [Date]
        UNION ALL
        SELECT DATEADD(DAY, 1, [Date])
        FROM DateRange
        WHERE DATEADD(DAY, 1, [Date]) <= @EndDate
    )
    SELECT 
        dr.[Date],
        u.Firstname, 
        u.Lastname, 
        a.MorningCheckIn,
        a.MorningCheckOut,
        a.EveningCheckIn,
        a.EveningCheckOut,
        CASE 
            WHEN dr.[Date] < CAST(GETDATE() AS DATE) AND a.UserID IS NULL THEN 'Absent'
            WHEN dr.[Date] >= CAST(GETDATE() AS DATE) AND a.UserID IS NULL THEN 'Not yet'
            ELSE 'Present'
        END AS AttendanceStatus,
        DATEDIFF(MINUTE, a.MorningCheckIn, a.MorningCheckOut) / 60.0 + 
        DATEDIFF(MINUTE, a.EveningCheckIn, a.EveningCheckOut) / 60.0 AS TotalHoursWorked
    FROM 
        DateRange dr
    LEFT JOIN 
        Attendances a ON dr.[Date] = a.Date AND a.UserID = @UserID
    LEFT JOIN 
        Users u ON u.UserID = @UserID
    LEFT JOIN 
        Holidays h ON dr.[Date] = h.HolidayDate
    WHERE 
        DATEPART(WEEKDAY, dr.[Date]) NOT IN (1, 7) -- Exclude weekends
        AND h.HolidayDate IS NULL -- Exclude holidays
    ORDER BY 
        dr.[Date];";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        command.Parameters.AddWithValue("@StartDate", reportStartDate);
                        command.Parameters.AddWithValue("@EndDate", reportEndDate);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    // Log or handle the exception as appropriate
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return dataTable;
        }



        public static void AutoCheckoutMissingEntries()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("AutoCheckoutMissingEntries", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} records updated with auto-checkout.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception as needed, you could log this to a file or display a message box in a desktop application.
                    MessageBox.Show("An error occurred while performing auto-checkout: " + ex.Message);
                }
            }
        }





    }




}


