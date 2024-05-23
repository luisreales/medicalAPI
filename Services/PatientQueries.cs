namespace MedicalAPI.Services
{
    public class PatientQueries
    {
        public static string GetListPatients(){
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