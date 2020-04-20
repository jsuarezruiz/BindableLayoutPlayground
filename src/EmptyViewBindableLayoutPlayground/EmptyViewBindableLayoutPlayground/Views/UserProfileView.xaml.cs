using EmptyViewBindableLayoutPlayground.ViewModels;
using Xamarin.Forms;

namespace EmptyViewBindableLayoutPlayground.Views
{
    public partial class UserProfileView : ContentPage
    {
        public UserProfileView()
        {
            InitializeComponent();

            BindingContext = new UserProfileViewModel();
        }
    }
}