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
	public class OperatorsODBO
	{

		public static bool UpOperatingNumber (OperatorsO op)
		{
			string requete = String.Format("update GrpOfOperators set NumberOfOperator={1}" +
				   " where ((OperationID='{0}' and Yearr>={2}) and Weekk>={3}) ;", op.OperationID,op.NumberOfOperator,op.Yearr,op.Weekk);

			return  Util.miseajour(requete);

		}
		public static bool SetOperatingNumber(OperatorsO op)
		{
			string requete = String.Format("insert into GrpOfOperators (OperationID,Yearr,Weekk,NumberOfOperator)  " +
				"values ('{0}',{1},{2},{3});", op.OperationID, op.Yearr, op.Weekk, op.NumberOfOperator);

			return Util.miseajour(requete);

		}

	

	}
}
