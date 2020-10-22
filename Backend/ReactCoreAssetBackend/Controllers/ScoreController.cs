using BusinessLogic.Services;
using Contracts;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReactCoreAssetBackend.Controllers
{
    [Route("api/scores")]
    [ApiController]
    public class ScoreController : ControllerBase
    {
        private readonly IScoreService _scoreService;
        private readonly ILoggerManager _logger;

        public ScoreController(IScoreService scoreService, ILoggerManager logger)
        {
            _scoreService = scoreService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var scores = await _scoreService.GetAllScores();
            return Ok(scores);
        }
    }
}
