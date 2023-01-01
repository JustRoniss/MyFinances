using MySql.Data.MySqlClient;


namespace Data;

public static class Data
{

    public static void ConnectionMySql()
    {
        string connectionString = "Server=172.19.0.2;Port=3308;Database=MyFinances;Uid=root;Pwd=admin;";

        
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            
        }
        
        
        

    }
}