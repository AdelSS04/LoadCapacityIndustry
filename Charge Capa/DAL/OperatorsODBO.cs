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
				   " where ((IlotID='{0}' and YearT>={2}) and WeekT>={3}) ;", op.OperationID,op.NumberOfOperator,op.YearT,op.WeekT);

			return  Util.miseajour(requete);

		}
		public static bool SetOperatingNumber(OperatorsO op)
		{
			string requete = String.Format("insert into GrpOfOperators (IlotID,YearT,WeekT,NumberOfOperator)  " +
				"values ('{0}',{1},{2},{3});", op.OperationID, op.YearT, op.WeekT, op.NumberOfOperator);

			return Util.miseajour(requete);

		}

	

	}
}
