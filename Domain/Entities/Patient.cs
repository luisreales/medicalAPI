namespace MedicalAPI.Domain.Entities
{
    /// <summary>
    /// Represents a patient.
    /// </summary>
    public class Patient
    {
        /// <summary>
        /// Gets or sets the ID of the patient.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the first name of the patient.
        /// </summary>
        public string? FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the patient.
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Gets or sets the age of the patient.
        /// </summary>
        public int Age { get; set; }
    }
}