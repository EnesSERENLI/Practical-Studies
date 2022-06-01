using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_Movies2.Models;
using WebApi_Movies2.Models.DTO;

namespace WebApi_Movies2.Controllers
{
    public class MoviesController : ApiController
    {
        ImdbDataEntities db = new ImdbDataEntities();
        public IHttpActionResult GetMovies()
        {
            var movies = db.Movies.Select(x => new MovieDTO
            {
                Id = x.Id,
                Title = x.Title,
                Year = x.Year,
                Description = x.Description,
                Rate = x.Rating
            });
            return Json(movies);
        }
        //Random Movie
        public IHttpActionResult GetRandomMovies()
        {
            try
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(1, db.Movies.Count() + 1);
                MovieDTO movie = db.Movies.Select(x => new MovieDTO
                {
                    Id = x.Id,
                    Title = x.Title,
                    Year = x.Year,
                    Description = x.Description,
                    Rate = x.Rating
                }).FirstOrDefault(x => x.Id == randomNumber);
                return Json(movie);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //Random Rating >70 movie
        public IHttpActionResult GetRandomHighRatingMovie()
        {
            try
            {
                Random rnd = new Random();
                List<Movy> highRatingMovies = db.Movies.Where(x=>x.Rating >70).ToList();
                int randomNumber = rnd.Next(1, highRatingMovies.Count());
                List<MovieDTO> movie = highRatingMovies.Select(x => new MovieDTO
                {
                    Id = x.Id,
                    Title = x.Title,
                    Year = x.Year,
                    Description = x.Description,
                    Rate = x.Rating
                }).ToList();
                return Json(movie[randomNumber]);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Search Movie
        public IHttpActionResult GetSearchMovie(string param)
        {
            var result = db.Movies.Where(x=>x.Title.Contains(param)).Select(x=> new MovieDTO
            {
                Id = x.Id,
                Title = x.Title,
                Year = x.Year,
                Description = x.Description,
                Rate = x.Rating
            }).ToList();
            return Json(result);
        }
    }
}
