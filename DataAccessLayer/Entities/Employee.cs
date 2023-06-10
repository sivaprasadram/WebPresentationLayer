using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary {get; set; } 
        public bool Isactive { get; set; }
        public string Address { get; set; } 
        public string City { get; set; }    
    }
}
