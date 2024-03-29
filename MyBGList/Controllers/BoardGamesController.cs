﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyBGList.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BoardGamesController : ControllerBase
    {
        private readonly ILogger<BoardGamesController> _logger;

        public BoardGamesController(ILogger<BoardGamesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetBoardGames")]
        [ResponseCache(Location =ResponseCacheLocation.Any, Duration = 60)]
        public IEnumerable<BoardGame> Get() {
            return new[]
            {
                new BoardGame()
                {
                    Id = 1,
                    Name= "Axis & Allies",
                    Year = 2000
                },
                new BoardGame()
                {
                    Id = 2,
                    Name = "Citadels",
                    Year = 2000
                },
                new BoardGame()
                {
                    Id = 3,
                    Name = "Terraforming Mars",
                    Year = 2016
                }
            };
        }
    }
}
