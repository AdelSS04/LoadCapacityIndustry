using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
	public class Util
	{
		public static OleDbConnection cn;
		public static OleDbCommand cmd;
		public static OleDbDataReader rd;

		public static void Connect()
		{
			ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["Connecter"];
			string cnstr = settings.ConnectionString;
			cn = new OleDbConnection(cnstr);
			cn.Open();
		}

		public static OleDbDataReader lire(string req)
		{
			Connect();
			cmd = new OleDbCommand(req, cn);
			rd = cmd.ExecuteReader();
			return rd;
		}
		public static OleDbDataReader LireScaler(string req)
		{
			Connect();
			cmd = new OleDbCommand(req, cn);
			rd = cmd.ExecuteReader();
			return rd ;
		}

		public static bool miseajour(string req)
		{
			Connect();
			cmd = new OleDbCommand(req, cn);
			int nbaffected = cmd.ExecuteNonQuery();
			Disconnect();
			if (nbaffected != 0)
				return true;
			else
				return false;
		}

		public static void Disconnect()
		{
			cn.Close();
			cn.Dispose();
		}
	}
}
