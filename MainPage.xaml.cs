namespace Module01Activity02
{
    public partial class MainPage : ContentPage
    {
        public string Firstname { get; set; }
        public Color ColorRed { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Firstname = "Welcome to .NET MAUI Markup Extension!";
            ColorRed = Colors.Red;

            this.BindingContext = this;
        }
        
        private void OnChangedLabelNameStatic(object sender, EventArgs e)
        {
            this.Resources["StaticUsername"] = "Peter Butter";

        }
        private void OnChangedLabelNameDynamic(object sender, EventArgs e)
        {
            this.Resources["DynamicUsername"] = "Amazing!";
        }

        private void OnChangedBackgroundColorGreen(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.Green;
        }

        private void OnChangedBackgroundColorLightGreen(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.LightGreen;
        }
        private void OnChangedBoxViewColor(object sender, EventArgs e)
        {
            this.Resources["DynamicBoxColor"] = Colors.SkyBlue;
        }
    }

}
