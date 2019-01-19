using BindableLayoutPlayground.ViewModels;
using Xamarin.Forms;

namespace BindableLayoutPlayground.Views
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