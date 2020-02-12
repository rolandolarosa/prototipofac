using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.DataAccess;
using Efide.Tesoreria.IntercafeData;

namespace Efide.Tesoreria.BusinessLogic
{
    public class ContactoBL : IContactoD
    {
        private ContactoDA _ContactoDA;
        private ContactoDA oContactoDA
        {
            get { return (_ContactoDA == null ? _ContactoDA = new ContactoDA() : _ContactoDA); }
        }

        public void insertContato(BusinessEntity.ContactoBE pContactoBE)
        {
            oContactoDA.insertContato(pContactoBE);
        }

        public BusinessEntity.ContactoBE getContacto(string idInversion)
        {
            return oContactoDA.getContacto(idInversion);
        }

        public void updateContato(BusinessEntity.ContactoBE pContactoBE)
        {
            oContactoDA.updateContato(pContactoBE);
        }
    }
}
