using AutoMapper;
using AutoMapperDomainContract;
using AutoMapperViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;

namespace AutoMapperReflection.Controllers
{
    public class EmployeeController : ApiController
    {
        private readonly IEmployeeManager _employeeManager;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployeeManager employeeManager, IMapper mapper)
        {
            if (employeeManager == null) throw new ArgumentNullException();
            _employeeManager = employeeManager;

            if (mapper == null) throw new ArgumentNullException();
            _mapper = mapper;
        }

        [HttpGet]
        [ResponseType(typeof(List<EmployeeViewModel>))]
        [AllowAnonymous]
        public IHttpActionResult GetEmploymentDetails()
        {
            var employmentDetails = _mapper.Map<List<EmployeeViewModel>>(_employeeManager.GetEmployeeDetails().ToList());
            return Ok(employmentDetails);
        }
    }
}
