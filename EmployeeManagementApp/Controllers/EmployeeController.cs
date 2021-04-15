using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementApp.Data.Models;
using EmployeeManagementApp.Service;
using EmployeeManagementApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementApp.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IProjectService _projectService;
        public EmployeeController(IEmployeeService employeeServie, IProjectService projectService)
        {
            _employeeService = employeeServie;
            _projectService = projectService;
        }
        public async Task<IActionResult> Index()
        {
            var employees = await _employeeService.GetAllEmployeesAsync();

            return View(employees);
        }
        public async Task<ActionResult> AddEmployee()
        {
            var projects = await _projectService.GetAllProjectsAsync();

            var viewModel = new EmployeeViewModel()
            {
                Project = projects,
                Employee = new Employee()
            };
          
            return View("EmployeeForm", viewModel);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _employeeService.GetEmployeeByIdAsync((int)id);
            if (employee == null)
            {
                return NotFound();
            }

            var projects = await _projectService.GetAllProjectsAsync();

            var viewModel = new EmployeeViewModel()
            {
                Project = projects,
                Employee = employee
            };

            return View("EmployeeForm", viewModel);
        }
        [HttpPost]
        public async Task<ActionResult> Save(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddEmployee", "Employee");
            }

            if (employee.Id == 0)
            {
                await _employeeService.AddEmployeeAsync(employee);
            }
            else
            {
                await _employeeService.UpdateEmployeeAsync(employee);
            }

            return RedirectToAction("Index", "Employee");
        }
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            await _employeeService.DeleteEmployeeAsync((int)id);

            return RedirectToAction("Index", "Employee");
        }
    }
}
