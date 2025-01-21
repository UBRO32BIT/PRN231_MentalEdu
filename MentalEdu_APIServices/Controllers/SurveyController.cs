using MentalEdu_Repositories.Models;
using MentalEdu_Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MentalEdu_APIServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        private readonly ISurveyService _surveyService;

        public SurveyController(ISurveyService surveyService)
        {
            _surveyService = surveyService;
        }
        // GET: api/<SurveyController>
        [HttpGet]
        public IEnumerable<Survey> Get([FromQuery] string? title, [FromQuery] string? description)
        {
            return _surveyService.GetSurveysAsync(title, description).Result;
        }

        // GET api/<SurveyController>/5
        [HttpGet("{id}")]
        public Survey Get(string id)
        {
            return _surveyService.GetSurveyById(id).Result;
        }

        // POST api/<SurveyController>
        [HttpPost]
        public IActionResult Create([FromBody] Survey payload)
        {
            int result = _surveyService.AddAsync(payload).Result;
            return Ok(result);
        }

        // PUT api/<SurveyController>/5
        [HttpPut("{id}")]
        public void Update(string id, [FromBody] Survey payload)
        {
            _surveyService.UpdateAsync(id, payload).Wait();
        }

        // DELETE api/<SurveyController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _surveyService.DeleteAsync(id).Wait();
        }
    }
}
