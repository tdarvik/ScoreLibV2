using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IScoreRepository : IRepository<Score>
    {
        Task<List<Score>> GetAllScoresAsync();
    }
}
