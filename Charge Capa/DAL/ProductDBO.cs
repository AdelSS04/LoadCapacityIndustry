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
	public class ProductDBO {

		public static List<Product> GetAllProduct()
		{
			List<Product> Lur = new List<Product>();
			string requete = String.Format("select * from Product ;");
			OleDbDataReader rdd = Util.lire(requete);
			Product ur;
			while (rdd.Read())
			{
				ur = new Product
				{
					ProductID = rdd.GetString(0),
					ProductName = rdd.GetString(1),
					
				};
				Lur.Add(ur);

			}
			Util.Disconnect();
			return Lur;

		}
	}
}
