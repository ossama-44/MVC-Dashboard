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
    public class DepartmnetRepository : GenericRepository<Department>, IDepartmentRepository
    {
        private readonly MVCAppDbContext context;

        public DepartmnetRepository(MVCAppDbContext context) : base(context)
        {
            this.context = context;
        }



        //public int Add(Department department)
        //{
        //    this.context.Add(department);
        //    return this.context.SaveChanges();
        //}

        //public int Delete(Department department)
        //{
        //    this.context.Remove(department);
        //    return this.context.SaveChanges();
        //}

        //public Department Get(int? id)
        //   => this.context.Departments.FirstOrDefault(x => x.ID == id);

        //public IEnumerable<Department> GetAll()
        //   => this.context.Departments.ToList();

        //public int Update(Department department)
        //{
        //    this.context.Update(department);
        //    return this.context.SaveChanges();
        //}
    }
}
