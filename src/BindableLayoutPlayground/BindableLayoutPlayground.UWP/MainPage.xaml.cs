namespace BindableLayoutPlayground.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new BindableLayoutPlayground.App());
        }
    }
}
