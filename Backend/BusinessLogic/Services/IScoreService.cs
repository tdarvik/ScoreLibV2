using Entities.DataTransferObjects;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public interface IScoreService
    {
        Task<IEnumerable<ScoreDto>> GetAllScores();
    }
}