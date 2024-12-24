using JoesPieShopHRM.Shared.Domain;

namespace JoesPieShopHRM.Contracts.Repositories
{
    public interface IRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeById(int employeeId);
    }
}
