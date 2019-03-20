using Microsoft.AspNetCore.Mvc;
using MyService.Application.Dtos;
using MyService.Application.Interfaces;
using MyService.Application.Services;
using System;
using System.Collections.Generic;

namespace MyService.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyServiceController : ControllerBase
    {

        private readonly IMyPostService service;

        public MyServiceController(IMyPostService _service)
        {
            service = _service ?? throw new ArgumentNullException(nameof(_service));
        }


        [HttpGet]
        public ActionResult<IList<PostDto>> Get()
        {
            try
            {
                return new OkObjectResult(service.GetPostList());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new NotFoundObjectResult(new List<PostDto>());
            }
        }
    }
}
