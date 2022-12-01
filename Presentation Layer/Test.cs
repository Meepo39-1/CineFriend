using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Domain.Users;

namespace Presentation_Layer
{
    static public class Test
    { static int nrUsers = 100;
        public static List<User>? users;
        public static void PopulateUsers() {

            for (int i = 0; i < nrUsers; i++)
            {
                users.Add(new User());
        }

        
        static void Main()
        {   
            //create users 
            PopulateUsers();
            //pick lucky user to recieve price
            var rand = new Random();
            var luckyIndex = rand.Next(0, nrUsers);
            var randomHalf = rand.Next(0,1);
            var middle = users.Count() / 2;
    
            if(randomHalf ==0)
                users.Select(user => user.ID).Where(userID => int.Parse(userID) < middle).First(userID => int.Parse(userID) == luckyIndex);
            else
            {
                users.Select(user => user.ID).Where(userID => int.Parse(userID) < middle).First(userID => int.Parse(userID) == luckyIndex);
            }
           
            //get an IEnumerable of users that have more than 1 year subscription to the platform
            var veterans = users.Select(user => user.StartYear).Contains(2021);

            int nrVeterans=0;
            List<string> veteransList;
                if (veterans) {
                    nrVeterans =users.Where(user => user.StartYear == 2022).Count();
                    veteransList = users.Where(user => user.StartYear == 2022).Select(veteran => veteran.Name).ToList();
                }
                else
                {
                    veteransList = null;
           
                }
                ///create a top of veterans based on their number of movies
                var top = veteransList.OrderBy(user => user.movieLibraryLength).Zip(Enumerable.Range(1, veteransList.Count()));

                //Segregate veteran users into age brackets
                string AgeBracket(int age)
                {
                    switch (age)
                    {
                        case < 0:
                            throw new Exception("Impossible age for user");
                        case > 0 and < 18:
                             return "minor";
                        case >= 18 and <= 30:
                            return "young adult";
                        case >=30 and <=1000:
                            return "senior";
                        default:
                            return null;


                    }
                }
                var groups = users.GroupBy(user => AgeBracket(user.age));

                /*find the users with special tag "old soul"
                //old soul = user that is in "minor" age bracket that
                //has movie tastes similar with "seniors" age bracket users
                */
                string title = "old soul";
                var juniors = groups.Where(group => group.Key == "young adult").SelectMany(groupUser => groupUser);
                var seniors = groups.Where(group => group.Key == "seniors").SelectMany(groupUser => groupUser);
                var oldSouls = juniors.Intersect(seniors).ToList();
                
                
                
        }


        static void Main()
        {

        }
    }
}

