﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Movies
{
    public class Movie
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string? Genre { get; set; }
        public string? Length { get; set; }
        public int? Rating { get; set; }
        public string? Location { get; set; }

        //foreign key
        public int? MovieLibraryId { get; set; }
        public MovieLibrary? MovieLibrary { get; set; }


    }
}
