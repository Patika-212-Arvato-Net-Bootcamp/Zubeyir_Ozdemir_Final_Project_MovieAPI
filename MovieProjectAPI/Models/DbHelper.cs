using MovieProjectAPI.EfCore;

namespace MovieProjectAPI.Models
{
    public class DbHelper
    {
        private EF_DataContext _context;
        public DbHelper(EF_DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <returns></returns>
        public List<MovieModel> GetMovies()
        {
            List<MovieModel> response = new List<MovieModel>();
            var dataList = _context.Movies.ToList();
            dataList.ForEach(row => response.Add(new MovieModel()
            {
                id = row.id,
                adult = row.adult,
                belongs_to_collection = row.belongs_to_collection,
                budget = row.budget,
                genres = row.genres,
                homepage = row.homepage,
                imdb_id = row.imdb_id,
                original_language = row.original_language,
                original_title = row.original_title,
                overview = row.overview,
                popularity = row.popularity,
                poster_path = row.poster_path,
                production_companies = row.production_companies,
                production_countries = row.production_countries,
                release_date = row.release_date,
                revenue = row.revenue,
                runtime = row.runtime,
                spoken_languages = row.spoken_languages,
                status = row.status,
                tagline = row.tagline,
                title = row.title,
                video = row.video,
                vote_average = row.vote_average,
                vote_count = row.vote_count,
            }));
            return response;
        }
        public MovieModel GetMovieById(int id)
        {
            MovieModel response = new MovieModel();
            var row = _context.Movies.Where(d=> d.id.Equals(id)).FirstOrDefault();
            return new MovieModel()
            {
                id = row.id,
                adult = row.adult,
                belongs_to_collection = row.belongs_to_collection,
                budget = row.budget,
                genres = row.genres,
                homepage = row.homepage,
                imdb_id = row.imdb_id,
                original_language = row.original_language,
                original_title = row.original_title,
                overview = row.overview,
                popularity = row.popularity,
                poster_path = row.poster_path,
                production_companies = row.production_companies,
                production_countries = row.production_countries,
                release_date = row.release_date,
                revenue = row.revenue,
                runtime = row.runtime,
                spoken_languages = row.spoken_languages,
                status = row.status,
                tagline = row.tagline,
                title = row.title,
                video = row.video,
                vote_average = row.vote_average,
                vote_count = row.vote_count,
            };
         
        }
        /// <summary>
        /// It serves the POST/PUT/PATCH
        /// </summary>
        public void SaveMovie(MovieModel movieModel)
        {
            Movie dbTable  = new Movie();
            if(movieModel.id > 0)
            {
                //PUT
                dbTable = _context.Movies.Where(d => d.id.Equals(movieModel.id)).FirstOrDefault();
                if(dbTable != null)
                {
                    //...
                }
                else
                {
                    //POST
                    dbTable.adult = movieModel.adult;
                    dbTable.belongs_to_collection = movieModel.belongs_to_collection;
                    dbTable.budget = movieModel.budget;
                    dbTable.genres = movieModel.genres;
                    dbTable.homepage = movieModel.homepage;
                    dbTable.imdb_id = movieModel.imdb_id;
                    dbTable.original_language = movieModel.original_language;
                    dbTable.original_title = movieModel.original_title;
                    dbTable.overview = movieModel.overview;
                    dbTable.popularity = movieModel.popularity;
                    dbTable.poster_path = movieModel.poster_path;
                    dbTable.production_companies = movieModel.production_companies;
                    dbTable.production_countries = movieModel.production_countries;
                    dbTable.release_date = movieModel.release_date;
                    dbTable.revenue = movieModel.revenue;
                    dbTable.runtime = movieModel.runtime;
                    dbTable.spoken_languages = movieModel.spoken_languages;
                    dbTable.status = movieModel.status;
                    dbTable.tagline = movieModel.tagline;
                    dbTable.title = movieModel.title;
                    dbTable.video = movieModel.video;
                    dbTable.vote_average = movieModel.vote_average;
                    dbTable.vote_count = movieModel.vote_count;
                    _context.Movies.Add(dbTable);
                }

                _context.SaveChanges();

            }
        }

        /// <summary>
        /// DELETE
        /// </summary>
        /// <param name="id"></param>
        public void DeleteMovie(int id)
        {
            var movie = _context.Movies.Where(d => d.id.Equals(id)).FirstOrDefault();
            if(movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
            }
        }

    }
}
