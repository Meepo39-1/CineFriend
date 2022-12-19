using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityFrameworkDatabase.Models.Movies
{
    public class MovieType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Genre { get; set; }
        public string Length { get; set; }
        public int Rating { get; set; }

        //foreign key
        public int MovieLibraryTypeId { get; set; }
        public MovieLibraryType? MovieLibrary { get; set; }


    }
}
