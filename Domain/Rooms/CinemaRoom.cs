using Domain.Exceptions.InvalidParametersExceptions;
using Domain.Exceptions.NotFoundExceptions;
using Domain.Movies;
using Domain.Users;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Rooms
{
    internal class CinemaRoom
    {
        Movie Movie { get; }
        Chat Chat { get; }

        MoviePlayer moviePlayer;

        List<Guest> Guests { get; set; }
        Admin Admin { get; set; }


        public void AddMovie(Movie movie)
        { 
            Debug.WriteLine("adding movie to cinemaroom");
            try
            {
                Debug.WriteLine("Turning on resource = moviePlayer");
                moviePlayer.TurnOn();
                Movie askedMovie = Admin.Movies.GetMovie(movie.Name);

            }
            catch(MovieNotFoundException e)
            {
                Console.WriteLine("You should add a movie that exists");
            }
            catch(InvalidMovieException e)
            {
                Console.WriteLine("You should add a correct movie");
            }
            finally
            {
                moviePlayer.TurnOff();
                Debug.WriteLine("Turning of resource = moviePlayer");
            }
        }

    }
}
