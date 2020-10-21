using BusinessLogic.Services;
using Contracts;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> GetAllScores()
        {
            // var positionsDto = await _scoreService;
            return Ok(null);
        }
    }
}
