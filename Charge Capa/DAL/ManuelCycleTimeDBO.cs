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
	public class ManuelCycleTimeDBO {

		
		public static bool AddOperationData(ManuelCycleTime ur)
		{
			string requete = String.Format("insert into ManuelCycleTime(OperationID,ManuelCycleTime,ProductID)" +
				" values ('{0}','{1}','{2}');", ur.OperationID, ur.ManuelCycleTimeT, ur.ProductID);

			return Util.miseajour(requete);
			//return requete;
		}
		public static List<ManuelCycleTime> GetAllOperationProduct(string op)
		{
			List<ManuelCycleTime> Lur = new List<ManuelCycleTime>();
			string requete = String.Format("select * from ManuelCycleTime where OperationID='{0}';",op);
			OleDbDataReader rdd = Util.lire(requete);
			ManuelCycleTime ur;
			while (rdd.Read())
			{
				ur = new ManuelCycleTime
				{ OperationID = rdd.GetString(1),
					ProductID = rdd.GetString(0),
					ManuelCycleTimeT = float.Parse(rdd.GetString(2)),

				};
				Lur.Add(ur);

			}
			Util.Disconnect();
			return Lur;

		}

	}
}
