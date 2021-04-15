using EmployeeManagementApp.Data.Models;
using EmployeeManagementApp.Data.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Service
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;
        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public async Task<List<Project>> GetAllProjectsAsync()
        {
            return await _projectRepository.GetAllProjectsAsync();
        }
    }
}
