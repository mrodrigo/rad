using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace PArticulo
{
	
 public class Test
 {
    	public static void Main (string[] args)
	{
		string connectionString =
		"Server=localhost;" +
		"Database=dbrepaso;" +
		"User Id=root;" +
		"Password=sistemas";

	
			
		 MySqlConnection myConnection = new MySqlConnection(connectionString);
			myConnection.Open();
	    string mySelectQuery = "SELECT * FROM articulo";
	   
	    MySqlCommand myCommand = new MySqlCommand(mySelectQuery,myConnection);
	    
	    MySqlDataReader myReader;
	    myReader = myCommand.ExecuteReader();
	    
	    while (myReader.Read()) {
	       Console.WriteLine("id={0} nombre{1}", myReader["id"], myReader["nombre"]);
				
	    }
	    // Cerramos obtención de datos
	    myReader.Close();
			
		MySqlCommand updateMySqlCommand = myConnection.CreateCommand();
		updateMySqlCommand.CommandText = "Update articulo SET nombre =@nombre WHERE id=1";
		MySqlParameter mySqlParameter = updateMySqlCommand.CreateParameter();
		mySqlParameter.ParameterName = "nombre";
		mySqlParameter.Value = DateTime.Now.ToString();
		updateMySqlCommand.Parameters.Add(mySqlParameter);
		updateMySqlCommand.ExecuteNonQuery();
	    // Cerramos conexión de base de datos
	    myConnection.Close();
	 }
	}
}