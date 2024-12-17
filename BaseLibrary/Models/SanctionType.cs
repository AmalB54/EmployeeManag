

namespace BaseLibrary.Models
{
    public class SanctionType : BaseModel
    {
        //Many to one relationship with vacation
        public List<Sanction>? Sanctions { get; set; }
    }
}
