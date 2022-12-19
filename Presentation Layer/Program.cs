using MediatR;

using Infrastructure.InMemoryRepositorys;
using Application.Repositorys.Users;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Infrastructure.EntityFrameworkDatabase;
using Infrastructure.EntityFrameworkDataBase.Data;

public class Program
{
    void LoginPage()
    {
        //render UI elements -> basic form
        //sign in => read database
        //sign up => write database
    }
    void UserPage()
    {   /*components:
         * User Data, ref to MovieLibrary (every movie has a watch me button),
         * ref to FriendList
        *WatchMovie Buttom ref to start cinemaRoom, ref to connect cinemaROOM link*/
        //render UI elements => User data + Movie Library reference

    }
    void FriendListPage()
    {
        /* baisc SearchBar with username and some stats of that particular user
         * Function to add or remove friends
         */

    }
    void MovieLibrary()
    {
        /*same as FriendListPage, only that when you add a movie it will open a forum
         * with: genre params, maybe pic, and the actual file content*/
    } 
    void WatchMovieAction()
    {    //renders button
         //movie upload field
        //loads CinemaRoom Page
    }

    void CinemaRoomPage()
    {
        /* Components:
         * Movie player in the center of the screen ->ref to MoviePLayer Infrastructure Object
         * in top right corner, user Name ( option to hide)
         * right portion of the page, the chat (transition to show only when an event is triggered
         * (mouse, keyboard)
         * buttons at the bottom of the screen:
         * chat, get link, add friends (only for addmin), upload movie button (only for admin)-> functions in CinemaRoom Infrastructure object
         * ID for cinemaRoom is generated trough userName that is gonna be unique
         * every admin has one unique cinemaRoom
         */   
    }
    
   

    static void Main()
    {
        /*var diContainer = new ServiceCollection()

            .AddScoped<IUserRepository, InMemoryUserRepository>()
            .AddMediatR(typeof(IUserRepository))
               .AddDbContext<Infrastructure.EntityFrameworkDataBase.Data.ApplicationDbContext>(
            options => options.UseSqlServer())

            .BuildServiceProvider();*/
       
        /*var diContainer = new ServiceCollection().
                AddDbContext<ApplicationDbContext>(
            options => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = BazaDeDateProiectEdi; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
      ))
                .BuildServiceProvider();
        
        */
     

     /*   var mediator = diContainer.GetRequiredService<IMediator>();

        var UserId = await mediator.Send(new CreateUserCommand
        {
            userInfo = null
        }) ;
        string message;
        var chatID = await mediator.Send(new SendMessageCommand
        {
            UserId = UserId,
            Message = message
        }); ;*/

        
        
        //to be continued 
        


    }
}