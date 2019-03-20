using MyService.Infrastructure.Models;
using System.Collections.Generic;

namespace MyService.Infrastructure.Interfaces
{
    public interface IMyRepository
    {

        IList<Post> GetPosts();
    }
}
