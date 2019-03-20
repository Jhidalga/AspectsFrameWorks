using MyService.Application.Dtos;
using System.Collections.Generic;

namespace MyService.Application.Interfaces
{
    public interface IMyPostService
    {
        IList<PostDto> GetPostList();
    }
}
