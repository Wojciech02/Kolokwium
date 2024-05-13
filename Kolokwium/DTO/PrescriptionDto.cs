namespace Kolokwium.DTO
{
    public class PrescriptionDto
    {
        public date Date { get; set; }
        public date DueDate { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }

    }
}