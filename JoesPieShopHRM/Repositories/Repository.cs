using JoesPieShopHRM.Contracts.Repositories;
using JoesPieShopHRM.Data;
using JoesPieShopHRM.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace JoesPieShopHRM.Repositories
{
    public class Repository : IRepository, IDisposable
    {
        private readonly AppDbContext _appDbContext;

        public Repository(IDbContextFactory<AppDbContext> DbFactory) {
            _appDbContext = DbFactory.CreateDbContext();
        }

        public void Dispose()
        {
           _appDbContext.Dispose();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            var employees = await _appDbContext.Employees.ToListAsync();

            return employees;
        }

        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            var employee = await _appDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
            return employee;
        }


    }
}
