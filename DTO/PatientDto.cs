using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalAPI.DTO
{
    public class PatientDto
    {
        public string? FullName { get; set; }    
        public string? CitiesVisited { get; set; }   
        public string? Category { get; set; }    

    }
}