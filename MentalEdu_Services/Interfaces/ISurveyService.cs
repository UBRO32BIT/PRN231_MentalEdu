using MentalEdu_Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalEdu_Services.Interfaces
{
    public interface ISurveyService
    {
        public Task<IEnumerable<Survey>> GetSurveysAsync(string? name, string? description);
        public Task<Survey> GetSurveyById(string id);
        public Task<int> AddAsync(Survey survey);
        public Task<int> UpdateAsync(string id, Survey updatedSurvey);
        public Task<bool> DeleteAsync(string id);
    }
}
