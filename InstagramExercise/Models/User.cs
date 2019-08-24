using System;

using Xamarin.Forms;

namespace InstagramExercise.Models
{
    public class User : ContentPage
    {
        public int NewUserId { get; set; }
        public string Name { get; set; }
        public string Description { get {
                return String.Format("Hello!! my name is {0}! :)", Name);
            } }
        public string ImageUrl { get
            {
                return String.Format("http://lorempixel.com/200/200/people/{0}", NewUserId);
            }
        }

        internal static User SingleOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}

