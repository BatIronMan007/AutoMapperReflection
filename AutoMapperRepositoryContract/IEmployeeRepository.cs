using AutoMapperRepositoryModel;
using System.Collections.Generic;

namespace AutoMapperRepositoryContract
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployeeDetails();
    }
}
