using Domain.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositorys.Movies
{
    public interface IMoviePlayerRepository
    {
        public void CreateMoviePlayer();
        public void DeleteMoviePlayer();
        public void UploadMovie(Movie movie);
        //play cred ca ar trebui sa fie in client, deoarece tot filmul se incarca deodata
        //public void Play();
    }
}
