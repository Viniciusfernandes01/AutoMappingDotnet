using AutoMapper;
using AutoMappingDotnet.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AutoMappingDotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IMapper _mapper;

        public EmployeeController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult Post(EmployeeInputModel employeeInputModel)
        {
            var employee = _mapper.Map<Employee>(employeeInputModel);

            return Ok(employee);
        }

        [HttpGet]
        public IActionResult GetCPF(int id)
        {
            var employee = new Employee() { Id = Guid.NewGuid(), CPF = "456", Gender = "male", Name = "vi" };

            var cpf = _mapper.Map<EmployeeViewModel>(employee);

            return Ok(cpf);
        }
    }
}
