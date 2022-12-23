using Domain.Users;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Movies
{
    public class MovieLibrary  //: IEnumerable
    {
        public int Id { get; set; }


        public User User { get; set; }
        public int UserId { get; set; }
        /// 1 library to many movies
        public List<Movie>? Movies { get; set; }

    }
}
