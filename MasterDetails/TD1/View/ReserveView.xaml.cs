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
using TD1.ViewModel;

namespace TD1.View
{
    /// <summary>
    /// Logique d'interaction pour ReserveView.xaml
    /// </summary>
    public partial class ReserveView : Window
    {

        public ReserveViewModel ViewModel { get; set; }

        public ReserveView(Match m)
        {
            InitializeComponent();
            ViewModel = new ReserveViewModel(m);

            DataContext = ViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
