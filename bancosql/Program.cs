using System.Data.SqlClient;
using Dapper;

// See https://aka.ms/new-console-template for more information
var host = "SEU_HOST.database.windows.net";
var user = "SEU_USER";
var password = "SEU_PASSWORD";
var database = "SEU_BANCO";

string connectionString = $"Data Source={host};Initial Catalog={database};User ID={user};Password={password};";


using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();

    string sql = "SELECT * from Usuarios;";
    var usuarios = connection.Query(sql).ToList();

    foreach (var row in usuarios)
    {
        // Access the returned data using row.ColumnName
    }
}


Console.ReadLine();

