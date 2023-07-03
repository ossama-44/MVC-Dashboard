using Microsoft.AspNetCore.Mvc;
using MVC.BLL.Interfaces;
using MVC.DAL.Entites;
using System.Threading.Tasks;
using System;

namespace MVC.PL.Controllers
{
    public class DepartmentController : Controller
    {
        //private readonly IDepartmentRepository departmentRepository;
        private readonly IUnitOfWork unitOfWork;

        public DepartmentController(/*IDepartmentRepository departmentRepository*/ IUnitOfWork unitOfWork )
        {
            //this.departmentRepository = departmentRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            //ViewData["Message"] = "Department Index [ViewData]";
            //ViewBag.MessageBag = "Department Index [ViewBag]";

            TempData.Keep("Message");
            var deprtments = await this.unitOfWork.DepartmentRepository.GetAll();
            return View(deprtments);

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Department department)
        {
            if (ModelState.IsValid)
            {
                await this.unitOfWork.DepartmentRepository.Add(department);
                TempData["Message"] = "Department Create => Index [TempData]";

                return RedirectToAction("Index");
            }
            return View(department);

        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id is null)
                return NotFound();
            var department = await this.unitOfWork.DepartmentRepository.Get(id);
            if (department == null)
                return NotFound();

            return View(department);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id is null)
                return NotFound();
            var department = await this.unitOfWork.DepartmentRepository.Get(id);
            if (department == null)
                return NotFound();

            return View(department);
        }
        [HttpPost]

        public async Task<IActionResult> Update(int? id, Department department)
        {
            if (id != department.ID)
                return NotFound();
            if (ModelState.IsValid)
            {
                try
                {
                    await this.unitOfWork.DepartmentRepository.Update(department);
                    return RedirectToAction("Index");
                }
                catch (Exception)
                {
                    return View(department);
                }

            }


            return View(department);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null)
                return NotFound();
            var department = await this.unitOfWork.DepartmentRepository.Get(id);
            if (department == null)
                return NotFound();
            await this.unitOfWork.DepartmentRepository.Delete(department);
            return RedirectToAction("Index");
            //return View(department);

        }

        [HttpPost, ActionName("Delete")]
        public IActionResult Delete(int? id, Department department)
        {

            if (id != department.ID)
            {
                return NotFound();
            }
            try
            {
                this.unitOfWork.DepartmentRepository.Delete(department);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(department);
            }
        }
    }
}
