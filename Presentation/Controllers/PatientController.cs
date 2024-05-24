using MedicalAPI.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAPI.Controllers
{

    /// <summary>
        /// Represents a controller for managing patient-related operations.
        /// </summary>
        [Route("api/[controller]")]
        [ApiController]
        public class PatientController : ControllerBase
        {
            private readonly IPatientService _patientService;

            /// <summary>
            /// Initializes a new instance of the <see cref="PatientController"/> class.
            /// </summary>
            /// <param name="patientService">The patient service.</param>
            public PatientController(IPatientService patientService)
            {
                _patientService = patientService;
            }

            /// <summary>
            /// Retrieves a list of patients.
            /// </summary>
            /// <returns>An <see cref="IActionResult"/> representing the response containing the list of patients.</returns>
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
                    // Log the exception here using Serilog

                    // Return a 500 Internal Server Error status code and the exception message
                    return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
                }
            }
        }
}