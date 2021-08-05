using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MissingPersonApi.Models;

namespace MissingPersonApi.Data
{
    public class MissingPersonApiContext : DbContext
    {
        public MissingPersonApiContext (DbContextOptions<MissingPersonApiContext> options)
            : base(options)
        {
        }

        public DbSet<MissingPersonApi.Models.Permission> Permission { get; set; }

        public DbSet<MissingPersonApi.Models.MissingReport> MissingReport { get; set; }

        public DbSet<MissingPersonApi.Models.Report> Report { get; set; }

        public DbSet<MissingPersonApi.Models.Message> Message { get; set; }
    }
}
