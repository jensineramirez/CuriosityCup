using System;
using System.Collections.Generic;
using System.Text;
using CuriosityCup.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CuriosityCup.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<TestQuestion> TestQuestions { get; set; }
        public DbSet<TestAnswer> TestAnswers { get; set; }
        public DbSet<Test> Tests { get; set; }
        //public DbSet<UserTest> UserTests { get; set; }
        //public DbSet<UserComment> UserComments { get; set; }
    }
}
