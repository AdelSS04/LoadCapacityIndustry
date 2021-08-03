using BEL;
using System;
using System.Collections.Generic;
using System.Data.OleDb;


namespace DAL
{
    public class UserDBO
    {
        public static bool Insert_client(User ur)
        {
            string requete = String.Format("insert into UserDB(UserID, UserPassword, UserName,Type)" +
                " values ('{0}','{1}','{2}','{3}');", ur.UserID, ur.UserPassword, ur.UserName, ur.Type);

            return Util.miseajour(requete);
            //return requete;
        }
        public static bool UpdateUser(User ur)
        {
            string requete = String.Format("update UserDB set UserPassword='{1}', UserName='{2}',Type='{3}'" +
                " where UserID='{0}' ;", ur.UserID, ur.UserPassword, ur.UserName, ur.Type);

            return Util.miseajour(requete);

        }
        public static User GetUSer(string id)
        {
            string requete = String.Format("select * from UserDB where (UserID ='{0}');", id);
            OleDbDataReader rdd = Util.lire(requete);
            User ur = new User();
            while (rdd.Read())
            {

                ur.UserName = rdd.GetString(2);
                ur.UserPassword = rdd.GetString(1);
                ur.Type = rdd.GetString(3);

            }
            Util.Disconnect();
            return ur;

        }
        public static User Login(string id, string pass)
        {
            string requete = String.Format("select * from UserDB where (UserID ='{0}' and UserPassword='{1}');", id, pass);
            OleDbDataReader rdd = Util.lire(requete);
            User ur = new User();
            while (rdd.Read())
            {

                ur.UserID = rdd.GetString(0);
                ur.UserPassword = rdd.GetString(1);
                ur.UserName = rdd.GetString(2);
                ur.Type = rdd.GetString(3);

            }
            Util.Disconnect();
            return ur;

        }
        public static List<User> GetAllUSer()
        {
            List<User> Lur = new List<User>();
            string requete = String.Format("select * from UserDB ;");
            OleDbDataReader rdd = Util.lire(requete);
            User ur;
            while (rdd.Read())
            {
                ur = new User
                {
                    UserID = rdd.GetString(0),
                    UserName = rdd.GetString(2),
                    UserPassword = rdd.GetString(1),
                    Type = rdd.GetString(3),
                };
                Lur.Add(ur);

            }
            Util.Disconnect();
            return Lur;

        }


    }
}
