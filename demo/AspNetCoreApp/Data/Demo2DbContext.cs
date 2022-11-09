﻿using System;
using AspNetCoreApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreApp.Data;

public class Demo2DbContext : DbContext
{
    public Demo2DbContext(DbContextOptions<Demo2DbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        if (modelBuilder == null)
        {
            throw new ArgumentNullException(nameof(modelBuilder));
        }

        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Employee>().HasKey(e => e.EmployeeId);
    }

    public DbSet<Employee> Employee { get; set; }
    public DbSet<EmployeeHistory> EmployeeHistories { get; set; }
}
