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

namespace JournalApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            JournalBDEntities context = new JournalBDEntities();
            MainFrame.Navigate(new Page1());
        }



        private void disciplinesMouseEnter(object sender, MouseEventArgs e)
        {
            disciplines.Visibility = Visibility.Visible;
        }

        private void disciplinesMouseLeave(object sender, MouseEventArgs e)
        {
            disciplines.Visibility = Visibility.Collapsed;
        }

        private void groupMouseEnter(object sender, MouseEventArgs e)
        {
            group.Visibility = Visibility.Visible;

        }

        private void groupMouseLeave(object sender, MouseEventArgs e)
        {
            group.Visibility = Visibility.Collapsed;
        }
    }
}
