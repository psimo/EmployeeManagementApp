using EmployeeManagementApp.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementApp.ViewModels
{
    public class EmployeeViewModel
    {
        public IEnumerable<Project> Project { get; set; }
        public Employee Employee { get; set; }
        public List<SelectListItem> GenderList { get; } = new List<SelectListItem>
        {
        new SelectListItem { Value = "Male", Text = "Male" },
        new SelectListItem { Value = "Female", Text = "Female" }
        };
    }
}
