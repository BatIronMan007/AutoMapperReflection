using AutoMapperDomainModel;
using System.Collections.Generic;

namespace AutoMapperDomainContract
{
    public interface IEmployeeManager
    {
        List<EmployeeModel> GetEmployeeDetails();
    }
}
