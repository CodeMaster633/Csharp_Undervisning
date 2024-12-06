using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOL.Model;
using DataAccess.Repositories;

namespace BLL
{
    public class TidsSystemBLL
    {
        public List<Afdeling> GetAfdelinger()
        {
            return TidsregistreringRepository.GetAfdelinger();

        }

        public List<Medarbejder> GetMedarbejdere()
        {
            return TidsregistreringRepository.GetMedarbejdere();
        }
        public List<Sag> GetSager()
        {
            return TidsregistreringRepository.GetSager();
        }

        public List<Tidsregistrering> GetTidsregistreringerForMedarbejder(int medarbejderId)
        {
            return TidsregistreringRepository.GetTidsregistreringerForMedarbejder(medarbejderId);
        }

        public void OpretTidsregistrering(Tidsregistrering tidsregistrering)
        {
            TidsregistreringRepository.OpretTidsregistrering(tidsregistrering);
        }

        public string GetTimerArbejdetUge(int medarbejderId)
        {
            var tidsregistreringer = GetTidsregistreringerForMedarbejder(medarbejderId);
            
            //LINQ benyttes her:
            double antalTimerUge = tidsregistreringer
                .Where(t => (DateTime.Now.Date - t.StartTid.Date).TotalDays < 7 && (DateTime.Now.Date - t.StartTid.Date).TotalDays >= 0)
                .Sum(t => t.SlutTid.Subtract(t.StartTid).TotalHours);  // Sum er en aggregering

            double antalTimerMåned = tidsregistreringer
                .Where(t => (DateTime.Now.Date - t.StartTid.Date).TotalDays < 30 && (DateTime.Now.Date - t.StartTid.Date).TotalDays >= 0)
                .Sum(t => t.SlutTid.Subtract(t.StartTid).TotalHours);

            double antalTimerTotal = tidsregistreringer
                .Sum(t => t.SlutTid.Subtract(t.StartTid).TotalHours);

            return $"Arbejdstimer de sidste 7 dage: {antalTimerUge:F2}\n" +
                   $"Arbejdstimer de sidste 30 dage: {antalTimerMåned:F2}\n" +
                   $"Arbejdstimer total: {antalTimerTotal:F2}";
        }


    }
}
