using System.Data;
using System.Text.Json;
using MedicalAPI.Application.Dtos;
using MedicalAPI.Application.Interface;
using MedicalAPI.Infrastructure.Data;

namespace MedicalAPI.Application.Services
{
    /// <summary>
    /// Represents a service for managing patients.
    /// </summary>
    public class PatientService : IPatientService
    {
        private readonly IDbConnection _dbConnection; 
        private readonly IPatientRepository _patientRepository;
        private readonly ILogger<PatientService> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="PatientService"/> class.
        /// </summary>
        /// <param name="dbConnection">The database connection.</param>
        /// <param name="logger">The logger.</param>
        /// <param name="patientRepository">The patient repository.</param>
        public PatientService(IDbConnection dbConnection, ILogger<PatientService> logger, IPatientRepository patientRepository)
        {
            _dbConnection = dbConnection;
            _logger = logger;
            _patientRepository = patientRepository;
        }
            
        /// <summary>
        /// Retrieves all patients asynchronously.
        /// </summary>
        /// <returns>A collection of <see cref="PatientDto"/>.</returns>
        public async Task<IEnumerable<PatientDto>> GetPatientsAsync()
        {
            try
            {
                var isConnected = await _patientRepository.IsDatabaseConnectionOk();
                if (!isConnected)
                {
                    _logger.LogInformation("Error: Database connection failed");
                    throw new Exception();
                }

                var patients = await _patientRepository.GetAllPatientsAsync();
                _logger.LogInformation("Sucessfully retrieved patients");
                return patients;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while getting patients");
                // Handle the exception here
                var errorMessage = $"An error in the method GetPatientsAsync : {ex.Message}";
                var jsonMessage = JsonSerializer.Serialize(errorMessage);
                throw new Exception(jsonMessage);
            }
        }
    }
}