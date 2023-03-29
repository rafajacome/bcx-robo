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
    public class HeadRepository : BaseRepository<HeadEntity>, IHeadRepository
    {
        private DbSet<HeadEntity> dataset;

        public HeadRepository(RoboContext context) : base(context)
        {
           
        }
    }
}