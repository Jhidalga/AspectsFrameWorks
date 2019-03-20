using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using MyService.Infrastructure.Models;
using System;

namespace MyService.Infrastructure.Util
{
    public class VirtualBlogginContext : BloggingContext
    {
        public VirtualBlogginContext(DbContextOptions<BloggingContext> options) : base(options)
        {
            LoadContext();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        base.OnConfiguring(optionsBuilder
        .UseInMemoryDatabase(Guid.NewGuid().ToString())
        .ConfigureWarnings(x => x.Ignore(InMemoryEventId.TransactionIgnoredWarning)));

        private void LoadContext()
        {
            var initBlog = new Blog()
            {
                BlogId = 1,
                Url = "myPost.com"
            };
            Add(initBlog);
            Add(new Post()
            {
                Title = "MyPost",
                Content = "DataVirtualMock",
                PostId = 1,
                Blog = initBlog,
                BlogId = initBlog.BlogId


            });

            SaveChanges();

            Blogs.Load();
            Posts.Load();
        }
    }
}
