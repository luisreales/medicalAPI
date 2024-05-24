namespace MedicalAPI.Infrastructure.Data
{
    /// <summary>
    /// Provides methods to retrieve patient data from the database.
    /// </summary>
    public class PatientQueries
    {
 
       /// <summary>
        /// Retrieves a SQL query to get a list of patients with their full names, cities visited, category, and total encounters.
        /*  Business rules:
            A patient will have three fields: 
            -first name and last name in the "last name, first name" format, example: Sinatra, Frank
            -comma-separated list of cities where this patient has ever visited a facility, example: Philadelphia, New York, Boston
            -category: A if age is less than 16, B otherwise
            - Only include patients who has at least two encounters insured by companies from different cities.
            Show patients with the smallest number of encounters first.*/
        /// </summary>
        /// <returns>The SQL query to retrieve the list of patients.</returns>
        public static string GetListPatients()
        {
            string query = @"
            SELECT CONCAT(P.first_name, ', ', P.last_name) AS FullName,
            STRING_AGG(distinct F.City, ', ') AS CitiesVisited,
            CASE WHEN P.Age < 16 THEN 'A' ELSE 'B' END AS Category,
            COUNT(E.Id) as Total
            FROM Patients P
            JOIN encounters E ON P.Id = E.patient_id
            JOIN facilities F ON E.Facility_id = F.Id
            JOIN payers PY ON E.payer_id = PY.Id
            GROUP BY P.first_name, P.last_name, P.Age
            HAVING COUNT(DISTINCT PY.City) >= 2
            ORDER BY COUNT(E.Id) asc";

            return query;
        }
    }
}