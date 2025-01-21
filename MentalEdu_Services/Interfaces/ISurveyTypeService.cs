using MentalEdu_Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalEdu_Services.Interfaces
{
    public interface ISurveyTypeService
    {
        public Task<IEnumerable<SurveyType>> GetAllAsync();
        public Task<SurveyType> GetById(int id);
        public Task<int> AddAsync(SurveyType survey);
        public Task<int> UpdateAsync(SurveyType survey);
        public Task<bool> DeleteAsync(SurveyType survey);
    }
}
