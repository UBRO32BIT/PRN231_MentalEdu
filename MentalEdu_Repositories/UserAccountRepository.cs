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
    public class UserAccountRepository : GenericRepository<UserAccount>
    {
        public UserAccountRepository() { }
        public async Task<UserAccount> GetUserAccountAsync(string username, string password)
        {
            return await _context.UserAccounts.FirstOrDefaultAsync(u => u.UserName == username && u.Password == password && u.IsActive == true);
        }
    }
}
