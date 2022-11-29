using System.ComponentModel.DataAnnotations;

namespace CodeFirstApproach.DAL
{
    public class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public string EmailId { get; set; }
        public virtual Department Department { get; set; }       

    }
}
