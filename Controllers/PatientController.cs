using MedicalAPI.DTO;
using MedicalAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;
        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet("ListPatients")] 
        public async Task<IActionResult> ListPatients()
        {
            try
            {
                var patients = await _patientService.GetPatientsAsync();
                return Ok(patients);
            }
            catch (Exception ex)
            {
                // Log the exception here using your logging framework

                // Return a 500 Internal Server Error status code and the exception message
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }
    }
}