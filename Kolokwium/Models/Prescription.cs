namespace Kolokwium.Models
{
	public class Prescription
	{
		public int IdPrescription { get; set; }
		public date Date { get; set; }
		public date DueDate { get; set; }
		public int PatientId { get; set; }
		public int DoctorId { get; set; }

	}
}