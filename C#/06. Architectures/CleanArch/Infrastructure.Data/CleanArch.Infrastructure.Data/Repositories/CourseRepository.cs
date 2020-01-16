﻿using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDBContext context;

        public CourseRepository(UniversityDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Course> GetCourses()
        {
            return this.context.Courses;
        }
    }
}
