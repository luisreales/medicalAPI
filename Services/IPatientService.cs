using MedicalAPI.DTO;

namespace MedicalAPI.Services
{
    public interface IPatientService
    {
        public Task<IEnumerable<PatientDto>> GetPatientsAsync();
        public Task<bool> IsDatabaseConnectionOk();
    }
}