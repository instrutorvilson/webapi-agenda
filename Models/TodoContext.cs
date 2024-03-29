﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinhaApi.Models;

namespace MinhaApi.Models
{
    public class TodoContext : DbContext
    {
       /* public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
        {
        }*/


        public DbSet<TodoItem> TodoItems { get; set; } = null!;
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");
       
        public DbSet<MinhaApi.Models.Contato> Contato { get; set; }
        
    }
}
