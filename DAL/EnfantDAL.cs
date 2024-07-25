// DAL/EnfantDAL.cs
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using WebFormEnfant.Models;

public class EnfantDAL
{
    private string connectionString = ConfigurationManager.ConnectionStrings["EnfantsDB"].ConnectionString;

    public List<EnfantModel> GetAllEnfants()
    {
        var enfants = new List<EnfantModel>();

        try
        {


        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Enfants", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                enfants.Add(new EnfantModel
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    TutorName = reader["TutorName"].ToString(),
                    CIN = reader["CIN"].ToString(),
                    Phone = reader["Phone"].ToString(),
                    Address = reader["Address"].ToString(),
                    Province = reader["Province"].ToString(),
                    City = reader["City"].ToString(),
                    Email = reader["Email"].ToString(),
                });
            }
        }
        }
        catch (Exception ex)
        {
            // Lancer une exception personnalisée avec un message approprié
            throw new ApplicationException("Erreur lors de la récupération des enfants : " + ex.Message, ex);
        }

        return enfants;
    }


    public void AddEnfant(EnfantModel enfant)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "INSERT INTO Enfants (FirstName, LastName, TutorName, CIN, Phone, Address, Province, City, Email) VALUES (@FirstName, @LastName, @TutorName, @CIN, @Phone, @Address, @Province, @City, @Email)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@FirstName", enfant.FirstName);
            cmd.Parameters.AddWithValue("@LastName", enfant.LastName);
            cmd.Parameters.AddWithValue("@TutorName", enfant.TutorName);
            cmd.Parameters.AddWithValue("@CIN", enfant.CIN);
            cmd.Parameters.AddWithValue("@Phone", enfant.Phone);
            cmd.Parameters.AddWithValue("@Address", enfant.Address);
            cmd.Parameters.AddWithValue("@Province", enfant.Province);
            cmd.Parameters.AddWithValue("@City", enfant.City);
            cmd.Parameters.AddWithValue("@Email", enfant.Email);

            cmd.ExecuteNonQuery();
        }
    }
    public EnfantModel GetEnfantById(int id)
    {
        EnfantModel enfant = null;

        using (var connection = new SqlConnection(connectionString))
        {
            var command = new SqlCommand("SELECT * FROM Enfants WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);

            connection.Open();
            var reader = command.ExecuteReader();

            if (reader.Read())
            {
                enfant = new EnfantModel
                {
                    Id = (int)reader["Id"],
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    TutorName = reader["TutorName"].ToString(),
                    CIN = reader["CIN"].ToString(),
                    Phone = reader["Phone"].ToString(),
                    Address = reader["Address"].ToString(),
                    Province = reader["Province"].ToString(),
                    City = reader["City"].ToString(),
                    Email = reader["Email"].ToString()
                };
            }
        }

        return enfant;
    }

    public void UpdateEnfant(EnfantModel enfant)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            var command = new SqlCommand("UPDATE Enfants SET FirstName = @FirstName, LastName = @LastName, TutorName = @TutorName, CIN = @CIN, Phone = @Phone, Address = @Address, Province = @Province, City = @City, Email = @Email WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@FirstName", enfant.FirstName);
            command.Parameters.AddWithValue("@LastName", enfant.LastName);
            command.Parameters.AddWithValue("@TutorName", enfant.TutorName);
            command.Parameters.AddWithValue("@CIN", enfant.CIN);
            command.Parameters.AddWithValue("@Phone", enfant.Phone);
            command.Parameters.AddWithValue("@Address", enfant.Address);
            command.Parameters.AddWithValue("@Province", enfant.Province);
            command.Parameters.AddWithValue("@City", enfant.City);
            command.Parameters.AddWithValue("@Email", enfant.Email);
            command.Parameters.AddWithValue("@Id", enfant.Id);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }

    public void DeleteEnfant(int id)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "DELETE FROM Enfants WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", id);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }


    // Ajoutez ici d'autres méthodes pour CRUD (Create, Update, Delete)
}
