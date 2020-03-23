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
	public class CalendrierDBO {
	public static bool SetCal (Calendrier cl)
		{
			 string requete = String.Format("insert into Calendrier(Yearr, Weekk,OpenDayOfWeek)" +
				" values ({0},{1},{2});",cl.DateYear,cl.DateWeek,cl.OpenDayPerWeek );
			
			return	 Util.miseajour(requete);
			
			
		}
		public static bool DeletAllCall(int yr)
		{
			string requete = String.Format("delete * from Calendrier where Yearr={0} ;", yr);

			return Util.miseajour(requete);

		}
		public static bool SetCalMach(Machine mach, Calendrier cl)
		{
			string requete = String.Format("insert into MachineOpenDay(MachineID,Yearr, Weekk,OpenDayOfWeek)" +
			   " values ('{0}',{1},{2},{3});", mach.MachineID,cl.DateYear, cl.DateWeek, cl.OpenDayPerWeek);
			
			return Util.miseajour(requete);


		}
		public static List<Calendrier> GetAllUSer(int yearz)
		{
			List<Calendrier> Lur = new List<Calendrier>();
			string requete = String.Format("select * from Calendrier where Yearr={0} ;", yearz);
			OleDbDataReader rdd = Util.lire(requete);
			Calendrier ur;
			while (rdd.Read())
			{
				ur = new Calendrier
				{
					DateID=rdd.GetInt32(0),
					DateWeek=rdd.GetInt32(2),
					DateYear=rdd.GetInt32(1),
					OpenDayPerWeek=rdd.GetInt32(3),
					
				};
				Lur.Add(ur);

			}
			Util.Disconnect();
			return Lur;

		}
		public static bool UpdateCal(Calendrier ur)
		{
			string requete = String.Format("update Calendrier set OpenDayOfWeek={1}" +
				" where DateID={0} ;", ur.DateID, ur.OpenDayPerWeek);

			return Util.miseajour(requete);

		}
	}
}
