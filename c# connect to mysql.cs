using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Test
{
	class Program
	{
		static void Main(string[] args)
		{
			string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=food raider;SslMode=none";
			string query = "SELECT * FROM clients";

			MySqlConnection connection = new MySqlConnection(connectionString);
			MySqlCommand command = new MySqlCommand(query, connection);
			MySqlDataReader reader;
			try
			{
				connection.Open();
				reader = command.ExecuteReader();
				while(reader.Read())
				{
					Console.WriteLine(reader["ID"]);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				connection.Close();
			}
			Console.ReadKey();
		}
	}
}
