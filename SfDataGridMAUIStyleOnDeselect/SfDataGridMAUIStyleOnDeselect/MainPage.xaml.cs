namespace SfDataGridMAUIStyleOnDeselect
{

    public record MyData(string Name, string Address, string PhoneNumber);

    public partial class MainPage : ContentPage
    {
        public static List<MyData> _data = [
            new("Name1", "Address1", "1234567890"),
            new("Name2", "Address2", "0987654321"),
            new("Name3", "Address3", "1122334455"),
            ];

        public MainPage()
        {
            InitializeComponent();
            gridContent.ItemsSource = _data;
        }

    }

}
