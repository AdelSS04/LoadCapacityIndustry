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
	public class OpGroupeDBO {

		public static List<Operation> ListOPParGRP(string idpostecharge)
		{
			string requete = String.Format("select * from OperationGroupe AS MCT Inner join Operation AS O ON MCT.OperationID=O.OperationID where MCT.GroupName = '{0}';", idpostecharge);
			OleDbDataReader rd = Util.lire(requete);


			List<Operation> L = new List<Operation>();
			Operation c;
			while (rd.Read())
			{
				c = new Operation
				{
					IlotID = rd["IlotID"].ToString(),
					OperationID = rd["O.OperationID"].ToString(),
					ManuelCycleTime = float.Parse(rd["ManuelCycleTime"].ToString()),
					ProductID = rd["ProductID"].ToString(),

				};
				L.Add(c);
			}
			Util.Disconnect();
			return L;
		}



	}
}
