﻿using Microsoft.EntityFrameworkCore;

namespace BlogApıDemo.DataAccessLayer
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=CoreBlogApiDb; integrated security=true");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
