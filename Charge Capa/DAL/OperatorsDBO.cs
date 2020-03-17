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

		public static List<Operators> GetOperators(string id, int yrr, int wkk)
		{
			string requete = String.Format("select * from GrpOfOperators where (IlotID ='{0}'and Yearr={1}) and Weekk>={2} ORDER BY Yearr ASC,Weekk ASC ;", id, yrr, wkk);
			OleDbDataReader rdd = Util.lire(requete);
			List<Operators> ur = new List<Operators>();
			Operators o;
			while (rdd.Read())
			{
				o = new Operators
				{
					NumberOfOperator = rdd.GetInt32(1),
					IlotID = rdd.GetString(0),
					Yearr = rdd.GetInt32(2),
					Weekk = rdd.GetInt32(3),
				};
				ur.Add(o);
				


			}
			Util.Disconnect();
			return ur;

		}

	}
}
