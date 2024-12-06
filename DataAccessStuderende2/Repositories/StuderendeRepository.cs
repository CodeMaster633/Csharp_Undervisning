using DTO.Model;
using DataAccessStuderende2.Context;
using DataAccessStuderende2.Mappers;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessStuderende2.Repositories
{
    public class StuderendeRepository
    {
        public static Studerende GetStuderende(int id)
        {
            using (StuderendeContext context = new StuderendeContext())
            {
                return StuderendeMapper.Map(context.Studerendes.Find(id));
            }
        }

        public static void AddStuderende(Studerende studerende)
        {
            using (StuderendeContext context = new StuderendeContext())
            {
                var stu = StuderendeMapper.Map(studerende);
                context.Studerendes.Add(stu);
                context.SaveChanges();
            }
        }

        public static void EditStuderende(Studerende studerende)
        {
            using (StuderendeContext context = new StuderendeContext())
            {
                var dataStu = context.Studerendes.Find(studerende.StuderendeId);
                StuderendeMapper.Update(studerende, dataStu);
                context.SaveChanges();
            }
        }
    }
}
