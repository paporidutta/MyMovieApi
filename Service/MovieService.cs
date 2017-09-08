using MyMovieApi.Models;
using MyMovieApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMovieApi.Service
{
    public interface ImovieService
    {

        List<Movie> Get();
        Movie Get(int id);
        void Add(Movie res);
        void Delete(int id);
        void Update(int id, Movie res);

    }
    public class MovieService : ImovieService
    {
        private Imovie _res;
       
        public MovieService(Imovie resrepo)
        {
            _res = resrepo;
        }
        public void Add(Movie res)
        {
            _res.Add(res);
        }

        public void Delete(int id)
        {
            _res.Delete(id);
        }

        public List<Movie> Get()
        {
           return _res.GetAll();
        }

        public Movie Get(int id)
        {
            return _res.GetOne(id);
        }

        public void Update(int id, Movie res)
        {
            _res.Edit(id, res);
        }
    }
}

    
