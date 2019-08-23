using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace InstagramExercise.Models
{
    public class ActivityService : ContentPage
    {
        private List<Activity> ActivityList = new List<Activity>
        {

            new Activity
            {
                UserId = 1,
                Description = "Your Facebook friend Jenny Dalby is on Instagram."
            },
            new Activity
            {
                UserId = 2,
                Description = "Jonv starte following you."
            },
            new Activity
            {
                UserId = 3,
                Description = "RachelMartin liked your photo."
            },
            new Activity
            {
                UserId = 4,
                Description = "Your Facebook friend Nivan Jay is on Instagram."
            },
            new Activity
            {
                UserId = 5,
                Description = "SanazZ sent a photo by @brookeizep"
            },
            new Activity
            {
                UserId = 6,
                Description = "NextLab started following you."
            },
            new Activity
            {
                UserId = 7,
                Description = "Your Facebook friend Alex B is on Instagram."
            },
            new Activity
            {
                UserId = 8,
                Description = "Your Facebook friend Tara Chan is on Instagram."
            },
            new Activity
            {
                UserId = 9,
                Description = "Your Facebook friend Tom K is on Instagram."
            },

        };
        public IEnumerable<Activity> GetActivities()
        {
            return ActivityList;
        }
    }
}

