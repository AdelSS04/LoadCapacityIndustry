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
		public static Machine GetMachine(string id)
		{
			string requete = String.Format("select * from Machine where (MachineID ='{0}');", id);
			OleDbDataReader rdd = Util.lire(requete);
			Machine ur = new Machine();
			while (rdd.Read())
			{

				ur.Etat = rdd.GetString(2);
				ur.MachineName = rdd.GetString(1);

				ur.MachineRejectedRate = rdd.GetFloat(4);
				ur.AvialabilityTime= rdd.GetFloat(3);

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

				MachineRejectedRate = rdd.GetFloat(4),
				AvialabilityTime = rdd.GetFloat(3),
			};
				Lur.Add(ur);

			}
			Util.Disconnect();
			return Lur;

		}

	}
}
