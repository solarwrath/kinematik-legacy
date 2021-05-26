using System.Threading.Tasks;
using Kinematik.Database.DbContexts;
using Kinematik.Core.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kinematik.Application.Api.Movie
{
    [ApiController]
    [Route("/api/movie")]
    public class MovieController
    {
        private readonly KinematikContext dbContext;

        public MovieController(
            KinematikContext dbContext
        )
        {
            this.dbContext = dbContext;
        }
        
        [HttpGet]
        [Route("get-first")]
        public async Task<Core.Models.Entities.Film> GetFirstMovie()
        {
            return await this.dbContext.Movies.FirstOrDefaultAsync();
        }
    }
}