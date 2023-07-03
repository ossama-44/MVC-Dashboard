using MVC.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.BLL.Interfaces
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        Task<IEnumerable<Employee>> GetEmployeesByDepartmentName(string DeptName);
        Task<string> GetDepartmentByEmploeeId(int? id);
        Task<IEnumerable<Employee>> Search(string Name);

    }
}
