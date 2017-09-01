using AutoMapperDomain;
using AutoMapperDomainTests.Fixtures;
using System;
using Xunit;

namespace AutoMapperDomainTests
{
    [Trait("Domain Tests", "Employee Manager")]
    public class EmployeeManagerTest : IClassFixture<EmployeeManagerFixture>
    {
        private readonly EmployeeManagerFixture _employeeManagerFixture;

        public EmployeeManagerTest(EmployeeManagerFixture employeeManagerFixture)
        {
            _employeeManagerFixture = employeeManagerFixture;
        }

        [Fact]
        public void EmployeeManagerConstructor_ShouldThrowNullIfEmployeeRespositoryIsNull()
        {
            Assert.ThrowsAny<ArgumentNullException>(() => new EmployeeManager(null, _employeeManagerFixture.CreateMapperConfig()));
        }

        [Fact]
        public void EmployeeManagerConstructor_ShouldThrowNullIfMapperIsNull()
        {
            Assert.ThrowsAny<ArgumentNullException>(() => new EmployeeManager(_employeeManagerFixture.EmployeeRepository.Object, null));
        }
    }
}
