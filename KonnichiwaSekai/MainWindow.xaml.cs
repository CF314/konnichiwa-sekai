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

namespace KonnichiwaSekai
{
    public partial class MainWindow : Window
    {
        /// <summary>
        /// This programming behind this programs main window.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnResponseClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you!", "こんにちは世界");
        }
    }
}
