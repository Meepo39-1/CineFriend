using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Movies
{   
    record Settings;
    public class MoviePlayer
    {
        public Movie? movie;
        Settings settings;

        Settings Settings { get; }


        public void TurnOn()
        {

        }
        public void TurnOff()
        {

        }
        
    }
}
