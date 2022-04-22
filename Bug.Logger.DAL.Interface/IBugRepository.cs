using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bug.Logger.DAL.Interface
{
    public interface IBugRepository
    {
        public Task<IEnumerable<Common.Bug>>  GetAllAsync();
    }
}
