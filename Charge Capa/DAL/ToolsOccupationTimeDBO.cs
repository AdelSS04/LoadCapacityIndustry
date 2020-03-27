using BEL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
	public class ToolsOccupationTimeDBO {
		public static bool DeletAllOperationOccTime(ToolsOccupationTime ur)
		{
			string requete = String.Format("delete * from ToolsOccupationTime where OperationID='{0}' and ToolsID='{1}' ;", ur.OperationID, ur.ToolsID);

			return Util.miseajour(requete);

		}
		public static bool UpOccTime(ToolsOccupationTime ur)
		{
			string requete = String.Format("update ToolsOccupationTime set OccupationTime='{0}'" +
				" where ToolsID='{2}' and OperationID='{1}' ;", ur.OccupationTime, ur.OperationID, ur.ToolsID);

			return Util.miseajour(requete);
			//return requete;
		}
		public static bool AddToolsOccTime(ToolsOccupationTime ur)
		{
			string requete = String.Format("insert into ToolsOccupationTime(ToolsID,OperationID,OccupationTime)" +
				" values ('{0}','{1}','{2}');", ur.ToolsID, ur.OperationID, ur.OccupationTime);

			return Util.miseajour(requete);
			//return requete;
		}
		public static List<ToolsOccupationTime> GettoolsOccupationTimes(string id)
		{
			string requete = String.Format("select * from ToolsOccupationTime where (OperationID ='{0}');", id);
			OleDbDataReader rdd = Util.lire(requete);
			List<ToolsOccupationTime> machCy = new List<ToolsOccupationTime>();
			ToolsOccupationTime ur;
			while (rdd.Read())
			{
				ur = new ToolsOccupationTime
				{

					ToolsID = rdd.GetString(0),
					OccupationTime = float.Parse(rdd.GetString(2)),
					OperationID = rdd.GetString(1),

				}; machCy.Add(ur);
			}
			Util.Disconnect();
			return machCy;

		}



	}
}
