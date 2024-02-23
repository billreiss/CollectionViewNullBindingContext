namespace CollectionViewNullBindingContext
{
    public partial class MainPage : ContentPage
    {
        public List<string> Items { get; set; }

        public MainPage()
        {
            Items = new List<string>();
            for (int i= 0; i< 10; i++)
            {
                Items.Add($"Item {i}");
            }
            this.BindingContext = this;
            InitializeComponent();
        }
    }
}
