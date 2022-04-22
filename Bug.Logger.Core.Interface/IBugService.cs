using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bug.Logger.Core.Interface
{
    public interface IBugService
    {
        public Task<IEnumerable<Common.Bug>> GetAllAsync();
    }
}
