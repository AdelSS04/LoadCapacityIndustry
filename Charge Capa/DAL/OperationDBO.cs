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
	public class OperationDBO {
		public static List<Operation>  GetOperation(string id)
		{
			List<Operation> Lur = new List<Operation>();
			string requete = String.Format("select * from Operation where (OperationID ='{0}');", id);
			OleDbDataReader rdd = Util.lire(requete);
			Operation ur;
			while (rdd.Read())
			{
				ur = new Operation
				{
					IlotID = rdd.GetString(0),
				ManuelCycleTime = float.Parse(rdd.GetString(2)),
				ProductID = rdd.GetString(3)
			};
			Lur.Add(ur);

		}
			Util.Disconnect();
			return Lur;
			

		}

		public static List<Operation> GetAllOperationName()
		{
			List<Operation> Lur = new List<Operation>();
			string requete = String.Format("select * from Operation;");
			OleDbDataReader rdd = Util.lire(requete);
			Operation ur;
			while (rdd.Read())
			{
				ur = new Operation
				{OperationID = rdd.GetString(1),
					IlotID = rdd.GetString(0),
					ManuelCycleTime = float.Parse(rdd.GetString(2)),
					ProductID = rdd.GetString(3)
				};
				Lur.Add(ur);

			}
			Util.Disconnect();
			return Lur;

		}

		public static bool DeletAllOperation(Operation ur)
		{
			string requete = String.Format("delete * from operation where OperationID='{0}' ;", ur.OperationID);

			return Util.miseajour(requete);

		}
		
		public static bool AddOperation(Operation ur)
		{
			string requete = String.Format("insert into operation(IlotID, OperationID, ManuelCycleTime,ProductID)" +
				" values ('{0}','{1}','{2}','{3}');", ur.IlotID, ur.OperationID, ur.ManuelCycleTime, ur.ProductID);

			return Util.miseajour(requete);
			//return requete;
		}

	}
}
