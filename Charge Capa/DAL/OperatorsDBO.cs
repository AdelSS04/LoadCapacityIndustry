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
	public class OperatorsDBO {

		public static bool UpOperatingNumber (Operators op)
		{
			string requete = String.Format("update GrpOfOperators set NumberOfOperator={1}" +
				   " where ((IlotID='{0}' and Yearr>={2}) and Weekk>={3}) ;", op.IlotID,op.NumberOfOperator,op.Yearr,op.Weekk);

			return  Util.miseajour(requete);

		}

	}
}
