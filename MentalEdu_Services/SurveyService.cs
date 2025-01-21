using MentalEdu_Repositories.Models;
using MentalEdu_Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MentalEdu_Services.Interfaces;

namespace MentalEdu_Services
{
    public class SurveyService : ISurveyService
    {
        private readonly SurveyRepository _repository;
        public SurveyService()
        {
            _repository = new SurveyRepository();
        }

        public async Task<IEnumerable<Survey>> GetSurveysAsync(string? name, string? description)
        {
            return await _repository.GetSurveys(name, description);
        }

        public async Task<Survey> GetSurveyById(string id)
        {
            return await _repository.GetByIdAsync(new Guid(id));
        }

        public async Task<int> AddAsync(Survey survey)
        {
            survey.Id = Guid.NewGuid();
            return await _repository.CreateAsync(survey);
        }

        public async Task<int> UpdateAsync(string id, Survey updatedSurvey)
        {
            updatedSurvey.Id = new Guid(id);
            return await _repository.UpdateAsync(updatedSurvey);
        }

        public async Task<bool> DeleteAsync(string id)
        {
            Survey survey = new Survey()
            {
                Id = new Guid(id),
            };
            return await _repository.RemoveAsync(survey);
        }
    }
}
