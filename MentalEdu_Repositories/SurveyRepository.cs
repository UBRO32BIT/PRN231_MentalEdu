using MentalEdu_Repositories.Base;
using MentalEdu_Repositories.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalEdu_Repositories
{
    public class SurveyRepository : GenericRepository<Survey>
    {
        public async Task<IEnumerable<Survey>> GetSurveys(string? title, string? description)
        {
            return await _context.Surveys
                .Include(s => s.SurveyType)
                .Where(s => s.IsDeleted != true &&
                            (string.IsNullOrEmpty(title) || s.Title.Contains(title)) &&
                            (string.IsNullOrEmpty(description) || s.Description.Contains(description)))
                .ToListAsync();
        }
    }
}
