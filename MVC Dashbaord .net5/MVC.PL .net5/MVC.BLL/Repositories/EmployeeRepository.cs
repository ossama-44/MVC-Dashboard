using Microsoft.EntityFrameworkCore;
using MVC.BLL.Interfaces;
using MVC.DAL.Context;
using MVC.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.BLL.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly MVCAppDbContext context;

        public EmployeeRepository(MVCAppDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<string> GetDepartmentByEmploeeId(int? id)
        {
            var employee = await this.context.Employees.Where(e => e.Id == id).Include(e => e.Department).FirstOrDefaultAsync();
            var department = employee.Department;
            return department.Name;
        }

        public async Task<IEnumerable<Employee>> GetEmployeesByDepartmentName(string DeptName)
        => await this.context.Employees.Where(e => e.Department.Name == DeptName).ToListAsync();

        public async Task<IEnumerable<Employee>> Search(string Name)
        => await this.context.Employees.Where(e => e.Name.Contains (Name)).ToListAsync();

    }
}
