using EmployeeManagementApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Data.Repositories
{


    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(EmployeeManagementDbContext employeeManagementDbContext) : base(employeeManagementDbContext)
        {
        }
        public async Task<List<Project>> GetAllProjectsAsync()
        {
            return await GetAll().ToListAsync();
        }
    }
}
