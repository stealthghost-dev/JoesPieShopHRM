using JoesPieShopHRM.Contracts.Repositories;
using JoesPieShopHRM.Contracts.Services;
using JoesPieShopHRM.Repositories;
using JoesPieShopHRM.Shared.Domain;

namespace JoesPieShopHRM.Services
{
    public class DataService : IDataService
    {
        private readonly IRepository _repository;

        public DataService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _repository.GetAllEmployees();
        }

        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            return await _repository.GetEmployeeById(employeeId);
        }
    }
}
