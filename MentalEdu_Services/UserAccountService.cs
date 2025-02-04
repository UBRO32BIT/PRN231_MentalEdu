using MentalEdu_Repositories;
using MentalEdu_Repositories.Models;

namespace MentalEdu_Services
{
    public class UserAccountService
    {
        private UserAccountRepository _repository;
        public UserAccountService()
        {
            _repository = new UserAccountRepository();
        }
        public Task<UserAccount?> Authenticate(string username, string password)
        {
            return _repository.GetUserAccountAsync(username, password);
        }


        public async Task<IEnumerable<UserAccount>> GetUserAccountsAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<UserAccount> GetUserAccountById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<int> AddAsync(UserAccount userAccount)
        {
            return await _repository.CreateAsync(userAccount);
        }

        public async Task<int> UpdateAsync(UserAccount userAccount)
        {
            return await _repository.UpdateAsync(userAccount);
        }

        public async Task<bool> DeleteAsync(UserAccount user)
        {
            return await _repository.RemoveAsync(user);
        }
    }
}
