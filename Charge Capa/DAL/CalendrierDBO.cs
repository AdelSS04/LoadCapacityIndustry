using BEL;
using System;
using System.Collections.Generic;
using System.Data.OleDb;


namespace DAL
{
    public class CalendrierDBO
    {
        public static bool SetCal(Calendrier cl)
        {
            string requete = String.Format("insert into Calendrier(YearT, WeekT,OpenDayOfWeek)" +
               " values ({0},{1},{2});", cl.YearT, cl.WeekT, cl.OpenDayPerWeek);

            return Util.miseajour(requete);


        }
        public static bool DeletAllCall(int yr)
        {
            string requete = String.Format("delete * from Calendrier where YearT={0} ;", yr);

            return Util.miseajour(requete);

        }
        public static bool SetCalMach(Machine mach, Calendrier cl)
        {
            string requete = String.Format("insert into MachineOpenDay(MachineID,YearT, WeekT,OpenDayOfWeek)" +
               " values ('{0}',{1},{2},{3});", mach.MachineID, cl.YearT, cl.WeekT, cl.OpenDayPerWeek);

            return Util.miseajour(requete);


        }
        public static List<Calendrier> GetAllUSer(int yearz)
        {
            List<Calendrier> Lur = new List<Calendrier>();
            string requete = String.Format("select * from Calendrier where YearT={0} ;", yearz);
            OleDbDataReader rdd = Util.lire(requete);
            Calendrier ur;
            while (rdd.Read())
            {
                ur = new Calendrier
                {
                    DateID = rdd.GetInt32(0),
                    WeekT = rdd.GetInt32(2),
                    YearT = rdd.GetInt32(1),
                    OpenDayPerWeek = rdd.GetInt32(3),

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
