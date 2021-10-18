using DevOpsDemo.Controllers;
using DevOpsDemo.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using DevOpsDemo.Models;
using Shouldly;
using Xunit;

namespace DevOpsDemo.Tests
{
    public class PostTestController : IDisposable
    {
        private PostRepository _repostory;

        public PostTestController()
        {
            _repostory = new PostRepository();
        }

        [Fact]
        public void Test_Index_View_Result()
        {
            // Arrange
            var controller = new HomeController(null, _repostory);

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Test_Index_Return_Result()
        {
            // Arrange
            var controller = new HomeController(null, _repostory);

            // Act
            var result = controller.Index();

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Test_Index_GetPosts_MatchData()
        {
            // Arrange
            var controller = new HomeController(null, _repostory);

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<List<PostViewModel>>(viewResult.ViewData.Model);

            model.Count.ShouldBe(3);
            model[0].PostId.ShouldBe(101);
            model[0].Title.ShouldBe("DevOps Demo Title 1");
        }
        public void Dispose()
        {
            _repostory = null;
        }
    }
}
