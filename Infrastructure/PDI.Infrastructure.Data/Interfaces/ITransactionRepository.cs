﻿using PDI.Domain.Entities;
using PDI.Domain.Interfaces;

namespace PDI.Infrastructure.Data.Interfaces
{
    public interface ITransactionRepository : IRepository<Transaction>
    {
    }
}