using System.Data;
using System.Text.Json;
using Dapper;
using MedicalAPI.DTO;
using Npgsql;

namespace MedicalAPI.Services
{
    public class PatientService : IPatientService
    {
        private readonly IDbConnection _dbConnection; 
        private readonly ILogger<PatientService> _logger;
        public PatientService(IDbConnection dbConnection,ILogger<PatientService> logger)
        {
            _dbConnection = dbConnection;
            _logger = logger;

        }
        
        public async Task<bool> IsDatabaseConnectionOk()
        {
            try
            {
                _logger.LogInformation("Validate is the connection DB is ok");
                using (var connection = new NpgsqlConnection(_dbConnection.ConnectionString))
                {
                    await connection.OpenAsync();
                }
                 _logger.LogInformation("The connection is successfully established");
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Database connection failed: {ex.Message}");
                throw new Exception($"Database connection failed: {ex.Message}");

            }
        }
        public async Task<IEnumerable<PatientDto>> GetPatientsAsync()
        {
            try
            {

                var isConnected = await IsDatabaseConnectionOk();
                if (!isConnected)
                {
                    _logger.LogInformation("Error: Database connection failed");
                    throw new Exception();

                }
         
                var sql = PatientQueries.GetListPatients();
                _logger.LogInformation("Executing SQL query: {Sql}", sql);
                var patients = await _dbConnection.QueryAsync<PatientDto>(sql);
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