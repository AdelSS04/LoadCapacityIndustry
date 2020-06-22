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
	public class IlotOpDBO
	{
		public static List<IlotOp> GetIlotOP(string kk,int yrr,int wkk)
		{
			List<IlotOp> Lur = new List<IlotOp>();
			string requete = String.Format("select * from IlotSpecifOP where ((IlotID='{0}' and YearT={1}) and WeekT>={2});", kk,yrr,wkk);
			OleDbDataReader rdd = Util.lire(requete);
			IlotOp ur;
			while (rdd.Read())
			{
				ur = new IlotOp
				{
					Formation = rdd.GetInt32(3),
					IlotID = rdd.GetString(2),
					WeekT = rdd.GetInt32(1),
					Chomage = rdd.GetInt32(5),
					Materneti = rdd.GetInt32(4),
					
					YearT = rdd.GetInt32(0),
				

				};
				Lur.Add(ur);

			}
			Util.Disconnect();
			return Lur;

		}


		public static List<IlotOp> GetIlotOPdata( int yrr, int wkk)
		{
			List<IlotOp> Lur = new List<IlotOp>();
			string requete = String.Format("SELECT Sum([FormationOP]) AS Expr1,Sum([ChomOp]) AS Expr2,Sum([MatOp]) AS Expr13,WeekT FROM IlotSpecifOP where YearT={0} and WeekT>={1} Group BY WeekT;", yrr, wkk);
			OleDbDataReader rdd = Util.lire(requete);
			IlotOp ur;
			while (rdd.Read())
			{
				ur = new IlotOp
				{
					Formation = int.Parse(rdd["Expr1"].ToString()),


					WeekT = int.Parse(rdd["WeekT"].ToString()),
					Chomage = int.Parse(rdd["Expr2"].ToString()),
					Materneti = int.Parse(rdd["Expr13"].ToString()),




				};
				Lur.Add(ur);

			}
			Util.Disconnect();
			return Lur;

		}

		public static List<IlotOp> GetIlotOPdataAtelier(int yrr, int wkk,string kk)
		{
			List<IlotOp> Lur = new List<IlotOp>();
			string requete = String.Format("SELECT Sum(IlotSpecifOP.[FormationOP]) AS Expr1, Sum(IlotSpecifOP.[ChomOp]) AS Expr2, Sum(IlotSpecifOP.[MatOp]) AS Expr13, IlotSpecifOP.WeekT FROM Ilot INNER JOIN IlotSpecifOP ON Ilot.IlotID = IlotSpecifOP.IlotID WHERE(((IlotSpecifOP.[YearT]) = {0}) AND((IlotSpecifOP.[WeekT]) >= {1}) AND(([Ilot].[Atelier]) = '{2}')) GROUP BY IlotSpecifOP.WeekT; ", yrr, wkk,kk);
			OleDbDataReader rdd = Util.lire(requete);
			IlotOp ur;
			while (rdd.Read())
			{
				ur = new IlotOp
				{
					Formation = int.Parse(rdd["Expr1"].ToString()),


					WeekT = int.Parse(rdd["WeekT"].ToString()),
					Chomage = int.Parse(rdd["Expr2"].ToString()),
					Materneti = int.Parse(rdd["Expr13"].ToString()),




				};
				Lur.Add(ur);

			}
			Util.Disconnect();
			return Lur;

		}

		public static bool UpOperatingNumber(IlotOp op)
		{
			string requete = String.Format("update IlotSpecifOP set FormationOP={3},MatOp={4},ChomOp ={5}" +
				   " where ((IlotID='{0}' and YearT={1}) and WeekT={2}) ;", op.IlotID, op.YearT, op.WeekT, op.Formation, op.Materneti, op.Chomage);

			return Util.miseajour(requete);

		}
		public static bool SetOpenDay(IlotOp op)
		{
			string requete = String.Format("insert into IlotSpecifOP (IlotID,YearT,WeekT,FormationOP,MatOp,ChomOp)  " +
				"values ('{0}',{1},{2},{3},{4},{5});", op.IlotID, op.YearT, op.WeekT, op.Formation, op.Materneti, op.Chomage);

			return Util.miseajour(requete);

		}

	}
}
