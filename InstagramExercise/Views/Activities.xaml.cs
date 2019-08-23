using System;
using System.Collections.Generic;
using InstagramExercise.Models;
using Xamarin.Forms;


namespace InstagramExercise.Views
{
    public partial class Activities : ContentPage
    {
        private ActivityService _ActivityService = new ActivityService();

        public Activities()
        {
            InitializeComponent();

            _ActivityService = new ActivityService();

            listView.ItemsSource = _ActivityService.GetActivities();
        }
        void OnItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var activity = e.SelectedItem as Activity;

            listView.SelectedItem = null;

            Navigation.PushAsync(new Profile(activity.UserId));

        }
    }
}
