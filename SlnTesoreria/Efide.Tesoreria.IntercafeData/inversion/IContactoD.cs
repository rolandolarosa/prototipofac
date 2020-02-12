using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity.inversion;

namespace Efide.Tesoreria.IntercafeData.inversion
{
    public interface IContactoD
    {
        void insertContato(ContactoBE pContactoBE);
        void updateContato(ContactoBE pContactoBE);
        ContactoBE getContacto(string idInversion);
    }
}
