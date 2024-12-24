using JoesPieShopHRM.Shared.Domain;

namespace JoesPieShopHRM.Contracts.Services
{
    public interface IDataService
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeById(int employeeId);
    }
}
