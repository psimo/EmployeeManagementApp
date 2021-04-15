using EmployeeManagementApp.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Data.Repositories
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        Task<Employee> GetEmployeeByIdAsync(int id);

        Task<List<Employee>> GetAllEmployeesAsync();
    }
}
