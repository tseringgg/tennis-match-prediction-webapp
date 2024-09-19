﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using TennisData.Models.Configurations;
#nullable enable

namespace TennisData.Models;

public partial class TennisDataContext : DbContext
{
    public TennisDataContext()
    {
    }

    public TennisDataContext(DbContextOptions<TennisDataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<match_df_09_01_2024> match_df_09_01_2024s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=JORJEI-PC;Initial Catalog=TennisData;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new Configurations.match_df_09_01_2024Configuration());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
