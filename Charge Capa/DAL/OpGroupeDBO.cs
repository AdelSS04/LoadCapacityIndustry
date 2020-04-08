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
		public static bool UpOperatingNumber(Operators op)
		{
			string requete = String.Format("update GrpOfOperators set NumberOfOperator={1}" +
				   " where ((IlotID='{0}' and Yearr>={2}) and Weekk>={3}) ;", op.IlotID, op.NumberOfOperator, op.Yearr, op.Weekk);

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
					IlotID = rd["IlotID"].ToString(),
					OperationID = rd["O.OperationID"].ToString(),
					ManuelCycleTime = float.Parse(rd["ManuelCycleTime"].ToString()),
					ProductID = rd["ProductID"].ToString(),

				};
				L.Add(c);
			}
			Util.Disconnect();
			return L;
		}
		public static bool AddPosteCharge(string opname,string postename)
		{
			string requete = String.Format("insert into OperationGroupe (OperationID, GroupName)" +
				" values ('{0}','{1}');", opname,postename);

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
