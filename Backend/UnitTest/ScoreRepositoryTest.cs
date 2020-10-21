using BusinessLogic.Services;
using Contracts;
using Entities.Models;
using Moq;
using ReactCoreAssetBackend.Controllers;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTest
{
    public class ScoreRepositoryTest : MemoryTestBase
    {
        private readonly Mock<IScoreService> _scoreService;
        private readonly Mock<ILoggerManager> _logger;
        private readonly ScoreController _sut;

        public ScoreRepositoryTest()
        {
            _context.Scores.AddRange(Scores());
        }

        [Fact]
        public async Task GetAllScoresAsync_NoFilter()
        {
            // Arrange 
            var repository = new ScoreRepository(_context);

            // Act
            var result = await repository.GetAllScoresAsync();

            // Assert
            Assert.Single(result);
            // Assert.Equal(1, result.Count);
        }


        private List<Score> Scores()
        {
            return new List<Score>
            {
                new Score
                {
                    Id = Guid.Parse("d214e4d3-0519-48a1-a055-1b35cf369451"),
                    Title = "Beethoven",
                    OpusNr = "84",
                    PhysicalForm = "Paperback",
                    Location = "Folder 1",
                    Published = 2004,
                    Bind = "",
                    Version = "1",
                    Type = "Opera"
                }
            };
        }
    }
}
