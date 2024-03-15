using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API2_Mission10_Lauren.Data;
    public class BowlerContext : DbContext
{
    public BowlerContext(DbContextOptions<BowlerContext> options) : base(options)
    {

    }
    public DbSet<Bowler> Bowlers { get; set; }
    public DbSet<Team> Teams { get; set; }
}
