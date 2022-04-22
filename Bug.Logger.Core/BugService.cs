using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bug.Logger.Core.Interface;

namespace Bug.Logger.Core
{
    public class BugService : IBugService
    {
        public Task<IEnumerable<Common.Bug>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
