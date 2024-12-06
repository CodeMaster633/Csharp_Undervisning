using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCGUI.Models
{
    
    public class TidsregistreringViewModel
    {
        public int MedarbejderId { get; set; }
        public int AfdelingId { get; set; }
        public int? SagId { get; set; }
        public DateTime StartTidspunkt { get; set; }
        public DateTime SlutTidspunkt { get; set; }

        public List<SelectListItem> Medarbejdere { get; set; }
        public List<SelectListItem> Afdelinger { get; set; }
        public List<SelectListItem> Sager { get; set; }
    }

    
}
