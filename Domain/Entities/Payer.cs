namespace MedicalAPI.Domain.Entities
{
    /// <summary>
    /// Represents a payer entity.
    /// </summary>
     public class Payer
    {
        /// <summary>
        /// Gets or sets the Id  of the payer.
        /// </summary>
        public int Id { get; set; } 
        /// <summary>
        /// Gets or sets the Name  of the payer.
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Gets or sets the City  of the payer.
        /// </summary>
        public string? City { get; set; }    
    }
}