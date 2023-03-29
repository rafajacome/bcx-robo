using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Robo.Services.Api.Extensions;
using Robo.Services.Api.Helpers;
using Robo.Services.Domain.DataObjects.Request;
using Robo.Services.Domain.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Robo.Services.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ArmController : ControllerBase
    {
        private IArm service;
        private readonly ILogger<ArmController> _logger;

        public ArmController(ILogger<ArmController> logger, IArm service)
        {
            _logger = logger;
            this.service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = service.GetListState();

            if (result is null)
            {
                Response.StatusCode = StatusCodes.Status500InternalServerError;
                return null;
            }

            Response.StatusCode = StatusCodes.Status200OK;
            return new JsonResult(result);
        }


        [HttpPost]
        public IActionResult ChangeFistState([FromBody] FistRequest  request)
        {
            var result = false;

            if (request is null)
                return StatusCode(StatusCodes.Status400BadRequest);

            if (ParameterValidation.ValidateParameterIsNotNull(ObjectToDictionaryHelper.ToDictionary(request)))
                result = service.ChangeFistState(request);

            if (result)
                return StatusCode(StatusCodes.Status200OK, "Estado alterado com sucesso");
            else
                return StatusCode(StatusCodes.Status500InternalServerError, "Houve um erro ao alterar o registro");
        }

        [HttpPost]
        public IActionResult ChangeElbowState([FromBody] ElbowRequest request)
        {
            var result = false;

            if (request is null)
                return StatusCode(StatusCodes.Status400BadRequest);

            if (ParameterValidation.ValidateParameterIsNotNull(ObjectToDictionaryHelper.ToDictionary(request)))
                result = service.ChangeElbowState(request);

            if (result)
                return StatusCode(StatusCodes.Status200OK, "Estado alterado com sucesso");
            else
                return StatusCode(StatusCodes.Status500InternalServerError, "Houve um erro ao alterar o registro");
        }
    }
}
