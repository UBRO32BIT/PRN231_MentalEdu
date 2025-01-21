using MentalEdu_Repositories;
using MentalEdu_Repositories.Models;

namespace MentalEdu_Services
{
    public class UserAccountService
    {
        private UserAccountRepository _repository;
        public UserAccountService(UserAccountRepository repository)
        {
            _repository = repository;
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
