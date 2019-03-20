using NCop.Aspects.Framework;
using System;
using System.Collections.Generic;
using System.Text;


namespace MyService.Application.Aspects
{
    public class HelloWorldAspect : ActionInterceptionAspect
    {



        public override void OnInvoke(ActionInterceptionArgs args)
        {
            Console.WriteLine("Hola Mundo");
            args.Proceed();
            Console.WriteLine("Esto es un aspecto");
        }

    }
}
