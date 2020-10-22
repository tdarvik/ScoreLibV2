using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class ScoreService : IScoreService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        public ScoreService(
            IRepositoryWrapper repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ScoreDto>> GetAllScores()
        {
            var scores = await _repository.Score.GetAllScoresAsync();
            return _mapper.Map<IEnumerable<ScoreDto>>(scores);
        }
    }
}