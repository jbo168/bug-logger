using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bug.Logger.DAL.Interface;

namespace Bug.Logger.DAL
{
    public class BugRepository : IBugRepository
    {
        public Task<IEnumerable<Common.Bug>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
