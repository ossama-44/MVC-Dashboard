using AutoMapper;
using MVC.DAL.Entites;
using MVC.PL.Models;

namespace MVC.PL.Mappers
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<Department, DepartmentViewModel>().ReverseMap();
            //CreateMap<DepartmentViewModel, Department>();

        }
    }
}
