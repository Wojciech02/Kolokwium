using Kolokwium.DTO;
using System.Collections.Generic;

namespace Kolokwium.Services
{
    public interface IMedicamentService
    {
        IEnumerable<MedicamentDTO> GetMedicament(int id)
    }
}