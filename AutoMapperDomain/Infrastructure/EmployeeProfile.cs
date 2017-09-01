using AutoMapperCommon.Infrastructure;
using AutoMapperDomainModel;
using AutoMapperRepositoryModel;

namespace AutoMapperDomain.Infrastructure
{
    public class EmployeeProfile : AutoMapperProfile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeModel>()
                .ForMember(d => d.EmployeeId, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.EmployeeName, opt => opt.MapFrom(s => s.Name))
                .ForMember(d => d.EmployeeDesignation, opt => opt.MapFrom(s => s.Designation));

            //Creating the Reverse Mapping
            CreateMap<EmployeeModel, Employee>()
               .ForMember(d => d.Id, opt => opt.MapFrom(s => s.EmployeeId))
               .ForMember(d => d.Name, opt => opt.MapFrom(s => s.EmployeeName))
               .ForMember(d => d.Designation, opt => opt.MapFrom(s => s.EmployeeDesignation));

        }
    }
}
