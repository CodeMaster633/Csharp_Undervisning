using DataAccessStuderende2.Model;
using System.Collections.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DataAccessStuderende2.Mappers
{
    internal class StuderendeMapper
    {
        public static DTO.Model.Studerende Map(Studerende studerende)
        {
            return new DTO.Model.Studerende(studerende.StuderendeId, studerende.Navn, studerende.Studiestart, studerende.Alder, (DTO.Model.Studietype)studerende.Studietype);
        }

        public static Studerende Map(DTO.Model.Studerende dtoStuderende)
        {
            return new Studerende(dtoStuderende.StuderendeId, dtoStuderende.Navn, dtoStuderende.Studiestart, dtoStuderende.Alder, (DataAccessStuderende2.Model.Studietype)dtoStuderende.Studietype);
        }

        internal static void Update(DTO.Model.Studerende dtoStuderende, Studerende dataStuderende)
        {
            dataStuderende.Navn = dtoStuderende.Navn;
            dataStuderende.Studiestart = dtoStuderende.Studiestart;
            dataStuderende.Alder = dtoStuderende.Alder;
            dataStuderende.Studietype = (DataAccessStuderende2.Model.Studietype)dtoStuderende.Studietype;
        }

        private static List<DTO.Model.Studerende> Map(List<Studerende> studerendeList)
        {
            List<DTO.Model.Studerende> retur = new List<DTO.Model.Studerende>();
            foreach (Studerende studerende in studerendeList) retur.Add(StuderendeMapper.Map(studerende));
            return retur;
        }
    }
}
