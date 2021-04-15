using EmployeeManagementApp.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Service
{
    public interface IProjectService
    {
        Task<List<Project>> GetAllProjectsAsync();
    }
}
