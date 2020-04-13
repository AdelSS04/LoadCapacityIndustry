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
	public class OpGroupeDBO {
		public static List<PosteCharge> GetAllTools()
		{
			List<PosteCharge> Lur = new List<PosteCharge>();
			string requete = String.Format("select * from PosteCharge ;");
			OleDbDataReader rdd = Util.lire(requete);
			PosteCharge ur;
			while (rdd.Read())
			{
				ur = new PosteCharge
				{
					GroupID = rdd.GetString(1),

					GroupName = rdd.GetString(0),
				};
				Lur.Add(ur);

			}
			Util.Disconnect();
			return Lur;

		}
		public static PosteCharge GetPoste(string id)
		{
			string requete = String.Format("select * from PosteCharge where (GroupName ='{0}');", id);
			OleDbDataReader rdd = Util.lire(requete);
			PosteCharge ur = new PosteCharge();
			while (rdd.Read())
			{

				ur.GroupID = rdd.GetString(1);


			}
			Util.Disconnect();
			return ur;

		}

		public static List<OperatorsO> GetAllPosteOpenDay(string ToID, int yrr, int Wkk)
		{
			List<OperatorsO> Lur = new List<OperatorsO>();
			string requete = String.Format("select * from GrpOfOperators where (IlotID='{0}'  and YearT>={1}) and WeekT>={2};", ToID, yrr, Wkk);
			OleDbDataReader rdd = Util.lire(requete);
			OperatorsO ur;
			while (rdd.Read())
			{
				ur = new OperatorsO
				{
					OperationID = rdd.GetString(0),

					YearT = rdd.GetInt32(2),
					WeekT = rdd.GetInt32(3),
					NumberOfOperator = rdd.GetInt32(1),
				};
				Lur.Add(ur);

			}
			Util.Disconnect();
			return Lur;

		}
		public static bool UpOperatingNumber(Operators op)
		{
			string requete = String.Format("update GrpOfOperators set NumberOfOperator={1}" +
				   " where ((IlotID='{0}' and YearT>={2}) and WeekT>={3}) ;", op.IlotID, op.NumberOfOperator, op.YearT, op.WeekT);

			return Util.miseajour(requete);

		}
		public static List<Operation> ListOPParGRP(string idpostecharge)
		{
			string requete = String.Format("select * from OperationGroupe AS MCT Inner join Operation AS O ON MCT.OperationID=O.OperationID where MCT.GroupName = '{0}';", idpostecharge);
			OleDbDataReader rd = Util.lire(requete);


			List<Operation> L = new List<Operation>();
			Operation c;
			while (rd.Read())
			{
				c = new Operation
				{
					
					OperationID = rd["O.OperationID"].ToString(),
					ManuelCycleTime = float.Parse(rd["ManuelCycleTime"].ToString()),
					ProductID = rd["ProductID"].ToString(),

				};
				L.Add(c);
			}
			Util.Disconnect();
			return L;
		}
		public static bool AddNewPosteCharge(PosteCharge pc)
		{
			string requete = String.Format("insert into PosteCharge (GroupID, GroupName)" +
				" values ('{0}','{1}');", pc.GroupID,pc.GroupName);

			return Util.miseajour(requete);
			//return requete;
		}

		public static bool UpOpenDay(OperatorsO op)
		{
			string requete = String.Format("update GrpOfOperators set NumberOfOperator='{2}'" +
				"where ((IlotID='{0}' and YearT>={1}) and WeekT>={3}) ;",op.OperationID,op.YearT,op.NumberOfOperator,op.WeekT );

			return Util.miseajour(requete);
			//return requete;
		}

		public static bool AddPosteCharge(string opname,string postename,string ilot)
		{
			string requete = String.Format("insert into PosteCharge (OperationID, GroupName,IlotID)" +
				" values ('{0}','{1}','{2}');", opname,postename,ilot);

			return Util.miseajour(requete);
			//return requete;
		}
		public static bool UpdateOperationGrp(string opname, string postename)
		{
			string requete = String.Format("update OperationGroupe set GroupName='{0}'" +
				   " where OperationID='{1}' ;", postename, opname);

			return Util.miseajour(requete);

		}

		public static bool DeletGrp(Operation ur)
		{
			string requete = String.Format("delete * from OperationGroupe where OperationID='{0}' ;", ur.OperationID);

			return Util.miseajour(requete);

		}

		

	}
}
