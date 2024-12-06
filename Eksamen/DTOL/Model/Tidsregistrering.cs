using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DTOL.Model
{
    public class Tidsregistrering
    {
        public int TidsregistreringId { get; set; }
        public DateTime StartTid { get; set; }
        public DateTime SlutTid { get; set; }
        public Medarbejder Medarbejder { get; set; }
        public int MedarbejderId { get; set; }
        public Sag ? Sag { get; set; }
        public int ? SagId { get; set; }
        public Tidsregistrering() { }
        //public Tidsregistrering(DateTime startTid, DateTime slutTid, Medarbejder medarbejder, Sag sag)
        //{
        //    StartTid = startTid;
        //    SlutTid = slutTid;
        //    Medarbejder = medarbejder;
        //    Sag = sag;
        //}
        public Tidsregistrering(DateTime startTid, DateTime slutTid, int medarbejderId, int sagId)
        {
            StartTid = startTid;
            SlutTid = slutTid;
            MedarbejderId = medarbejderId;
            SagId = sagId;
        }
        public Tidsregistrering(DateTime startTid, DateTime slutTid, int medarbejderId)
        {
            StartTid = startTid;
            SlutTid = slutTid;
            MedarbejderId = medarbejderId;
        }
    }
}
