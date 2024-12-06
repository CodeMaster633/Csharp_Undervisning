using DTO.Model; 
using DataAccessStuderende2.Repositories;
using System;
using System.Collections.Generic;


namespace BLL.Studerende
{
    public class StuderendeBLL
    {
        public DTO.Model.Studerende GetStuderende(int id) 
        {
            return StuderendeRepository.GetStuderende(id);
        }

        public void AddStuderende(DTO.Model.Studerende studerende)
        {
            // Valider studerende
            StuderendeRepository.AddStuderende(studerende);
        }

        public void EditStuderende(DTO.Model.Studerende studerende)
        {
            StuderendeRepository.EditStuderende(studerende);
        }

        // Fjernet Company-relaterede metoder, da vi arbejder med Studerende
    }
}
