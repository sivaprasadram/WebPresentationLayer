using ServiceLayer.Services;
using ViewModels.ViewModels;
namespace ServiceLayer.IServices
{
    public interface IEmployeeService
    {
        void AddEmployee(EmployeeViewmodel employee);
        void AddEmployee(EmployeeViewModel employeeViewModel);
    }
}
