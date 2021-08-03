using BEL;
using System;


namespace DAL
{
    public class OperatorsODBO
    {

        public static bool UpOperatingNumber(OperatorsO op)
        {
            string requete = String.Format("update GrpOfOperators set NumberOfOperator={1}" +
                   " where ((GroupID='{0}' and YearT>={2}) and WeekT>={3}) ;", op.OperationID, op.NumberOfOperator, op.YearT, op.WeekT);

            return Util.miseajour(requete);

        }
        public static bool SetOperatingNumber(OperatorsO op)
        {
            string requete = String.Format("insert into GrpOfOperators (GroupID,YearT,WeekT,NumberOfOperator,OpenDay)  " +
                "values ('{0}',{1},{2},{3},{4});", op.OperationID, op.YearT, op.WeekT, op.NumberOfOperator, op.OpenDay);

            return Util.miseajour(requete);

        }






    }
}
