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

namespace chamois
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            tabControl.Items.Add(new SqlTab("New tab"));
            int itemCount = tabControl.Items.Count;

            if (itemCount >= 0) tabControl.SelectedIndex = itemCount-1;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            ConnectionManagerDialog dialog = new ConnectionManagerDialog();
            bool? result = dialog.ShowDialog();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            AboutDialog dialog = new AboutDialog();
            bool? result = dialog.ShowDialog();
        }
    }
}
