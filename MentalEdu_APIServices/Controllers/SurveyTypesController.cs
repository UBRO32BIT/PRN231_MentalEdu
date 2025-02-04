using MentalEdu_Repositories.Models;
using MentalEdu_Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MentalEdu_APIServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyTypesController : ControllerBase
    {
        private readonly ISurveyTypeService _surveyTypeService;
        public SurveyTypesController(ISurveyTypeService surveyTypeService)
        {
            _surveyTypeService = surveyTypeService;
        }

        // GET: api/<SurveyTypesController>
        [HttpGet]
        [Authorize(Roles = "1, 2")]
        public IEnumerable<SurveyType> Get()
        {
            return _surveyTypeService.GetAllAsync().Result;
        }

        // GET api/<SurveyTypesController>/5
        [HttpGet("{id}")]
        [Authorize(Roles = "1, 2")]
        public SurveyType Get(int id)
        {
            return _surveyTypeService.GetById(id).Result;
        }

        // POST api/<SurveyTypesController>
        [HttpPost]
        [Authorize(Roles = "1, 2")]
        public IActionResult Create([FromBody] SurveyType payload)
        {
            _surveyTypeService.AddAsync(payload).Wait();
            return Created();
        }

        // PUT api/<SurveyTypesController>/5
        [HttpPut("{id}")]
        [Authorize(Roles = "1, 2")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SurveyTypesController>/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "1, 2")]
        public void Delete(int id)
        {
        }
    }
}
