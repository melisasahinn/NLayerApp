using NLayer.Core;
using NLayer.Core.UnitOfWork;
using NLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext= appDbContext;
        }

        public void Commit()
        {
           _appDbContext.SaveChanges();
        }

        public async Task CommitAsycn()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}
