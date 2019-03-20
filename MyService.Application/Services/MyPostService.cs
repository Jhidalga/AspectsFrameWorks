using MyService.Application.Dtos;
using MyService.Application.Interfaces;
using MyService.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;

namespace MyService.Application.Services
{

    public class MyPostService : IMyPostService
    {
        private readonly IMyRepository repository;

        public MyPostService(IMyRepository _repository)
        {
            repository = _repository ?? throw new ArgumentNullException(nameof(_repository));
        }

        public MyPostService()
        {

        }

        public void GetPostList()
        {

            Console.WriteLine("Entra en el metodo");


            //try
            //{

            //    Console.WriteLine("Entra en el metodo");
            //    IList<PostDto> postDtosList = new List<PostDto>();

            //    var myModelList = repository.GetPosts();

            //    foreach (var post in myModelList)
            //    {
            //        postDtosList.Add(new PostDto()
            //        {
            //            Title = post.Title,
            //            Content = post.Content,
            //            BlogId = post.BlogId,
            //            PostId = post.PostId
            //        });
            //    }

            //    return postDtosList;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    throw;
            //}



        }
    }
}
