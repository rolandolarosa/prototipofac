using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class EmailTDBL
   {
        EmailTDDA EmailTDDA = new EmailTDDA();

       public DataSet ProcesarEmailTD(EmailTDBE BE)
       {
           return EmailTDDA.ProcesarEmailTD(BE);
       }
   }
}

