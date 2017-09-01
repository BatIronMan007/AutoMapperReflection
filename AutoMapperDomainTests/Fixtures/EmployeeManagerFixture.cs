using AutoMapper;
using AutoMapperDomain;
using AutoMapperDomain.Infrastructure;
using AutoMapperRepositoryContract;
using Moq;

namespace AutoMapperDomainTests.Fixtures
{
    public class EmployeeManagerFixture
    {
        public EmployeeManager EmployeeManagerObject { get; set; }

        public Mock<IEmployeeRepository> EmployeeRepository { get; set; }

        public EmployeeManagerFixture()
        {
            EmployeeRepository = new Mock<IEmployeeRepository>();
            EmployeeManagerObject = new EmployeeManager(EmployeeRepository.Object, CreateMapperConfig());
        }

        public IMapper CreateMapperConfig()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<EmployeeProfile>();
            });
            return config.CreateMapper();
        }
    }
}
