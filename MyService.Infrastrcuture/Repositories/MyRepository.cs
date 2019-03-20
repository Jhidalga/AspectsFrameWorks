using Microsoft.EntityFrameworkCore;
using MyService.Infrastructure.Interfaces;
using MyService.Infrastructure.Models;
using MyService.Infrastructure.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyService.Infrastructure.Repositories
{
    public class MyRepository : IMyRepository
    {

        public VirtualBlogginContext context { get; set; }



        public MyRepository()
        {
            context = new VirtualBlogginContext(new DbContextOptions<BloggingContext>());
        }

        public IList<Post> GetPosts()
        {
            try
            {
                return context.Posts.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }
    }
}
