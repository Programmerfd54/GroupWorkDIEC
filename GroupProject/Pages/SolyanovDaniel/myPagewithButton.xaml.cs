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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GroupProject.Pages.SolyanovDaniel
{
    /// <summary>
    /// Логика взаимодействия для myPagewithButton.xaml
    /// </summary>
    public partial class myPagewithButton : Page
    {
        public myPagewithButton()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (text.Text != "")
            {
                MessageBox.Show("Message send");
            }
        }
    }
}
