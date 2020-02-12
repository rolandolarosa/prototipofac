using System.Collections.Generic;
using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
    public class SocioBL
    {
        SocioDA SocioDA = new SocioDA();

        public DataSet ProcesarSocio(SocioBE BE)
        {
            return SocioDA.ProcesarSocio(BE);
        }

        public void actualizaDocumnetoSocio(string detOrdenID, string ordenBancoID, int tipo, int origen, string @nroCuenta)
        {
            SocioDA.actualizaDocumnetoSocio(detOrdenID, ordenBancoID, tipo, origen, @nroCuenta);
        }

        public CuentaBancoBE obtenerDocumnetoSocio(string detOrdenID, string ordenBancoID)
        {
            return SocioDA.obtenerDocumnetoSocio(detOrdenID, ordenBancoID);
        }

        public void actualizaTercerCaso(TercerCasoAuxBE pTercerCasoAuxBE)
        {
            SocioDA.actualizaTercerCaso(pTercerCasoAuxBE);
        }

        public TercerCasoAuxBE obtenerTercerCaso(string codSocio, string NroCuenta)
        {
            return SocioDA.obtenerTercerCaso(codSocio, NroCuenta);
        }
    }
}
