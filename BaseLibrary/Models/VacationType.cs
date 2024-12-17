

namespace BaseLibrary.Models
{
    public class VacationType : BaseModel
    {
        //Many to one relationship with Vacation
        public List<Vacation>? Vacations { get; set; }
    }
}
