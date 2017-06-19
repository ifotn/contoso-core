﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// ref Models
using ContosoCore.Models;

// add ef ref
using Microsoft.EntityFrameworkCore;

namespace ContosoCore.Data
{
    // inherit from DbContext
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        // rename tables to singular
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
        }
    }
}
