using System.Windows;


namespace Estacionamento_WPF.View
{

    public partial class UpdateParkingRecordWindow : Window
    {
        public static UpdateParkingRecordWindow Instance { get; private set; }

        public UpdateParkingRecordWindow()
        {
            InitializeComponent();
            Instance = this;
        }
    }
}
