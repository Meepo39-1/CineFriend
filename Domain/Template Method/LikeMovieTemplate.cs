using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Template_Method
{
    public abstract class LikeMovieTemplate
    {
        protected abstract void SendApreciation(Information info);

        protected virtual void SearchMovie(string movieName);
        protected virtual void BookMarkMovie(string movie);
        
        public void LikeMovie(Movie movie)
        {
            SendApreciation(Info info);
            SearchMovie(movie);
            BookMarkMovie(movie);
        }
    }
}
