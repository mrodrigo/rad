using Gtk;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace PGTKarticulo
{
	public class TreeViewFiller
	{
		static void Fill(TreeView treeView, IDbconnection dbConnection, string selectText)
		{
			IDbCommand.CommandText= "select * from articulo";

			IDataReader dataReader= IDbCommand.ExecuteReader();

 			for (int index=0; index<mySqlDataReader.FieldCount;index ++)
			treeView.AppendColumn(mySqlDataReader.GetName(index),new CellRendererText(),"text",index);

			int fieldCount = mySqlDataReader.FieldCount;
			
			ListStore listStore= createListStore(fieldCount);
			
			 while(mySqlDataReader.Read()){
			
				string []line= new string[mySqlDataReader.FieldCount];
				for (int index=0; index< mySqlDataReader.FieldCount;index++){
					object value= mySqlDataReader.GetValue(index);
					line[index]=value.ToString();
				 }
			
				listStore.AppendValues(line);
				
				treeView.Model=listStore;
				}
				dataReader.Close();
				IDbCommand.CommandText= "select * from articulo";
				
			}
			static ListStore createListStore(int fieldCount){
				Type[] types = new Type[fieldCount];
				for (int index = 0; index < fieldCount; index++)
				types[index] = typeof(string);
				return new ListStore(types);
			} 
			
		}
		
		
	}
}

