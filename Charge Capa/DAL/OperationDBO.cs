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
			public static Operation  GetOperationData(string id)
			{
				
				string requete = String.Format("select * from Operation where (OperationID ='{0}');", id);
				OleDbDataReader rdd = Util.lire(requete);
				Operation ur= new Operation();
				while (rdd.Read())
				{

				ur.OperationID = rdd.GetString(0);
				ur.GroupID = rdd.GetString(1);

					
				

			}
				Util.Disconnect();
				return ur;


			}

		public static List<DemandeOP> GetDemandeOP(string id,int ii)
		{
			List<DemandeOP> Lur = new List<DemandeOP>();
			string requete = String.Format("SELECT sum(DemandeQTE),Operation.OperationID,WeekDem,CycleTime " +
				"FROM(Operation INNER JOIN MachineCycleTime ON Operation.OperationID = MachineCycleTime.OperationID) INNER JOIN((Product INNER JOIN Demande ON Product.ProductID = Demande.ProductID) " +
	"INNER JOIN ManuelCycleTime ON Product.ProductID = ManuelCycleTime.ProductID) ON " +
	"Operation.OperationID = ManuelCycleTime.OperationID where MachineID = '{0}' and WeekDem>= {1}  group by  Operation.OperationID,WeekDem,CycleTime" +
	"", id,ii);
			OleDbDataReader rdd = Util.lire(requete);
			DemandeOP ur;
			while (rdd.Read())
			{
				ur = new DemandeOP
				{ OperationID = rdd["OperationID"].ToString(),
					somm = int.Parse(rdd["Expr1000"].ToString()),
					WeekDem = int.Parse(rdd["WeekDem"].ToString()),
					CycleTime= float.Parse(rdd["CycleTime"].ToString()),

				};
				Lur.Add(ur);

			}
			Util.Disconnect();
			return Lur;


		}

		public static List<Operation> GetAllOperationName()
		{
			List<Operation> Lur = new List<Operation>();
			string requete = String.Format("select * from Operation ORDER BY OperationID DESC;");
			OleDbDataReader rdd = Util.lire(requete);
			Operation ur;
			while (rdd.Read())
			{
				ur = new Operation
				{
					OperationID = rdd.GetString(0),

					GroupID = rdd.GetString(1),
				};
				Lur.Add(ur);

			}
			Util.Disconnect();
			return Lur;

		}

		public static bool DeletAllOperation(ManuelCycleTime ur)
		{
			string requete = String.Format("delete * from ManuelCycleTime where OperationID='{0}' ;", ur.OperationID);

			return Util.miseajour(requete);

		}
		public static bool DeletOp(Operation ur)
		{
			string requete = String.Format("delete * from Operation where OperationID='{0}' ;", ur.OperationID);

			return Util.miseajour(requete);

		}
		public static bool DeletToolsOperation(Operation ur)
		{
			string requete = String.Format("delete * from ToolsOccupationTime where OperationID='{0}' ;", ur.OperationID);

			return Util.miseajour(requete);

		}
		public static bool DeletMachineOperation(Operation ur)
		{
			string requete = String.Format("delete * from MachineCycleTime where OperationID='{0}';", ur.OperationID);

			return Util.miseajour(requete);

		}
		public static bool AddOperation(Operation ur)
		{
			string requete = String.Format("insert into operation(OperationID,GroupID)" +
				" values ('{0}','{1}');", ur.OperationID, ur.GroupID);

			return Util.miseajour(requete);
			//return requete;
		}
	/*	public static bool UpdateOperation(Operation op)
		{
			string requete = String.Format("update Operation set (ManuelCycleTime={0},ProductID={2})" +
				   " where OperationID='{1}' ) ;",  op.ManuelCycleTime, op.OperationID, op.ProductID);

			return Util.miseajour(requete);

		}*/
	}
}
