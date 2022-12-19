using Infrastructure.EntityFrameworkDatabase.Models.Users;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityFrameworkDatabase.Models.Movies
{
    public class MovieLibraryType
    {
   
        public int Id { get; set; }


        public UserType User { get; set; }
        public int UserTypeId { get; set; }
        /// 1 library to many movies
        public  List<MovieType>? Movies { get; set; } 

      

        
    }
}
