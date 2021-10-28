using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Estacionamento_WPF.View
{
    /// <summary>
    /// Lógica interna para LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
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
