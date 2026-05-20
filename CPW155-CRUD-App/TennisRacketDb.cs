using Microsoft.Data.SqlClient;

namespace CPW155_CRUD_App;

public static class TennisRacketDb
{
    /// <summary>
    /// Retrieves all tennis rackets. If no rackets are found,
    /// an empty list is returned.
    /// </summary>
    /// <returns>A list of all tennis rackets.</returns>
    public static List<TennisRacket> GetAllTennisRackets()
    {
        // Get a connection to the database
        SqlConnection con = new();
        //todo: Simplify and understand the connection string
        con.ConnectionString = "Data Source=localhost;Initial Catalog=TennisDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
        con.Open();

        // Create a SQL command to select all tennis rackets
        SqlCommand selectCmd = new();
        selectCmd.Connection = con;
        selectCmd.CommandText = 
            "SELECT ItemId" +
            ", Weight" +
            ", HeadSize" +
            ", Brand" +
            ", Price" +
            " FROM TennisRacket";

        // Execute the command and read the results
        SqlDataReader reader = selectCmd.ExecuteReader();

        List<TennisRacket> rackets = new();

        // For each racket, create object and add it to the list
        while (reader.Read())
        {
            TennisRacket racket = new()
            {
                ItemId = Convert.ToInt32(reader["ItemId"]),
                Weight = Convert.ToByte(reader["Weight"]),
                HeadSize = Convert.ToInt16(reader["HeadSize"]),
                Brand = reader["Brand"].ToString(),
                Price = Convert.ToDouble(reader["Price"])
            };
            rackets.Add(racket);
        }

        // Close the connection
        con.Dispose();

        return rackets;
    }

    public static void AddTennisRacket(TennisRacket racket)
    {
        throw new NotImplementedException();
    }

    public static void UpdateTennisRacket(TennisRacket racket)
    {
        throw new NotImplementedException();
    }

    public static void DeleteTennisRacket(int itemId)
    {
        throw new NotImplementedException();
    }

    public static void DeleteTennisRacket(TennisRacket racket)
    {
        throw new NotImplementedException();
    }
}