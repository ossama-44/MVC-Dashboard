using Microsoft.AspNetCore.Mvc;
using MVC.BLL.Interfaces;
using MVC.DAL.Entites;
using System.Threading.Tasks;
using System;
using MVC.PL.Models;
using AutoMapper;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;
using MVC.PL.Helper;

namespace MVC.PL.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        //private readonly IEmployeeRepository employeeRepository;
        //private readonly IDepartmentRepository departmentRepository;

        public EmployeeController(
            IUnitOfWork unitOfWork
            , IMapper mapper
            //IEmployeeRepository employeeRepository
            //, IDepartmentRepository departmentRepository
            )
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;

            //this.employeeRepository = employeeRepository;
            //this.departmentRepository = departmentRepository;
        }

        public async Task<IActionResult> Index(string SearchValue = "")
        {
            IEnumerable<Employee> employees;
            if (string.IsNullOrEmpty(SearchValue))
            {
                employees = await this.unitOfWork.EmployeeRepository.GetAll();
                //var mappedEmployee = this.mapper.Map<IEnumerable<Employee>,IEnumerable<EmployeeViewModel>>(employees);

            }
            else
            {
                employees = await this.unitOfWork.EmployeeRepository.Search(SearchValue);

            }
            var mappedEmployee = this.mapper.Map<IEnumerable<EmployeeViewModel>>(employees);

            return View(mappedEmployee);

        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Departments = await this.unitOfWork.DepartmentRepository.GetAll();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(EmployeeViewModel employeeViewModel)
        {
            if (ModelState.IsValid)
            {
                //var MappedEmployee = new Employee() 
                //{
                //    Id = employee.Id,
                //    Name = employee.Name,
                //    Address = employee.Address,
                //    Age = employee.Age,
                //    Email = employee.Email,
                //    IsActive = employee.IsActive,
                //    Salary = employee.Salary,
                //    PhoneNumber = employee.PhoneNumber,
                //    HireDate = employee.HireDate,
                //    DepartmentId = employee.DepartmentId

                //};
                employeeViewModel.ImageUrl = DocumentSettings.UploadFile(employeeViewModel.Image, "Imgs");
                var mappedEmployee = this.mapper.Map<Employee>(employeeViewModel);
                await this.unitOfWork.EmployeeRepository.Add(mappedEmployee);
                return RedirectToAction("Index");
            }
            return View(employeeViewModel);

        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id is null)
                return NotFound();
            var employee = await this.unitOfWork.EmployeeRepository.Get(id);

            var mappedEmployee = this.mapper.Map<EmployeeViewModel>(employee);

            var departmentName = await this.unitOfWork.EmployeeRepository.GetDepartmentByEmploeeId(id);
         
            if (employee == null)
                return NotFound();

            return View(mappedEmployee);
        }

        public async Task<IActionResult> Update(int? id)
        {
            ViewBag.Departments = await this.unitOfWork.DepartmentRepository.GetAll();

            if (id is null)
                return NotFound();

            var employee = await this.unitOfWork.EmployeeRepository.Get(id);

            var mappedEmployee = this.mapper.Map<EmployeeViewModel>(employee);

            if (employee == null)
                return NotFound(); 

            return View(mappedEmployee);
        }
        [HttpPost]

        public async Task<IActionResult> Update(int? id, EmployeeViewModel employeeViewModel)
        {
            if (id != employeeViewModel.Id)
                return NotFound();
            if (ModelState.IsValid)
            {
                try
                {
                    employeeViewModel.ImageUrl = DocumentSettings.UploadFile(employeeViewModel.Image, "Imgs");
                    var mappedEmployee = this.mapper.Map<Employee>(employeeViewModel);
                    await this.unitOfWork.EmployeeRepository.Update(mappedEmployee);
                    return RedirectToAction("Index");
                }
                catch (Exception)
                {
                    return View(employeeViewModel);
                }

            }


            return View(employeeViewModel);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null)
                return NotFound();
            var employee = await this.unitOfWork.EmployeeRepository.Get(id);

            if (employee == null)
                return NotFound();

            DocumentSettings.DeleteFile("Imgs", employee.ImageUrl);
            await this.unitOfWork.EmployeeRepository.Delete(employee);
            return RedirectToAction("Index");
            //return View(department);

        }
    }
}
