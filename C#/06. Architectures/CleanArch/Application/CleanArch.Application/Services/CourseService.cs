using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository courseRepository;
        private readonly IMediatorHandler bus;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus)
        {
            this.courseRepository = courseRepository;
            this.bus = bus;
        }

        public void Create(CourseViewModel course)
        {
            var createCourseCommand = new CreateCourseCommand(
                    course.Name,
                    course.Description,
                    course.ImageUrl
                );

            this.bus.SendCommand(createCourseCommand);

        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = this.courseRepository.GetCourses()
            };
        }
    }
}
