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
        private readonly IScoreRepository _scoreRepository;
        public ScoreService(
            IRepositoryWrapper repository,
            IMapper mapper,
            IScoreRepository scoreRepository)
        {
            _repository = repository;
            _scoreRepository = scoreRepository;
        }

        public async Task<IEnumerable<ScoreDto>> GetAllScores()
        {
            var scores = await _scoreRepository.GetAllScoresAsync();
            return _mapper.Map<IEnumerable<ScoreDto>>(scores);
        }
    }
}