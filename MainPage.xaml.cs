namespace Module01Activity02
{
    public partial class MainPage : ContentPage
    {
        public string WelcomeText { get; set; }
        public Color ColorText { get; set; }

        public MainPage()
        {
            InitializeComponent();

            WelcomeText = ".NET MAUI Markup Extensions";
            ColorText = Colors.GreenYellow;


            this.BindingContext = this;
        }
        
        private void OnChangedLabelNameStatic(object sender, EventArgs e)
        {
            this.Resources["StaticText"] = "";

        }
        private void OnChangedLabelNameDynamic(object sender, EventArgs e)
        {
            this.Resources["DynamicText"] = "Great!";
        }

        private void OnChangedBackgroundColorGreen(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.DarkOliveGreen;
        }

        private void OnChangedBackgroundColorBlue(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.Teal;
        }
        private void OnChangedBoxViewColor(object sender, EventArgs e)
        {
            this.Resources["DynamicBoxColor"] = Colors.Red;
        }
    }

}
