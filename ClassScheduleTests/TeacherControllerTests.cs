using System;
using ClassSchedule.Controllers;
using ClassSchedule.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace ClassScheduleTests
{
    public class TeacherControllerTests
    {
        public TeacherControllerTests()
        {
        }

        [Fact]
        public void IndexActionMethod_ReturnsAViewResult()
        {
          
            var rep = new Mock<IRepository<Teacher>>();
            var controller = new TeacherController(rep.Object);

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);

        }
    }
}
