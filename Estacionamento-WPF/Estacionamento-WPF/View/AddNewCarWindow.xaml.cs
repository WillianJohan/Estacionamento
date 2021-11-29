using System.Windows;


namespace Estacionamento_WPF.View
{
    public partial class AddNewCarWindow : Window
    {
        public static AddNewCarWindow Instance { get; private set; }

        public AddNewCarWindow()
        {
            InitializeComponent();
            Instance = this;
        }
    }
}
