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

namespace IlyasovLanguage
{
    /// <summary>
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        public ClientPage()
        {
            InitializeComponent();
            List<Client> currentClient = IlyasovLanguageEntities.GetContext().Client.ToList();
            ClientListView.ItemsSource = currentClient;

        }

        private void RButtonUp_Checked(object sender, RoutedEventArgs e)
        {
                    }
    }
}
