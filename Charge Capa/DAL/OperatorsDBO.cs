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

		public static bool UpOperatingNumber(Operators op)
		{
			string requete = String.Format("update GrpOfOperators set NumberOfOperator={1}" +
				   " where ((GroupID='{0}' and YearT>={2}) and WeekT>={3}) ;", op.IlotID, op.NumberOfOperator, op.YearT, op.WeekT);

			return Util.miseajour(requete);

		}

		public static List<Operators> GetOperators(string id, int yrr, int wkk)
		{
			string requete = String.Format("select * from GrpOfOperators where (GroupID ='{0}'and YearT={1}) and WeekT>={2} ORDER BY YearT ASC,WeekT ASC ;", id, yrr, wkk);
			OleDbDataReader rdd = Util.lire(requete);
			List<Operators> ur = new List<Operators>();
			Operators o;
			while (rdd.Read())
			{
				o = new Operators
				{
					NumberOfOperator = rdd.GetInt32(1),
					IlotID = rdd.GetString(0),
					YearT = rdd.GetInt32(2),
					WeekT = rdd.GetInt32(3),
				};
				ur.Add(o);
				


			}
			Util.Disconnect();
			return ur;

		}

	}
}
