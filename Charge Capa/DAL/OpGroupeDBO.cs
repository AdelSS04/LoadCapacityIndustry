using BEL;
using System;
using System.Collections.Generic;
using System.Data.OleDb;


namespace DAL
{
    public class OpGroupeDBO
    {
        public static List<OpGroupe> GetPosteName()
        {
            List<OpGroupe> Lur = new List<OpGroupe>();
            string requete = String.Format("select * from OperationGroupe ;");
            OleDbDataReader rdd = Util.lire(requete);
            OpGroupe ur;
            while (rdd.Read())
            {
                ur = new OpGroupe
                {
                    GrpName = rdd.GetString(0),

                    IlotID = rdd.GetString(1),

                };
                Lur.Add(ur);

            }
            Util.Disconnect();
            return Lur;


        }

        public static OpGroupe GetPoste(string id)
        {

            string requete = String.Format("select * from OperationGroupe where GroupID='{0}' ;", id);
            OleDbDataReader rdd = Util.lire(requete);
            OpGroupe ur = new OpGroupe();
            while (rdd.Read())
            {

                ur.GrpName = rdd.GetString(0);

                ur.IlotID = rdd.GetString(1);




            }
            Util.Disconnect();
            return ur;


        }
        public static List<OpGroupe> GetOpGroupes(string id)
        {
            List<OpGroupe> Lur = new List<OpGroupe>();
            string requete = String.Format("select DISTINCT GroupID from OperationGroupe where (IlotID='{0}');", id);
            OleDbDataReader rdd = Util.lire(requete);
            OpGroupe ur;
            while (rdd.Read())
            {
                ur = new OpGroupe
                {
                    GrpName = rdd["GroupID"].ToString(),


                };
                Lur.Add(ur);

            }
            Util.Disconnect();
            return Lur;

        }


        public static List<OperatorsO> GetAllPosteOpenDay(string ToID, int yrr, int Wkk)
        {
            List<OperatorsO> Lur = new List<OperatorsO>();
            string requete = String.Format("select * from GrpOfOperators where (GroupID='{0}'  and YearT={1}) and WeekT>={2};", ToID, yrr, Wkk);
            OleDbDataReader rdd = Util.lire(requete);
            OperatorsO ur;
            while (rdd.Read())
            {
                ur = new OperatorsO
                {
                    OperationID = rdd.GetString(0),

                    YearT = rdd.GetInt32(2),
                    WeekT = rdd.GetInt32(3),
                    NumberOfOperator = rdd.GetInt32(1),
                    OpenDay = rdd.GetInt32(4),
                };
                Lur.Add(ur);

            }
            Util.Disconnect();
            return Lur;

        }
        public static bool UpOperatingNumber(OperatorsO op)
        {
            string requete = String.Format("update GrpOfOperators set NumberOfOperator={1} , OpenDay={4}" +
                   " where ((GroupID='{0}' and YearT={2}) and WeekT>={3}) ;", op.OperationID, op.NumberOfOperator, op.YearT, op.WeekT, op.OpenDay);

            return Util.miseajour(requete);

        }
        public static List<ManuelCycleTime> ListOPParGRP(string idpostecharge)
        {
            string requete = String.Format("SELECT *" +
                "FROM Operation INNER JOIN ManuelCycleTime ON Operation.OperationID = ManuelCycleTime.OperationID where " +
    "Operation.GroupID = '{0}'; ", idpostecharge);
            OleDbDataReader rd = Util.lire(requete);


            List<ManuelCycleTime> L = new List<ManuelCycleTime>();
            ManuelCycleTime c;
            while (rd.Read())
            {
                c = new ManuelCycleTime
                {

                    OperationID = rd["Operation.OperationID"].ToString(),
                    ManuelCycleTimeT = float.Parse(rd["ManuelCycleTime"].ToString()),

                    ProductID = rd["ProductID"].ToString(),

                };
                L.Add(c);
            }
            Util.Disconnect();
            return L;
        }
        public static bool AddNewPosteCharge(OpGroupe pc)
        {
            string requete = String.Format("insert into OperationGroupe (IlotID, GroupID)" +
                " values ('{0}','{1}');", pc.IlotID, pc.GrpName);

            return Util.miseajour(requete);

        }

        public static bool UpOpenDay(OperatorsO op)
        {
            string requete = String.Format("update GrpOfOperators set NumberOfOperator={2}, OpenDay={4}" +
                "where ((GroupID='{0}' and YearT={1}) and WeekT={3}) ;", op.OperationID, op.YearT, op.NumberOfOperator, op.WeekT, op.OpenDay);

            return Util.miseajour(requete);
            //return requete;
        }


        public static bool UpdateOperationGrp(string opname, string postename)
        {
            string requete = String.Format("update Operation set GroupID='{0}'" +
                   " where OperationID='{1}' ;", postename, opname);

            return Util.miseajour(requete);

        }
        public static bool UpdatePoste(OpGroupe opGroupe)
        {
            string requete = String.Format("update OperationGroupe set IlotID='{0}'" +
                   " where GroupID='{1}' ;", opGroupe.IlotID, opGroupe.GrpName);

            return Util.miseajour(requete);
        }
        public static bool DeletePoste(string opname)
        {
            string requete = String.Format("Delete * from OperationGroupe" +
                   " where GroupID='{0}' ;", opname);

            return Util.miseajour(requete);

        }




    }
}
