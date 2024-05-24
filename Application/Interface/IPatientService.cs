using MedicalAPI.Application.Dtos;

namespace MedicalAPI.Application.Interface
{
    /// <summary>
    /// Represents a service for managing patients.
    /// </summary>
    public interface IPatientService
    {
        /// <summary>
        /// Retrieves a list of patients asynchronously.
        /// </summary>
        /// <returns>An enumerable collection of <see cref="PatientDto"/>.</returns>
        public Task<IEnumerable<PatientDto>> GetPatientsAsync();
    }
}