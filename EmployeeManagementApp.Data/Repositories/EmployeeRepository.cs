using EmployeeManagementApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Data.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeManagementDbContext employeeManagementDbContext) : base(employeeManagementDbContext)
        {
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await GetAll().Include(e => e.Project).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await GetAll().Include(e => e.Project).ToListAsync();
        }
    }
}
