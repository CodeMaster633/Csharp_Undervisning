using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using DTOL.Model;
using DataAccess.Mappers; 
//using DataAccess.Model;

namespace DataAccess.Repositories
{
    public class TidsregistreringRepository
    {
        public static List<Afdeling> GetAfdelinger()
        {
            List<Afdeling> retur = new List<Afdeling>();
            using (TidsregistreringContext context = new TidsregistreringContext())
            {
                foreach (DataAccess.Model.Afdeling a in context.Afdelinger)
                {
                    retur.Add(TidsSystemMapper.Map(a));
                }
            }
            return retur;

        }

        public static List<Medarbejder> GetMedarbejdere()
        {
            List<Medarbejder> retur = new List<Medarbejder>();
            using (TidsregistreringContext context = new TidsregistreringContext())
            {
                foreach (DataAccess.Model.Medarbejder m in context.Medarbejdere)
                {
                    retur.Add(TidsSystemMapper.Map(m));
                }
            }
            return retur;
        }
        public static List<Sag> GetSager()
        {
            List<Sag> retur = new List<Sag>();
            using (TidsregistreringContext context = new TidsregistreringContext())
            {
                foreach (DataAccess.Model.Sag s in context.Sager)
                {
                    retur.Add(TidsSystemMapper.Map(s));
                }
            }
            return retur;
        }

        public static List<Tidsregistrering> GetTidsregistreringerForMedarbejder(int medarbejderId)
        {
            List<Tidsregistrering> retur = new List<Tidsregistrering>();
            using (TidsregistreringContext context = new TidsregistreringContext())
            {
                retur.AddRange(
                    context.Tidsregistreringer
                        .Where(t => t.MedarbejderId == medarbejderId)   
                        .Select(t => TidsSystemMapper.Map(t))           
                );
            }
            return retur;
        }

        public static void OpretTidsregistrering(Tidsregistrering tidsregistrering)
        {
            using (TidsregistreringContext context = new TidsregistreringContext())
            {
                context.Add(TidsSystemMapper.Map(tidsregistrering));
                context.SaveChanges();
            }
        }
    }
}
