using Kolokwium.Models;
using Kolokwium.DTO;
using Kolokwium.Repository;
using System.Collections.Generic;

namespace Kolokwium.Services
{
    public class MedicamentService : IMedicamentService
    {
        private readonly IMedicamentRepository _medicamentRepository;

        public MedicamentService(IMedicamentRepository medicamentRepository)
        {
            _medicamentRepository = medicamentRepository;
        }

        public IEnumerable<MedicamentDTO> GetMedicament(int id)
        {
            IIEnumerable<Medicament> medicaments = _medicamentRepository.GetMedicamentById(id);

            List<MedicamentDTO> medicamentDtos = new List<MedicamentDTO>();
            foreach (var medicament in medicaments)
            {
                MedicamentDTO medicamentDTO = new MedicamentDTO
                {
                    Name = medicament.Name,
                    Description = medicament.Description,
                    Type = medicament.Type
                }
            }
            return medicamentDtos;
        }
    }
}