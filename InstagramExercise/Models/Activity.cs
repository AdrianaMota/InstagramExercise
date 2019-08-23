using System;

using Xamarin.Forms;

namespace InstagramExercise.Models
{
    public class Activity : ContentPage
    {
        public int UserId { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get {

                return String.Format("http://lorempixel.com/100/100/people/{0}", UserId);

                } 
        }
    }
}

