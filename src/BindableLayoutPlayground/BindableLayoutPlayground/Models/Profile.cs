using System.Collections.Generic;

namespace BindableLayoutPlayground.Models
{
    public class Profile
    {
        public string Banner { get; set; }
        public string Picture { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string About { get; set; }
        public List<Friend> Friends { get; set; }
        public List<GalleryItem> Gallery { get; set; }
    }

    public class Friend
    {
        public string Picture { get; set; }
        public string Name { get; set; }
    }

    public enum GalleryItemType
    {
        Default,
        Medium,
        Big
    }

    public class GalleryItem
    {
        public GalleryItemType GalleryItemType { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
    }
}
