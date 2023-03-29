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
    public class HeadController : ControllerBase
    {
        private IHead service;
        private readonly ILogger<HeadController> _logger;

        public HeadController(ILogger<HeadController> logger, IHead service)
        {
            _logger = logger;
            this.service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = service.GetState();

            if (result is null)
            {
                Response.StatusCode = StatusCodes.Status500InternalServerError;
                return null;
            }

            Response.StatusCode = StatusCodes.Status200OK;
            return new JsonResult(result);
        }

        [HttpPost]
        public IActionResult ChangeInclination([FromBody] InclinationRequest request)
        {
            var result = false;

            if (request is null)
                return StatusCode(StatusCodes.Status400BadRequest);

                result = service.ChangeInclination(request);

            if (result)
                return StatusCode(StatusCodes.Status200OK, "Estado alterado com sucesso");
            else
                return StatusCode(StatusCodes.Status500InternalServerError, "Estado não alterado. Verifique as regras e tente novamente.");
        }

        public IActionResult ChangeRotation([FromBody] RotationRequest request)
        {
            var result = false;

            if (request is null)
                return StatusCode(StatusCodes.Status400BadRequest);

                result = service.ChangeRotation(request);

            if (result)
                return StatusCode(StatusCodes.Status200OK, "Estado alterado com sucesso");
            else
                return StatusCode(StatusCodes.Status500InternalServerError, "Estado não alterado. Verifique as regras e tente novamente.");
        }
    }
}
