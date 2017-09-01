using System.Collections.Generic;
using AutoMapperRepositoryContract;
using AutoMapperRepositoryModel;
using AutoMapperCommon.Infrastructure;

namespace AutoMapperRepository
{
    [Injectable]
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetEmployeeDetails()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    Id=1,
                    Name="Ankit Rawat",
                    Designation="Senior Software Engineer"
                },

                new Employee()
                {
                    Id=2,
                    Name="Ankit Nigam",
                    Designation="Senior Software Engineer"
                },

                new Employee()
                {
                    Id=3,
                    Name="Neelesh Raidas",
                    Designation="Senior Software Engineer"
                },

                new Employee()
                {
                    Id=4,
                    Name="Jogesh Grover",
                    Designation="Associate Tech Architect"
                }
            };
        }
    }
}
