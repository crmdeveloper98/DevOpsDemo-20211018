using DevOpsDemo.Models;
using System.Collections.Generic;

namespace DevOpsDemo.Repository
{
    public class PostRepository : IPostRepository
    {
        public List<PostViewModel> GetPosts()
        {
           return new List<PostViewModel>
            {
                new PostViewModel()
                {
                    PostId = 101,
                    Title = "DevOps Demo Title 1",
                    Description = "DevOps Description 1",
                    Author = "Mukesh Kumar"
                },
                new PostViewModel()
                {
                    PostId = 102,
                    Title = "DevOps Demo Title 2",
                    Description = "DevOps Description 2",
                    Author = "Banky Chamber"
                },
                new PostViewModel()
                {
                    PostId = 103,
                    Title = "DevOps Demo Title 3",
                    Description = "DevOps Description 3",
                    Author = "Rahul Rathor"
                }
            };            
        }
    }
}
