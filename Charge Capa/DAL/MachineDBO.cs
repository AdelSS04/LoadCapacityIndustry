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
	public class MachineDBO {
		public static bool AddMachine(Machine ur)
		{
			string requete = String.Format("insert into Machine(MachineID, MachineName, Etat,MachineRejectedRate)" +
				" values ('{0}','{1}','{2}',{3});", ur.MachineID, ur.MachineName, ur.Etat, ur.MachineRejectedRate);

			return Util.miseajour(requete);
			//return requete;
		}
		public static bool UpdateMchine(Machine ur)
		{
			string requete = String.Format("update Machine set MachineName='{1}', Etat='{2}',MachineRejectedRate={3}" +
				" where MachineID='{0}' ;", ur.MachineID, ur.MachineName, ur.Etat, ur.MachineRejectedRate);

			return Util.miseajour(requete);

		}
		public static bool DeletMachine(string id )
		{
			string requete = String.Format("delete * from Machine " +
				" where MachineID='{0}' ;", id);

			return Util.miseajour(requete);

		}
		public static Machine GetMachine(string id)
		{
			string requete = String.Format("select * from Machine where (MachineID ='{0}');", id);
			OleDbDataReader rdd = Util.lire(requete);
			Machine ur = new Machine();
			while (rdd.Read())
			{

				ur.Etat = rdd.GetString(2);
				ur.MachineName = rdd.GetString(1);
				ur.MachineID = rdd.GetString(0);
				ur.MachineRejectedRate = rdd.GetFloat(3);
				

			}
			Util.Disconnect();
			return ur;

		}
		public static List<Machine> GetAllMachine()
		{
			List<Machine> Lur = new List<Machine>();
			string requete = String.Format("select * from Machine ;");
			OleDbDataReader rdd = Util.lire(requete);
			Machine ur;
			while (rdd.Read())
			{
				ur = new Machine
				{MachineID= rdd.GetString(0),
					Etat = rdd.GetString(2),
				MachineName = rdd.GetString(1),

				MachineRejectedRate = rdd.GetFloat(3),
				
			};
				Lur.Add(ur);

			}
			Util.Disconnect();
			return Lur;

		}
		public static List<Machine> GetAllOpMachine(string id)
		{
			List<Machine> Lur = new List<Machine>();
			string requete = String.Format("select * from Machine where (MachineID ='{0}');", id);
			OleDbDataReader rdd = Util.lire(requete);
			Machine ur;
			while (rdd.Read())
			{
				ur = new Machine
				{
					MachineID = rdd.GetString(0),
					Etat = rdd.GetString(2),
					MachineName = rdd.GetString(1),

					MachineRejectedRate = rdd.GetFloat(3),
					
				};
				Lur.Add(ur);

			}
			Util.Disconnect();
			return Lur;

		}

		public static List<MachineOpenDay> GetMachineShiftCalen (string machineid,int Wek,int Yr)
		{
			List<MachineOpenDay> Lur = new List<MachineOpenDay>();
			string requete = String.Format("select * from MachineOpenDay where ((MachineID ='{0}' and WeekT>={1}) and YearT = {2}) order by WeekT;", machineid,Wek,Yr);
			OleDbDataReader rdd = Util.lire(requete);
			MachineOpenDay ur;
			while (rdd.Read())
			{
				ur = new MachineOpenDay
				{
					MachineID = rdd.GetString(0),
					YearT = rdd.GetInt32(1),
					WeekT = rdd.GetInt32(2),

					NumberOfshift = rdd.GetInt32(3),
					OpenDay = rdd.GetInt32(4),

				};
				Lur.Add(ur);

			}
			Util.Disconnect();
			return Lur;
		}
		public static bool UpdateMachineOpenDay(MachineOpenDay ur)
		{
			string requete = String.Format("update MachineOpenDay set NumberOfshift={3},OpenDay={4}" +
				" where ((MachineID='{0}' and YearT={1}) and WeekT={2}) ;", ur.MachineID,ur.YearT,ur.WeekT,ur.NumberOfshift, ur.OpenDay);

			return Util.miseajour(requete);

		}
		public static bool UpdateAllMachineOpenDay(MachineOpenDay ur)
		{
			string requete = String.Format("update MachineOpenDay set NumberOfshift={3},OpenDay={4}" +
				" where ((MachineID='{0}' and YearT={1}) and WeekT>={2}) ;", ur.MachineID, ur.YearT, ur.WeekT, ur.NumberOfshift,ur.OpenDay);

			return Util.miseajour(requete);

		}
		public static bool SetOpenDay(MachineOpenDay op)
		{
			string requete = String.Format("insert into MachineOpenDay (MachineID,YearT,WeekT,OpenDay,NumberOfshift)  " +
				"values ('{0}',{1},{2},{3},{4});", op.MachineID, op.YearT, op.WeekT, op.OpenDay,op.NumberOfshift);

			return Util.miseajour(requete);

		}
	}
}
