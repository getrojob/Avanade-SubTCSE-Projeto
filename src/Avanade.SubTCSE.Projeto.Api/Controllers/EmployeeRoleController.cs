﻿using Avanade.SubTCSE.Projeto.Application.Dtos.EmployeeRole;
using Avanade.SubTCSE.Projeto.Application.Interfaces.EmployeeRole;
using Avanade.SubTCSE.Projeto.Application.Services.EmployeeRole;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Api.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1", Deprecated = false)]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    public class EmployeeRoleController : ControllerBase
    {
        private readonly IEmployeeRoleAppService _employeeRoleAppService;

        public EmployeeRoleController(IEmployeeRoleAppService employeeRoleAppService)
        {
            _employeeRoleAppService = employeeRoleAppService;
        }

        [HttpPost(Name = "EmployeeRole")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(EmployeeRoleDto), StatusCodes.Status201Created), Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateEmployeeRole([FromBody] EmployeeRoleDto employeeRoleDto)
        {
            var item = await _employeeRoleAppService.AddEmployeeRoleAsync(employeeRoleDto);

            if (!item.ValidationResult.IsValid)
            {
                return BadRequest(string.Join('\n', item.ValidationResult.Errors));
            }

            return Ok();
        }

        [HttpGet(Name = "EmployeeRoleGet")]
        [ProducesResponseType(typeof(List<EmployeeRoleDto>), StatusCodes.Status200OK), Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllEmpoyeeRole()
        {
            var item = await _employeeRoleAppService.FindAllEmployeeRoleAsync();

            return Ok(item);
        }

        [HttpGet(template: "{id}")]
        [ProducesResponseType(typeof(EmployeeRoleDto), StatusCodes.Status200OK), Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetById(string id)
        {
            var item = await _employeeRoleAppService.GetById(id);

            return Ok(item);
        }


    }
}