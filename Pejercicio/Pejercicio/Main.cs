using System;
using Gtk;
using MySql.Data.MySqlClient;

namespace Pejercicio
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string conexionString = "Server=localhost;"+ "Database=dbrepaso;"+"User Id=root;"+"Password=sistemas"; 

			MySqlConnection mySqlConnection = new MySqlConnection(conexionString);

			mySqlConnection.Open ();

			MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
			mySqlCommand.CommandText = "CREATE TABLE Empleados(idEmpleados INT NOT NULL AUTO_INCREMENT, nombreEmpleado VARCHAR(45) NULL, sueldoEmpleado VARCHAR(45) NULL,  PRIMARY KEY(idEmpleados))";
			mySqlCommand.ExecuteNonQuery();

			String nombreE;
			int sueldoE;
			nombreE = "Paco";
			sueldoE = 800;
			mySqlCommand.CommandText = "INSERT INTO Empleados('nombreEmpleado','sueldoEmpleado') VALUES ('".nombreE"',".sueldoE")"
			mySqlCommand.ExecuteNonQuery();

	
			mySqlConnection.Close();
		}
	}
}
