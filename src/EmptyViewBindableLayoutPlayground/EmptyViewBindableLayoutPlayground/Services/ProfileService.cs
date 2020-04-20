using EmptyViewBindableLayoutPlayground.Models;
using System.Collections.Generic;

namespace EmptyViewBindableLayoutPlayground.Services
{
    public class ProfileService
    {
        private static ProfileService _instance;

        public static ProfileService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProfileService();

                return _instance;
            }
        }

        public Profile GetProfile()
        {
            return new Profile
            {
                Banner = "sevilla01.jpg",
                Picture = "javier.jpg",
                Name = "Javier Suárez Ruiz",
                Location = "Sevilla",
                About = "Community helper, speaker, geek, former Microsoft MVP. Senior Software Engineer at Microsoft.",
                Friends = new List<Friend>
                {
                     new Friend { Name = "Miguel", Picture = "miguel.jpg" },
                     new Friend { Name = "David", Picture = "david.jpg" },
                     new Friend { Name = "Rui", Picture = "rui.jpg" },
                     new Friend { Name = "Matthew", Picture = "matthew.jpg" }
                },
                Gallery = new List<GalleryItem>()
            };
        }
    }
}