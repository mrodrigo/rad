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
		//Hacemos un select
	    string mySelectQuery = "SELECT * FROM articulo";
	    MySqlCommand myCommand = new MySqlCommand(mySelectQuery,myConnection);
	    MySqlDataReader myReader;
	    myReader = myCommand.ExecuteReader();
	    
	    while (myReader.Read()) {
	       Console.WriteLine("id={0} nombre{1}", myReader["id"], myReader["nombre"]);
				
	    }
	    
	    myReader.Close();
		//Cerramos obtención de datos
		
		//Realizamos update
		MySqlCommand updateMySqlCommand = myConnection.CreateCommand();
		updateMySqlCommand.CommandText = "Update articulo SET nombre =@nombre WHERE id=1";
		MySqlParameter mySqlParameter = updateMySqlCommand.CreateParameter();
		mySqlParameter.ParameterName = "nombre";
		mySqlParameter.Value = DateTime.Now.ToString();
		updateMySqlCommand.Parameters.Add(mySqlParameter);
		updateMySqlCommand.ExecuteNonQuery();
		
		//Realizamos un delete de la id 1
		MySqlCommand deleteMySqlCommand = myConnection.CreateCommand();
		deleteMySqlCommand.CommandText = "delete from articulo WHERE id=1";	
		deleteMySqlCommand.ExecuteNonQuery();
			
	    //Cerramos conexión de base de datos
	    myConnection.Close();
	 }
	}
}