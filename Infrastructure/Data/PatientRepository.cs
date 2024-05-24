using System.Data;
using Dapper;
using MedicalAPI.Application.Dtos;
using Npgsql;

namespace MedicalAPI.Infrastructure.Data
{
    /// <summary>
    /// Represents a repository for managing patient data.
    /// </summary>
    public class PatientRepository : IPatientRepository
    {
        private readonly IDbConnection _dbConnection;

        /// <summary>
        /// Initializes a new instance of the <see cref="PatientRepository"/> class.
        /// </summary>
        /// <param name="connection">The database connection.</param>
        public PatientRepository(IDbConnection connection)
        {
            _dbConnection = connection;
        }

        /// <summary>
        /// Retrieves all patients asynchronously using Dapper to retrive data.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains the collection of <see cref="PatientDto"/>.</returns>
        public Task<IEnumerable<PatientDto>> GetAllPatientsAsync()
        {
            var sql = PatientQueries.GetListPatients();
            var patients = _dbConnection.QueryAsync<PatientDto>(sql);
            return patients;
        }

        /// <summary>
        /// Checks if the database connection is working.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains a boolean value indicating if the connection is successful.</returns>
        public async Task<bool> IsDatabaseConnectionOk()
        {
            try
            {
                using (var connection = new NpgsqlConnection(_dbConnection.ConnectionString))
                {
                    await connection.OpenAsync();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Database connection failed: {ex.Message}");
            }
        }
    }
}