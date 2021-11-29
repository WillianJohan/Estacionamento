using System.Windows;
using System.Windows.Input;


namespace Estacionamento_WPF.View
{
    public partial class LoginWindow : Window
    {
        public static LoginWindow Instance { get; private set; }

        public LoginWindow()
        {
            InitializeComponent();
            Instance = this;
            passInput.Focus();
        }

        private void passInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter)
                return;

            if (!IsValidPassword())
            {
                MessageBox.Show("Invalid Password");
                passInput.Clear();
                return;
            }

            MainWindow mw = new MainWindow();
            mw.Show();
            Close();
        }

        bool IsValidPassword()
        {
            string passText = passInput.Password;
            return passText.Equals("estacionamento");
        }
    }
}
