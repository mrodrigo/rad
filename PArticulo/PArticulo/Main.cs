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


		

    string mySelectQuery = "SELECT * FROM articulo";
    MySqlConnection myConnection = new MySqlConnection(connectionString);
    MySqlCommand myCommand = new MySqlCommand(mySelectQuery,myConnection);
    myConnection.Open();
    MySqlDataReader myReader;
    myReader = myCommand.ExecuteReader();
    
    while (myReader.Read()) {
       Console.WriteLine("id={0} nombre{1}", myReader["id"], myReader["nombre"]);
			
    }
    // Cerramos obtención de datos
    myReader.Close();
    // Cerramos conexión de base de datos
    myConnection.Close();
 

	}
	}}