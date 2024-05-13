using System;
using System.Collections.Generic;
using Kolokwium.Models;

namespace Kolokwium.Repository
{
    public interface IMedicamentRepository
    {
        IEnumerable<Medicament> GetMedicament(int id);
        //IEnumerable<Prescription> GetPrescription(string orderby);
    }
}