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
	public class ToolsDBO {
		
			public static bool AddTools(Tools ur)
			{
				string requete = String.Format("insert into Tools(ToolsID, ToolsName)" +
					" values ('{0}','{1}');", ur.ToolsID, ur.ToolsName);

				return Util.miseajour(requete);
				//return requete;
			}
			public static bool UpOpenDay(ToolsOpenDay op)
		{
			string requete = String.Format("update ToolsOpenDay set OpenDay='{2}'" +
				"where ((ToolsID='{0}' and YearT>={2}) and WeekT>={3}) ;", op.OpenDay, op.ToolsID, op.YearT, op.WeekT);

			return Util.miseajour(requete);
			//return requete;
		}
		public static bool SetOpenDay(ToolsOpenDay op)
		{
			string requete = String.Format("insert into ToolsOpenDay (ToolsID,YearT,WeekT,OpenDay)  " +
				"values ('{0}',{1},{2},{3});", op.ToolsID, op.YearT, op.WeekT, op.OpenDay);

			return Util.miseajour(requete);

		}
		public static bool UpOperatingNumber(ToolsOpenDay op)
		{
			string requete = String.Format("update ToolsOpenDay set OpenDay={1}" +
				   " where ((ToolsID='{0}' and YearT>={2}) and WeekT>={3}) ;", op.OpenDay, op.ToolsID, op.YearT, op.WeekT);

			return Util.miseajour(requete);

		}
		public static List<Tools> GetAllTools()
		{
			List<Tools> Lur = new List<Tools>();
			string requete = String.Format("select * from Tools ;");
			OleDbDataReader rdd = Util.lire(requete);
			Tools ur;
			while (rdd.Read())
			{
				ur = new Tools
				{
					ToolsID = rdd.GetString(0),
					
					ToolsName = rdd.GetString(1),	
				};
				Lur.Add(ur);

			}
			Util.Disconnect();
			return Lur;

		}

		public static List<ToolsOpenDay> GetAllToolsOpenDay(string ToID, int yrr,int Wkk)
		{
			List<ToolsOpenDay> Lur = new List<ToolsOpenDay>();
			string requete = String.Format("select * from ToolsOpenDay where (ToolsID='{0}'  and YearT>={1}) and WeekT>={2};", ToID, yrr, Wkk);
			OleDbDataReader rdd = Util.lire(requete);
			ToolsOpenDay ur;
			while (rdd.Read())
			{
				ur = new ToolsOpenDay
				{
					ToolsID = rdd.GetString(0),

					YearT = rdd.GetInt32(1),
					WeekT = rdd.GetInt32(2),
					OpenDay  = rdd.GetInt32(3),
				};
				Lur.Add(ur);

			}
			Util.Disconnect();
			return Lur;

		}
		public static Tools GetTools(string id)
		{
			string requete = String.Format("select * from Tools where (ToolsID ='{0}');", id);
			OleDbDataReader rdd = Util.lire(requete);
			Tools ur = new Tools();
			while (rdd.Read())
			{

				ur.ToolsName = rdd.GetString(1);
				

			}
			Util.Disconnect();
			return ur;

		}

	}
}
