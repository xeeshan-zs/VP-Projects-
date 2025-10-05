using System.Data.SqlClient;

namespace DataBase;
public class sql
{
    string connectionString =
        "Server=localhost;Database=uni;Trusted_Connection=True;Encrypt=False;";

    public bool insert(String id, String name)
    {
        int Id = Convert.ToInt32(id);
        string query = "INSERT INTO employee (ID, Name) VALUES (@ID, @Name)";
        
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Name", name);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            return false;
        }
        
    }
    public bool update(String id, String name)
    {
        int Id = Convert.ToInt32(id);
        string query = "UPDATE employee SET Name = @Name WHERE ID = @ID";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Name", name);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            return false;
        }
    }
    
    public bool delete(String id)
    {
        int Id = Convert.ToInt32(id);
        string query = "DELETE FROM employee WHERE ID = @ID";
        
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            return false;
        }
    }
    
    public  String search (String id)
    {
        int Id = Convert.ToInt32(id);
        string query = "SELECT Name FROM employee WHERE ID = @ID";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        return null; 
                    }
                }
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public bool insert(String id, String name, String address, string gender)
    {
        int Id = Convert.ToInt32(id);
        string query = "INSERT INTO employee (ID, Name, Address, Gender) VALUES (@ID, @Name, @Address, @Gender)";
        
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Gender", gender);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            return false;
        }

        
    }
    
    public bool update(String id, String name, String address, string gender)
    {
        int Id = Convert.ToInt32(id);
        string query = "UPDATE employee SET Name = @Name, Address = @Address, Gender = @Gender WHERE ID = @ID";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Gender", gender);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public String[] search_a(String id)
    {
        int Id = Convert.ToInt32(id);
        string query = "SELECT Name, Address, Gender FROM employee WHERE ID = @ID";
        String[] employeeData = new String[3];

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employeeData[0] = reader["Name"].ToString();
                            employeeData[1] = reader["Address"].ToString();
                            employeeData[2] = reader["Gender"].ToString();
                            return employeeData;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public String[] getAll()
    {
        string query = "SELECT ID, Name, Address, Gender FROM employee";
        List<string> employeeList = new List<string>();

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employeeList.Add($"ID: {reader["ID"]}, Name: {reader["Name"]}, Address: {reader["Address"]}, Gender: {reader["Gender"]}");
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // Log the exception or handle it appropriately
            Console.WriteLine($"Error retrieving all employees: {ex.Message}");
        }

        return employeeList.ToArray();
    }

}
