using MentalEdu_Repositories;
using MentalEdu_Repositories.Models;
using MentalEdu_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalEdu_Services
{
    public class SurveyTypeService : ISurveyTypeService
    {
        private readonly SurveyTypeRepository _repository;
        public SurveyTypeService()
        {
            _repository = new SurveyTypeRepository();
        }

        public async Task<IEnumerable<SurveyType>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<SurveyType> GetById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<int> AddAsync(SurveyType survey)
        {
            return await _repository.CreateAsync(survey);
        }

        public async Task<int> UpdateAsync(SurveyType survey)
        {
            return await _repository.UpdateAsync(survey);
        }

        public async Task<bool> DeleteAsync(SurveyType surveyType)
        {
            return await _repository.RemoveAsync(surveyType);
        }
    }
}
