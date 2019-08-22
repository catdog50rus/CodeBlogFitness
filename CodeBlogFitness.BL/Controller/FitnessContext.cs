using CodeBlogFitness.BL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBlogFitness.BL.Controller
{
    class FitnessContext : DbContext
    {
        public FitnessContext() : base("DBConnection") { }

        public DbSet<Activity> Activities { get; set; }
        public DbSet<Eating> Eating { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
