using AspectCore.Injector;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyService.WebApi.Util
{
    public class MyServiceInjector : ServiceCollection
    {

        public IServiceContainer AspectInjector { get; set; }

        public MyServiceInjector()
        {

            AspectInjector = new ServiceContainer();

        }
        
    }
}
