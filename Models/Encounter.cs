using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalAPI.Models
{
    public class Encounter
    {
        public int Id {get;set;}
        public int PatiendId {get;set;} 
        public int FacilityId {get;set;}    
        public int PayerId {get;set;}   
    }
}