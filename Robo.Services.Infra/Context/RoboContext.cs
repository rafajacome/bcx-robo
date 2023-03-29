using Microsoft.EntityFrameworkCore;
using Robo.Services.Domain.Entities;

namespace Robo.Services.Infra.Context
{
    public class RoboContext : DbContext
    {
        public RoboContext(DbContextOptions<RoboContext> options) : base(options)
        {
        }
        public DbSet<ArmEntity> Arm { get; set; }
        public DbSet<HeadEntity> Head { get; set; }
    }
}
