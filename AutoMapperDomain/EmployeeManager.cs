using System;
using System.Collections.Generic;
using AutoMapperDomainContract;
using AutoMapperDomainModel;
using AutoMapperCommon.Infrastructure;
using AutoMapperRepositoryContract;
using AutoMapper;

namespace AutoMapperDomain
{
    [Injectable]
    public class EmployeeManager : IEmployeeManager
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeManager(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            if (employeeRepository == null) throw new ArgumentNullException();
            _employeeRepository = employeeRepository;

            if (mapper == null) throw new ArgumentNullException();
            _mapper = mapper;
        }

        public List<EmployeeModel> GetEmployeeDetails()
        {
            var employeeData = _mapper.Map<List<EmployeeModel>>(_employeeRepository.GetEmployeeDetails());
            return employeeData;
        }
    }
}
