using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ScoreRepository : Repository<Score>, IScoreRepository
    {
        public ScoreRepository(RepositoryContext context) : base(context)
        {

        }
        public async Task<List<Score>> GetAllScoresAsync()
        {
            var scores = await _dbContext.Scores.ToListAsync();
            return scores;
        }
    }
}
