using EmptyViewBindableLayoutPlayground.Models;
using EmptyViewBindableLayoutPlayground.Services;
using Xamarin.Forms;

namespace EmptyViewBindableLayoutPlayground.ViewModels
{
    public class UserProfileViewModel : BindableObject
    {
        private Profile _profile;

        public UserProfileViewModel()
        {
            Profile = ProfileService.Instance.GetProfile();
        }

        public Profile Profile
        {
            get { return _profile; }
            set
            {
                _profile = value;
                OnPropertyChanged();
            }
        }
    }
}