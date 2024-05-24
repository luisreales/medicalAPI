using MedicalAPI.Application.Dtos;

namespace MedicalAPI.Infrastructure.Data
{
    /// <summary>
    /// Represents a repository for managing patient data.
    /// </summary>
    public interface IPatientRepository
    {
        /// <summary>
        /// Retrieves all patients asynchronously.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains the collection of patient DTOs.</returns>
        public Task<IEnumerable<PatientDto>> GetAllPatientsAsync();

        /// <summary>
        /// Checks if the database connection is working.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result indicates whether the database connection is OK.</returns>
        public Task<bool> IsDatabaseConnectionOk();
    }
}