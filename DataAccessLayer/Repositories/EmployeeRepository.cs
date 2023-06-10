using DataAccessLayer.Entities;
using DataAccessLayer.IRepositories;

namespace DataAccessLayer.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
 
      private readonly EmployeeDbContext employeeDbContext;

        public EmployeeRepository(EmployeeDbContext  _employeeDbContext)
        {
             employeeDbContext = _employeeDbContext;
        }

        public void AddEmployee(Employee employee)
        {
          employeeDbContext.Add(employee);
            employeeDbContext.SaveChanges();
        }
    }
}
