using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.DAL.Entites
{
    public class Department
    {
        public Department()
        {
            CreationOfDate = DateTime.Now;
        }

        public int ID { get; set; }

        [Required(ErrorMessage = "Code Is Required")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Name Is Required")]
        [MinLength(3, ErrorMessage = "Name Must Be More Than 3 Char")]
        public string Name { get; set; }

        public DateTime CreationOfDate { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    }
}
