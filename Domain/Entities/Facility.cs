namespace MedicalAPI.Domain.Entities
{
    /// <summary>
    /// Represents a facility entity.
    /// </summary>
    public class Facility
    {
        /// <summary>
        /// Gets or sets the ID of the Facility.
        /// </summary>
        public int Id {get;set;}
        /// <summary>
        /// Gets or sets the Name of the Facility.
        /// </summary>
        public string? Name {get;set;}
        /// <summary>
        /// Gets or sets the City of the Facility.
        /// </summary>
        public string? City {get;set;}  
        
    }
}