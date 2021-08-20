using Domain.DataModels;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class AppDbContext : DbContext
    {
        private SqliteConnection inMemorySqlite;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}.db";
            inMemorySqlite = new SqliteConnection($"Data Source={DbPath}");
            inMemorySqlite.Open();
        }
        public DbSet<Animal> Animals { get; set; }
        public string DbPath { get; private set; }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(inMemorySqlite);
    }
}
