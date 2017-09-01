using AutoMapperCommon.Infrastructure;
using AutoMapperDomainModel;
using AutoMapperViewModel;

namespace AutoMapperReflection.Profiles
{
    public class EmployeeViewModelProfile : AutoMapperProfile
    {
        public EmployeeViewModelProfile()
        {
            CreateMap<EmployeeViewModel, EmployeeModel>()
               .ForMember(d => d.EmployeeId, opt => opt.MapFrom(s => s.EmployeeIdentifier))
               .ForMember(d => d.EmployeeName, opt => opt.MapFrom(s => s.EmployeeName))
               .ForMember(d => d.EmployeeDesignation, opt => opt.MapFrom(s => s.EmployeeDesignation));

            //Creating the Reverse Mapping
            CreateMap<EmployeeModel, EmployeeViewModel>()
               .ForMember(d => d.EmployeeIdentifier, opt => opt.MapFrom(s => s.EmployeeId))
               .ForMember(d => d.EmployeeName, opt => opt.MapFrom(s => s.EmployeeName))
               .ForMember(d => d.EmployeeDesignation, opt => opt.MapFrom(s => s.EmployeeDesignation));
        }
    }
}