using Microsoft.AspNetCore.Mvc;
using MyService.Application.Dtos;
using MyService.Application.Interfaces;
using MyService.Application.Services;
using NCop.Composite.Framework;
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
           // service = _service ?? throw new ArgumentNullException(nameof(_service));
        }


        [HttpGet]
        public void Get()
        {
            try
            {
                var container = new CompositeContainer();

                container.Configure();
                container.Resolve<IMyPostService>();
                service.GetPostList();
                //return new OkObjectResult(new List<PostDto>());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //return new NotFoundObjectResult(new List<PostDto>());
            }
        }
    }
}
