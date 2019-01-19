using BindableLayoutPlayground.Models;
using System.Collections.Generic;

namespace BindableLayoutPlayground.Services
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
                Banner = "sevilla01",
                Picture = "javier",
                Name = "Javier Suárez Ruiz",
                Location = "Sevilla",
                About = "Community helper, speaker, geek, former Microsoft MVP. Senior Software Engineer at Microsoft.",
                Friends = new List<Friend>
                 {
                     new Friend { Name = "Miguel", Picture = "miguel" },
                     new Friend { Name = "David", Picture = "david" },
                     new Friend { Name = "Rui", Picture = "rui" },
                     new Friend { Name = "Matthew", Picture = "matthew" }
                 },
                Gallery = new List<GalleryItem>
                 {
                     new GalleryItem { GalleryItemType = GalleryItemType.Medium, Picture = "sevilla01" },
                     new GalleryItem { GalleryItemType = GalleryItemType.Medium, Picture = "sevilla02" },
                     new GalleryItem { GalleryItemType = GalleryItemType.Big, Picture = "sevilla03" },
                     new GalleryItem { GalleryItemType = GalleryItemType.Default, Picture = "sevilla04" },
                     new GalleryItem { GalleryItemType = GalleryItemType.Default, Picture = "sevilla05" },
                     new GalleryItem { GalleryItemType = GalleryItemType.Default, Picture = "sevilla06" },
                     new GalleryItem { GalleryItemType = GalleryItemType.Default, Picture = "sevilla07" }
                 }
            };
        }
    }
}