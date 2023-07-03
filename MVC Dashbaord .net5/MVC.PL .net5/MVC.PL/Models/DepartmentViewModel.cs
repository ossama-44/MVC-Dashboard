using System.ComponentModel.DataAnnotations;

namespace MVC.PL.Models
{
    public class DepartmentViewModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Code Is Required")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Name Is Required")]
        [MinLength(3, ErrorMessage = "Name Must Be More Than 3 Char")]
        public string Name { get; set; }
    }
}
