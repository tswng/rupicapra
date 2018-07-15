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
    /// Interaction logic for SqlTab.xaml
    /// </summary>
    public partial class SqlTab : TabItem
    {
        public SqlTab(String name) : base ()
        {
            InitializeComponent();

            Header = name;

            resultMessages.AppendText(Environment.NewLine);
            resultMessages.AppendText(new Random().Next().ToString());
        }
    }
}
