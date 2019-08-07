using Mo.RasaTrainer.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mo.RasaTrainer.Storage
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TrainerDbContext _dbContext;
        public UnitOfWork(TrainerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Commit()
        {
            return _dbContext.SaveChanges() > 0;
        }

        public async Task<bool> CommitAsync()
        {
            return (await _dbContext.SaveChangesAsync()) > 0;
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
