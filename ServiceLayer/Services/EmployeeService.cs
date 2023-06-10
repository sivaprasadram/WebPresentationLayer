using DataAccessLayer.Entities;
using DataAccessLayer.IRepositories;
using ServiceLayer.IServices;
using ViewModels.ViewModels;

namespace ServiceLayer.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeService(IEmployeeRepository _employeeRepository)
        {
            employeeRepository = _employeeRepository;
        }

        public void AddEmployee(EmployeeViewModel employeeViewModel )
        {
             Employee employee = new Employee();
            employee.LastName = employeeViewModel.LastName;
            employee.FirstName = employeeViewModel.FirstName;
            employee.Salary= employeeViewModel.Salary;
            employee.Isactive = employeeViewModel.Isactive;
            employee.Address = employeeViewModel.Address;
            employee.City = employeeViewModel.City; 

            employeeRepository.AddEmployee(employee);    
        }

        public void AddEmployee(EmployeeViewmodel employee)
        {
            
        }
    }

}
