using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mo.RasaTrainer.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        bool Commit();

        Task<bool> CommitAsync();
    }
}
