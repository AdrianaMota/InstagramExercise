using System;
using System.Collections.Generic;
using InstagramExercise.Services;
using Xamarin.Forms;

namespace InstagramExercise.Views
{
    public partial class Profile : ContentPage
    {
        private UserService _UserService = new UserService();

        public Profile(int userId)
        {
            BindingContext = _UserService.GetUsers(userId);

            InitializeComponent();
        }
    }
}
