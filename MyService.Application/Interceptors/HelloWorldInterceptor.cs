using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Castle.DynamicProxy;

namespace MyService.Application.Interceptors
{
    public class HelloWorldInterceptor : Snap.MethodInterceptor
    {
        public override void InterceptMethod(IInvocation invocation, MethodBase method, Attribute attribute)
        {
            throw new NotImplementedException();
        }
    }
}


//CointainerConfiguration

//SnapConfiguration.For<StructureMapAspectContainer>(c =>
//            {
//                // Tell SNAP to only be concerned with stuff starting with this namespace.
//                c.IncludeNamespace("MyService.Application*");
//                // Tell SNAP to intercept any method or class decorated with "DemoLoggingAttribute"
//                // by wrapping execution in your own DemoInterceptor class.
//                c.Bind<DemoLoggingInterceptor>().To<DemoLoggingAttribute>();
//            });