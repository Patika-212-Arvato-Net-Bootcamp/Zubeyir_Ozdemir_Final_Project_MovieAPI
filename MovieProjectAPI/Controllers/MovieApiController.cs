using Microsoft.AspNetCore.Mvc;
using MovieProjectAPI.EfCore;
using MovieProjectAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieProjectAPI.Controllers
{
    
    [ApiController]
    public class MovieApiController : ControllerBase
    {
        private readonly DbHelper _db;
        public MovieApiController(EF_DataContext eF_DataContext )
        {
            _db = new DbHelper( eF_DataContext );
        }

        // GET: api/<MovieApiController>
        [HttpGet]
        [Route("api/[controller]/GetMovies")]
        public IActionResult Get()
        {
            ResponseType type = ResponseType.Success;

            try
            {
               IEnumerable<MovieModel> data = _db.GetMovies();
               
                if (!data.Any())
                {
                    type = ResponseType.NotFound;
                }
                return Ok(ResponseHandler.GetAppResponse(type, data));
            }
            catch( Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // GET api/<MovieApiController>/5
        [HttpGet]
        [Route("api/[controller]/GetMovieById/{id}")]
        public IActionResult Get(int id)
        {
            ResponseType type = ResponseType.Success;

            try
            {
                MovieModel data = _db.GetMovieById(id);

                if (data == null)
                {
                    type = ResponseType.NotFound;
                }
                return Ok(ResponseHandler.GetAppResponse(type, data));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // POST api/<MovieApiController>
        [HttpPost]
        [Route("api/[controller]/SaveMovie")]
        public IActionResult Post([FromBody] MovieModel model)
        {
            try
            {
                ResponseType type = ResponseType.Success;
                _db.SaveMovie(model);
                return Ok(ResponseHandler.GetAppResponse(type, model));
            }
            catch(Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // PUT api/<MovieApiController>/5
        [HttpPut]
        [Route("api/[controller]/UpdateMovie")]
        public IActionResult Put([FromBody] MovieModel model)
        {
            try
            {
                ResponseType type = ResponseType.Success;
                _db.SaveMovie(model);
                return Ok(ResponseHandler.GetAppResponse(type, model));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // DELETE api/<MovieApiController>/5
        [HttpDelete]
        [Route("api/[controller]/DeleteMovie/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                ResponseType type = ResponseType.Success;
                _db.DeleteMovie(id);
                return Ok(ResponseHandler.GetAppResponse(type, "Delete Successfully"));

            }
            catch(Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }
    }
}
