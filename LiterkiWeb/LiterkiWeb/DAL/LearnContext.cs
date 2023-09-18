using LiterkiWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace LiterkiWeb.DAL
{
    public class LearnContext : DbContext
    {
        public LearnContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Literki> Letters { get; set; }
        public DbSet<Cyferki> Numbers { get; set; }
    }
}