using AutoMapper;
using AutoMappingDotnet.Models;

namespace AutoMappingDotnet.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeInputModel, Employee>();
            CreateMap<Employee, EmployeeViewModel>();
        }
    }
}
