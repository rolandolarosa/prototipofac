using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class PersonaContactoTDBL
   {
       PersonaContactoTDDA PersonaContactoTDDA = new PersonaContactoTDDA();

       public DataSet ProcesarPersonaContactoTD(PersonaContactoTDBE BE)
       {
           return PersonaContactoTDDA.ProcesarPersonaContactoTD(BE);
       }
   }
}

