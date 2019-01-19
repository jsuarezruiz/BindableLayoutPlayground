using BindableLayoutPlayground.Models;
using Xamarin.Forms;

namespace BindableLayoutPlayground.Styles
{
    public class GalleryItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate BigGalleryItemTemplate { get; set; }
        public DataTemplate MediumGalleryItemTemplate { get; set; }
        public DataTemplate GalleryItemTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var galleryItemType = ((GalleryItem)item).GalleryItemType;

            switch (galleryItemType)
            {
                case GalleryItemType.Big:
                    return BigGalleryItemTemplate;
                case GalleryItemType.Medium:
                    return MediumGalleryItemTemplate;
                case GalleryItemType.Default:
                    return GalleryItemTemplate;
                default:
                    return GalleryItemTemplate;
            }
        }
    }
}