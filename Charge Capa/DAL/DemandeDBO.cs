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
	public class DemandeDBO 
	{
		public static bool AddDemande(Demande ur)
		{
			string requete = String.Format("insert into Demande( YearDem, DemandeQTE,ProductID,WeekDem)" +
				" values ({0},{1},'{2}',{3});", ur.YearDem, ur.DemandeQTE, ur.ProductID, ur.WeekDem);

			return Util.miseajour(requete);
			
		}
		public static bool DeletAllOperationTime(int yr)
		{
			string requete = String.Format("delete * from Demande where YearDem={0} ;", yr);

			return Util.miseajour(requete);

		}
		public static bool Restee()
		{
			string requete = String.Format("ALTER TABLE <Demande> ALTER COLUMN <DemandeID> COUNTER(1,1); ");

			return Util.miseajour(requete);

		}
		public static List<Demande> GetProductDemande (string ilotid,int yrr,int wkk)
		{
			string requete = String.Format("select * from Demande where (ProductID ='{0}' and YearDem={1}) and WeekDem>={2} ORDER BY YearDem ASC,WeekDem ASC;", ilotid, yrr, wkk);
			OleDbDataReader rd = Util.lire(requete);


			List<Demande> L = new List<Demande>();
			Demande c;
			while (rd.Read())
			{
				c = new Demande
				{DemandeID=rd.GetInt32(0),
				YearDem= rd.GetInt32(1),
				DemandeQTE=rd.GetInt32(2),
				ProductID=ilotid,
				WeekDem=rd.GetInt32(4),				};
				L.Add(c);
			}
			Util.Disconnect();
			return L;
		}

	}
}
