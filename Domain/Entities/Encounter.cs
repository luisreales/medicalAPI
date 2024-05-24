namespace MedicalAPI.Domain.Entities
{
    /// <summary>
    /// Represents an encounter in the medical domain.
    /// </summary>
    public class Encounter
    {
        /// <summary>
        /// Gets or sets the ID of the encounter.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the patient associated with the encounter.
        /// </summary>
        public int PatiendId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the facility where the encounter took place.
        /// </summary>
        public int FacilityId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the payer associated with the encounter.
        /// </summary>
        public int PayerId { get; set; }
    }

}