namespace MedicalAPI.Application.Dtos
{
    /// <summary>
    /// Represents a data transfer object for a patient.
    /// </summary>
    public class PatientDto
    {
        /// <summary>
        /// Gets or sets the full name of the patient.
        /// </summary>
        public string? FullName { get; set; }

        /// <summary>
        /// Gets or sets the cities visited by the patient.
        /// </summary>
        public string? CitiesVisited { get; set; }

        /// <summary>
        /// Gets or sets the category of the patient.
        /// </summary>
        public string? Category { get; set; }
    }
}