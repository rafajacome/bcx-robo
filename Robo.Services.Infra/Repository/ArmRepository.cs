using Microsoft.EntityFrameworkCore;
using Robo.Services.Domain.Entities;
using Robo.Services.Domain.Repository;
using Robo.Services.Infra.Context;
using Robo.Services.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Robo.Services.Infra.Repository
{
    public class ArmRepository : BaseRepository<ArmEntity>, IArmRepository
    {
        private DbSet<ArmEntity> dataset;

        public ArmRepository(RoboContext context) : base(context)
        {
            dataset = context.Set<ArmEntity>();
        }
    }

}
