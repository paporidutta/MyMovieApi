using MyMovieApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyMovieApi.Repository
{
    public interface Imovie
    {
        void Add(Movie res);
        void Edit(int id, Movie res);
        void Delete(int id);
        List<Movie> GetAll();
        Movie GetOne(int id);
    }
    public class MovieRepository : Imovie
    {
        private MovieDbContext _resultcontext;
        public MovieRepository(MovieDbContext resultcontext)
        {
            _resultcontext = resultcontext;
        }
        public void Add(Movie res)
        {
            _resultcontext.movies.Add(res);
            _resultcontext.SaveChanges();
        }

        public void Delete(int id)
        {
            Movie res = _resultcontext.movies.FirstOrDefault(m => m.id == id);
            _resultcontext.movies.Remove(res);
            _resultcontext.SaveChanges();
        }

        public void Edit(int id, Movie res)
        {
            Movie updateresult = _resultcontext.movies.FirstOrDefault(m => m.id == id);
            //updateresult.title = res.title;
            //updateresult.poster_path = res.poster_path;
            //updateresult.release_date = res.release_date;
            updateresult.overview = res.overview;


            _resultcontext.SaveChanges();
        }

        public List<Movie> GetAll()
        {
            return _resultcontext.movies.ToList();
        }

        public Movie GetOne(int id)
        {
            Movie res = _resultcontext.movies.FirstOrDefault(m => m.id == id);
            return res;
        }

    }
}