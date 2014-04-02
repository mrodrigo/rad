using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace PConnection
{
	class MainClass
	{
		public static void Main (string[] args)
		{

       string connectionString =
          "Server=localhost;" +
          "Database=dbrepaso;" +
          "User ID=root;" +
          "Password=sistemas;" +
          "Pooling=false";
       IDbConnection dbcon;
       dbcon = new MySqlConnection(connectionString);
       dbcon.Open();
       IDbCommand dbcmd = dbcon.CreateCommand();
       

       dbcmd.Dispose();
       dbcmd = null;
       dbcon.Close();
       dbcon = null;
    }
 }
}