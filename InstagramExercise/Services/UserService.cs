using System;
using System.Collections.Generic;
using InstagramExercise.Models;
using Xamarin.Forms;
using System.Linq;

namespace InstagramExercise.Services
{
    public class UserService : ContentPage
    {
        private List<User> UserList = new List<User>
        {
            new User { NewUserId = 1, Name = "Jenny Dalby" },
            new User { NewUserId = 2, Name = "Jonv" },
            new User { NewUserId = 3, Name = "RachelMartin" },
            new User { NewUserId = 4, Name = "Nivan Jay" },
            new User { NewUserId = 5, Name = "SanazZ" },
            new User { NewUserId = 6, Name = "NextLab" },
            new User { NewUserId = 7, Name = "Alex B" },
            new User { NewUserId = 8, Name = "Tara Chang" },
            new User { NewUserId = 9, Name = "Tom K" }
        };
        public User GetUsers(int userId)
        {
            return UserList.SingleOrDefault(u => u.NewUserId == userId);

        }
    }
}

