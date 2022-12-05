using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Users;

namespace Domain.Meta
{
    public sealed class Logger
    {
        private static Logger _instance;
        private static readonly object _padlock = new object();

        private List<User> _userList;
        private int _userCount;
        private int _activeUsers;

        private Logger()
        {
            _userList = new List<User>();
        }
        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Logger();
                        }
                    }
                }
                return _instance;
            }

        }

        public int UserCount { get; }

        public int ActiveUsers { get; }


        
    }
}
