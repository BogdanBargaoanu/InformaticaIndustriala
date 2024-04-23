using App1.Data;
using App1.Models;
using App1.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App1.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly EmployeeManagementSystemDbContext _dbContext;

        public EmployeesController(EmployeeManagementSystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddEmployeeViewModel employeeViewModel)
        {
            Employee newEmployee = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = employeeViewModel.Name,
                Email = employeeViewModel.Email,
                Salary = employeeViewModel.Salary,
                DateOfBirth = employeeViewModel.DateOfBirth,
                Department = employeeViewModel.Department,
            };

            await _dbContext.Employees.AddAsync(newEmployee);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("EmployeeList");
        }

        [HttpGet]
        public async Task<IActionResult> EmployeeList()
        {
            List<Employee> employees = await _dbContext.Employees.OrderBy(e => e.Name).ToListAsync();
            return View(employees);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateEmployee(Guid Id)
        {
            Employee employee = await _dbContext.Employees.FirstOrDefaultAsync(e => e.Id == Id);

            if(employee == null)
            {
                return RedirectToAction("EmployeeList");
            }

            UpdateEmployeeViewModel employeeViewModel = new UpdateEmployeeViewModel()
            {
                Id = employee.Id,
                Name = employee.Name,
                Email = employee.Email,
                Salary = employee.Salary,
                DateOfBirth = employee.DateOfBirth,
                Department = employee.Department,
            };

            return View(employeeViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateEmployee(UpdateEmployeeViewModel employeeViewModel)
        {
            var employee = await _dbContext.Employees.FindAsync(employeeViewModel.Id);

            if (employee != null)
            {
                employee.Name = employeeViewModel.Name;
                employee.Email = employeeViewModel.Email;
                employee.Salary = employeeViewModel.Salary;
                employee.DateOfBirth = employeeViewModel.DateOfBirth;
                employee.Department = employeeViewModel.Department;

                await _dbContext.SaveChangesAsync();
                return RedirectToAction("EmployeeList");
            }

            return RedirectToAction("EmployeeList");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteEmployee(UpdateEmployeeViewModel employeeViewModel)
        {
            var employee = await _dbContext.Employees.FindAsync(employeeViewModel.Id);

            if (employee != null)
            {
                _dbContext.Employees.Remove(employee);

                await _dbContext.SaveChangesAsync();
                return RedirectToAction("EmployeeList");
            }
            return RedirectToAction("EmployeeList");
        }
    }
}
