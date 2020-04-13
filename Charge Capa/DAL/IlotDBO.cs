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
	public class IlotDBO {
		
		public static List<OpGroupe> IlotOpgrp(string idpostecharge)
		{
			string requete = String.Format("select * from OperationGroupe where IlotID ='{0}';  ", idpostecharge);
			OleDbDataReader rdd = Util.lire(requete);


			List<OpGroupe> L = new List<OpGroupe>();
			OpGroupe c;
			while (rdd.Read())
			{
				c = new OpGroupe
				{
					GrpName = rdd["GroupName"].ToString(),
					IlotID= rdd["IlotID"].ToString(),
					OperationID = rdd["OperationID"].ToString(),
					//	OperationID = rdd["OperationID"].ToString(),
				};
				L.Add(c);
			}
			Util.Disconnect();
			return L;
		}
		public static Ilot GetIlot(string id)
		{
			string requete = String.Format("select * from Ilot where (IlotID ='{0}');", id);
			OleDbDataReader rdd = Util.lire(requete);
			Ilot ur = new Ilot();
			while (rdd.Read())
			{
				ur.CRM = rdd.GetFloat(3);
				ur.Efficiency = rdd.GetFloat(2);
				ur.IlotName = rdd.GetString(1);
				ur.IlotRejectedRate = rdd.GetFloat(5);
				ur.TruancyRate = rdd.GetFloat(4);
				ur.UserID = rdd.GetString(6);
				

			}
			Util.Disconnect();
			return ur;

		}
		public static bool AddIlot(Ilot ur)
		{
			string requete = String.Format("insert into Ilot(IlotID, IlotName, Efficiency,CRM,TruancyRate,IlotRejectRate,UserID)" +
				" values ('{0}','{1}',{2},{3},{4},{5},'{6}');", ur.IlotID, ur.IlotName, ur.Efficiency, ur.CRM,ur.TruancyRate,ur.IlotRejectedRate,ur.UserID);

			return Util.miseajour(requete);
			//return requete;
		}
		public static bool UpdateIlot(Ilot ur)
		{
			string requete = String.Format("update Ilot set IlotName='{1}', Efficiency={2},CRM={3},TruancyRate={4},IlotRejectRate={5},UserID='{6}'" +
				" where IlotID='{0}' ;", ur.IlotID, ur.IlotName, ur.Efficiency, ur.CRM, ur.TruancyRate, ur.IlotRejectedRate, ur.UserID);

			return Util.miseajour(requete);

		}
		public static List<Ilot> GetAllIlot()
		{
			List<Ilot> Lur = new List<Ilot>();
			string requete = String.Format("select * from Ilot ;");
			OleDbDataReader rdd = Util.lire(requete);
			Ilot ur;
			while (rdd.Read())
			{
				ur = new Ilot
				{CRM = rdd.GetFloat(3),
				Efficiency = rdd.GetFloat(2),
				IlotName = rdd.GetString(1),
				IlotRejectedRate = rdd.GetFloat(5),
				TruancyRate = rdd.GetFloat(4),
				UserID = rdd.GetString(6),
				IlotID= rdd.GetString(0),

				};
				Lur.Add(ur);

			}
			Util.Disconnect();
			return Lur;

		}

	}
}
