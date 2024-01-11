namespace NestedScrollView
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            InnerScrollView.ScrollToAsync(0, 0, true);
        }
    }

}
