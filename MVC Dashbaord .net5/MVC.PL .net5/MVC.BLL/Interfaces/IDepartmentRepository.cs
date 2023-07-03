﻿using MVC.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.BLL.Interfaces
{
    public interface IDepartmentRepository : IGenericRepository<Department>
    {
        //Department Get(int? id);
        //IEnumerable<Department> GetAll();

        //int Add(Department department);
        //int Update(Department department);
        //int Delete(Department department);
    }
}
