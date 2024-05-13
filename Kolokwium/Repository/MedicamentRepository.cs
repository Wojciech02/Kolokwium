using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Kolokwium.Models


namespace Kolokwium.Repository
{
    public class MedicamentRepository : IMedicamentRepository
    {
        public readonly string _connectionString;

        public MedicamentRepository(string connectionstring) {
            _connectionString = connectionstring;
        }

        public IEnumerable<Medicament> GetMedicament(int id)
        {
            List<Medicament> medicaments = new List<Medicament> ();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = $"SELECT * FROM Medicament WHERE IdMedicament = {id}";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using(SqlDataReader reader = command.ExecuteReader()) 
                {
                    while (reader.Read())
                    {
                        Medicament medicament = new Medicament
                        {
                            IdMedicament = connection.GetInt32(reader["IdMedicament"]),
                            Name = reader["Name"].ToString(),
                            Description = reader["Description"].ToString(),
                            Type = reader["Type"].ToString()
                        };
                        medicaments.Add(medicament);
                    }
                }
            }
            return medicaments;
        }
    }
}