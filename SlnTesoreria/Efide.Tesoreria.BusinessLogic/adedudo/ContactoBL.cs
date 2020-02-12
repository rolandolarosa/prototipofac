using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity.adeudo;
using Efide.Tesoreria.DataAccess;
using Efide.Tesoreria.DataAccess.adeudo;
using Efide.Tesoreria.IntercafeData;
using Efide.Tesoreria.IntercafeData.adeudo;

namespace Efide.Tesoreria.BusinessLogic.adeudo
{
    public class ContactoBL : IContactoD
    {
        private ContactoDA _ContactoDA;
        private ContactoDA oContactoDA
        {
            get { return (_ContactoDA == null ? _ContactoDA = new ContactoDA() : _ContactoDA); }
        }

        public void insertContato(ContactoBE pContactoBE)
        {
            oContactoDA.insertContato(pContactoBE);
        }

        public ContactoBE getContacto(string idInversion)
        {
            return oContactoDA.getContacto(idInversion);
        }

        public void updateContato(ContactoBE pContactoBE)
        {
            oContactoDA.updateContato(pContactoBE);
        }
    }
}
