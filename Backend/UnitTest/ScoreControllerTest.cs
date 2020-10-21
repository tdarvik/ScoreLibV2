using BusinessLogic.Services;
using Contracts;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using Moq;
using ReactCoreAssetBackend.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTest
{
    public class ScoreControllerTest
    {
        private readonly Mock<IScoreService> _scoreService;
        private readonly Mock<ILoggerManager> _logger;
        private readonly ScoreController _sut;

        public ScoreControllerTest()
        {
            _scoreService = new Mock<IScoreService>();
            _sut = new ScoreController(_scoreService.Object, _logger.Object);
        }

        [Fact]
        public async Task GetAllScoresAsync()
        {
            // Arrange 
            List<ScoreDto> scores = new List<ScoreDto> { new ScoreDto(), new ScoreDto() };
            _scoreService.Setup(r => r.GetAllScores()).ReturnsAsync(scores);

            // Act
            var result = await _sut.GetAllScores();
            var okResult = result as OkObjectResult;

            // Assert
            Assert.NotNull(okResult);
            Assert.Equal(200, okResult.StatusCode);
        }

        //[Fact]
        //public async Task GetEmployeeByAsync()
        //{
        //    // Arrange 
        //    _scoreService.Setup(r => r.GetEmployeeByIdAsync(It.IsAny<Guid>())).ReturnsAsync(new EmployeeDto());

        //    // Act
        //    var result = await _sut.GetEmployeeById(Guid.Parse("8d8a8683-ed27-4807-9d70-96775e7e800b"));
        //    var okResult = result as OkObjectResult;

        //    // Assert
        //    Assert.NotNull(okResult);
        //    Assert.Equal(200, okResult.StatusCode);
        //}
    }
}
