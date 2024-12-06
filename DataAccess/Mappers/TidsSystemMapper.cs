using DataAccess.Model;
//using DTOL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DataAccess.Mappers
{
    public class TidsSystemMapper
    {
        public static DTOL.Model.Afdeling Map(Afdeling afdeling)
        {
            return new DTOL.Model.Afdeling(afdeling.Navn, afdeling.AfdelingId );
        }

        public static DTOL.Model.Medarbejder Map(Medarbejder medarbejder)
        {
            return new DTOL.Model.Medarbejder(medarbejder.CprNummer, medarbejder.Navn, medarbejder.MedarbejderId, medarbejder.AfdelingId);
        }

        public static DTOL.Model.Sag Map(Sag sag)
        {
            return new DTOL.Model.Sag(sag.Beskrivelse, sag.Overskrift, sag.SagId, sag.AfdelingId);
        }

        public static Tidsregistrering Map(DTOL.Model.Tidsregistrering tidsregistrering)
        {
            return new Tidsregistrering(tidsregistrering.StartTid,tidsregistrering.SlutTid, tidsregistrering.MedarbejderId, tidsregistrering.SagId);
        }

        public static DTOL.Model.Tidsregistrering Map(Tidsregistrering tidsregistrering)
        {
            return new DTOL.Model.Tidsregistrering(tidsregistrering.StartTid, tidsregistrering.SlutTid, tidsregistrering.MedarbejderId);
        }
    }
}
