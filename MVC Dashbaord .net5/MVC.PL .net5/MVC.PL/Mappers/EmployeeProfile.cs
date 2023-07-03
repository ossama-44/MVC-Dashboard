using AutoMapper;
using MVC.DAL.Entites;
using MVC.PL.Models;

namespace MVC.PL.Mappers
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeViewModel>().ReverseMap();

        }
    }
}
