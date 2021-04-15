using EmployeeManagementApp.Data.Models;
using EmployeeManagementApp.Data.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository customerRepository)
        {
            _employeeRepository = customerRepository;
        }

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await _employeeRepository.GetAllEmployeesAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await _employeeRepository.GetEmployeeByIdAsync(id);
        }

        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            return await _employeeRepository.AddAsync(employee);
        }
        public async Task UpdateEmployeeAsync(Employee employee)
        {
            await _employeeRepository.UpdateAsync(employee);
        }

        public async Task DeleteEmployeeAsync(int id)
        {
            var employee = _employeeRepository.GetEmployeeByIdAsync(id).GetAwaiter().GetResult();

            await _employeeRepository.DeleteAsync(employee);

        }
    }
}
