using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity.inversion;
using Efide.Tesoreria.DataAccess;
using Efide.Tesoreria.DataAccess.inversion;
using Efide.Tesoreria.IntercafeData;
using Efide.Tesoreria.IntercafeData.inversion;

namespace Efide.Tesoreria.BusinessLogic.inversion
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
