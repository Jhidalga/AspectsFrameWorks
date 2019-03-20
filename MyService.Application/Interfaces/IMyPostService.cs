using MyService.Application.Aspects;
using MyService.Application.Dtos;
using MyService.Application.Services;
using NCop.Aspects.Framework;
using NCop.Composite.Framework;
using NCop.Mixins.Framework;
using System.Collections.Generic;

namespace MyService.Application.Interfaces
{
    [TransientComposite]
    [Mixins(typeof(MyPostService))]
    public interface IMyPostService
    {
        [MethodInterceptionAspect(typeof(HelloWorldAspect))]
        void GetPostList();
    }
}
